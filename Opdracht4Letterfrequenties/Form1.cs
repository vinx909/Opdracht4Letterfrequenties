using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht4Letterfrequenties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetRichTextBoxResult(string result)
        {
            RichTextBoxResult.Text = result;
        }

        private void ButtonCountCharacters_Click(object sender, EventArgs e)
        {
            SetRichTextBoxResult(CharacterCounter.GetCharactersString(TextBoxPath.Text));
        }
    }
}
