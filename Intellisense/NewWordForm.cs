using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace lab5
{
    public partial class NewWordForm : Form
    {
        public NewWordForm()
        {
            InitializeComponent();
            wordNameErrorProvider.SetIconAlignment(newWordBox, ErrorIconAlignment.TopRight);
        }

        public NewWordForm(string word):this()
        {
            newWordBox.Text = word;
        }

        private void wordCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wordOKButton_Click(object sender, EventArgs e)
        {
            if(ValidateWord())
            {
                IntellisenseForm mainForm = (IntellisenseForm)Owner;
                mainForm.AddToNamesList(newWordBox.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Validation error");
            }     
        }

        private bool ValidateWord()
        {
            if (newWordBox.Text == string.Empty)
            {
                wordNameErrorProvider.SetError(newWordBox, "The new word cannot be empty");
                return false;
            }
            else if (newWordBox.Text.All(Char.IsLetter))
            {
                wordNameErrorProvider.SetError(newWordBox, string.Empty);
                return true;
            }
            else
            {
                wordNameErrorProvider.SetError(newWordBox, "Only letter are allowed");
                return false;
            }
        }

        private void newWordBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateWord();
        }
    }
}
