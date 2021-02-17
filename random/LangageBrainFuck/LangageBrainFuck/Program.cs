using System;

namespace LangageBrainFuck
{
    class Program
    {
        static void Main(string[] args)
        {
            string codeDuProgramme = "++++[++++>---<]>-.-[--->+<]>--.----.+++++++++.++++++++.+[->+++<]>.+++++++++.+++++++.++[->+++<]>.--[--->+<]>-.+[->+++<]>++.+++++++++.-[->+++++<]>-.[-->+++++<]>.-..------..-[->++++<]>.+.";

            IInterpreteur interpreteur = new BrainFuckInterpreteur(512);
            interpreteur.ChargerProgramme(codeDuProgramme);
            interpreteur.Executer();
        }
    }
}
