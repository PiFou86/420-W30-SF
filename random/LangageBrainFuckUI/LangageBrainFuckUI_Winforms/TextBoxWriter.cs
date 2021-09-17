using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LangageBrainFuckUI_Winforms
{
    class TextBoxWriter : TextWriter
    {
        private TextBox m_textBox;
        public TextBoxWriter(TextBox p_tb)
        {
            m_textBox = p_tb;
        }

        public override void Write(char p_valeur)
        {
            m_textBox.Text += p_valeur;
        }

        public override void Write(string p_valeur)
        {
            m_textBox.Text += p_valeur;
        }

        public override Encoding Encoding
        {
            get { return Encoding.Unicode; }
        }
    }
}
