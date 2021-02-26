using LangageBrainFuck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangageBrainFuckUI_Winforms
{
    public partial class fPrincipale : Form
    {
        private BrainFuckInterpreteur m_interpreteur;
        private byte[] m_dumpPrecedent = null;
        private int nbBytesParLigne = 16;
        public fPrincipale()
        {
            InitializeComponent();

            this.m_interpreteur = new BrainFuckInterpreteur(512);
            new ObservateurInterpreteur(this.m_interpreteur, ei =>
            {
                if (ei.Type == InterpreteurEventType.INITIALISATION)
                {
                    this.m_dumpPrecedent = ei.MemoryDump;
                    if (ei.EstDebogue)
                    {
                        bAvancer.Enabled = ei.EstDebogue;
                        ColorerInstructionCourante(ei.InstructionSuivante);
                        AfficherMemoire(ei.MemoryDump, -1);
                    }
                }
            });
            new ObservateurInterpreteur(this.m_interpreteur, ei =>
            {
                if (ei.Type == InterpreteurEventType.DEBUT_EXECUTION)
                {
                    bExecuter.Enabled = false;
                    bDeboguer.Enabled = false;
                }
            });
            new ObservateurInterpreteur(this.m_interpreteur, ei =>
            {
                if (ei.Type == InterpreteurEventType.EN_COURS_EXECUTION && ei.EstDebogue)
                {
                    ColorerInstructionCourante(ei.InstructionSuivante);
                    AfficherMemoire(ei.MemoryDump, ei.PositionIndexMemoire);
                }
            });
            new ObservateurInterpreteur(this.m_interpreteur, ei =>
            {
                if (ei.Type == InterpreteurEventType.FIN_EXECUTION)
                {
                    bExecuter.Enabled = true;
                    bDeboguer.Enabled = true;
                    bAvancer.Enabled = false;
                    AfficherMemoire(ei.MemoryDump, ei.PositionIndexMemoire);
                }
            });
        }

        private void AfficherMemoire(byte[] p_memoryDump, int p_positionIndex)
        {
            StringBuilder sb = new StringBuilder();
            List<int> listeDifferences = new List<int>();
            int debutTextPositionIndex = -1;

            sb.AppendLine($"Capacite mémoire : {p_memoryDump.Length} octets");

            sb.Append("".PadLeft(4));
            for (int compt = 0; compt < nbBytesParLigne; ++compt)
            {
                sb.Append("  " + compt.ToString("X2"));
            }

            for (int adresse = 0; adresse < p_memoryDump.Length; ++adresse)
            {
                if (adresse % nbBytesParLigne == 0)
                {
                    sb.AppendLine();
                    sb.Append(adresse.ToString("X2").PadLeft(4, '0'));
                }

                sb.Append("  " + p_memoryDump[adresse].ToString("X2"));
                if (p_memoryDump[adresse] != m_dumpPrecedent[adresse])
                {
                    listeDifferences.Add(sb.Length - 4);
                }
                if (adresse == p_positionIndex)
                {
                    debutTextPositionIndex = sb.Length - 4;
                }
            }

            sb.AppendLine();

            rtbMemoire.Text = sb.ToString();
            listeDifferences.ForEach(diff =>
            {
                rtbMemoire.SelectionStart = diff;
                rtbMemoire.SelectionLength = 2;
                rtbMemoire.SelectionColor = Color.Red;
            });

            if (debutTextPositionIndex >= 0)
            {
                rtbMemoire.SelectionStart = debutTextPositionIndex;
                rtbMemoire.SelectionLength = 2;
                rtbMemoire.SelectionBackColor = Color.LightBlue;
            }
            rtbMemoire.SelectionLength = 0;
            this.m_dumpPrecedent = p_memoryDump;
        }

        private void ColorerInstructionCourante(InformationInstruction instructionSuivante)
        {
            rtbCode.SelectionStart = 0;
            rtbCode.SelectionLength = rtbCode.Text.Length;
            rtbCode.SelectionBackColor = Color.White;
            rtbCode.SelectionColor = Color.Black;

            if (instructionSuivante != null)
            {
                rtbCode.SelectionStart = instructionSuivante.NumeroCaractere - 1;
                rtbCode.SelectionLength = instructionSuivante.Longueur;
                rtbCode.SelectionBackColor = Color.Black;
                rtbCode.SelectionColor = Color.White;
            }
            rtbCode.SelectionLength = 0;
        }

        private void fPrincipale_Load(object sender, EventArgs e)
        {
            // Pour les tests
            rtbCode.Text = "++++[++++>---<]>-.-[--->+<]>--.----.+++++++++.++++++++.+[->+++<]>.+++++++++.+++++++.++[->+++<]>.--[--->+<]>-.+[->+++<]>++.+++++++++.-[->+++++<]>-.[-->+++++<]>.-..------..-[->++++<]>.+.";
            Console.SetOut(new TextBoxWriter(this.tbOut));
        }

        private void bExecuter_Click(object sender, EventArgs e)
        {
            InitialiserAffichages();
            if (ChargerProgramme(rtbCode.Text))
            {
                this.m_interpreteur.Executer();
            }
        }

        private void bDeboguer_Click(object sender, EventArgs e)
        {
            InitialiserAffichages();
            if (ChargerProgramme(rtbCode.Text))
            {
                bExecuter.Enabled = false;
                bDeboguer.Enabled = false;
                bArreter.Enabled = true;
                this.m_interpreteur.Reinitialiser(true);
            }
        }

        private void InitialiserAffichages()
        {
            tbOut.Text = "";
            rtbMemoire.Text = "";
        }

        private bool ChargerProgramme(string p_code)
        {
            bool chargementOk = false;
            try
            {
                this.m_interpreteur.ChargerProgramme(rtbCode.Text);
                chargementOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de syntaxe dans votre programme ! ({ex.Message})", "Erreur");
            }

            return chargementOk;
        }

        private void bAvancer_Click(object sender, EventArgs e)
        {
            this.m_interpreteur.ExecuterUneInstruction();
        }

        private void tsmiOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichier BrainFuck|*.bf|Tous les fichiers|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbCode.Text = File.ReadAllText(ofd.FileName);
                InitialiserBouton();
            }
        }

        private void bArreter_Click(object sender, EventArgs e)
        {
            InitialiserBouton();
        }

        private void InitialiserBouton()
        {
            this.bExecuter.Enabled = true;
            this.bDeboguer.Enabled = true;
            this.bAvancer.Enabled = false;
            this.bArreter.Enabled = false;
        }
    }
}
