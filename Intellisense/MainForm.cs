using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace lab5
{
    public partial class IntellisenseForm : Form
    {
        List<string> namesList = new List<string>();
        BindingSource bindingSource = new BindingSource();
        string namePart = "";
        bool sortedAsc = true;
        string clickedWord;
        bool? isWordToAdd = null; 

        public IntellisenseForm()
        {
            InitializeComponent();
            foreach(FontFamily fontFamily in FontFamily.Families)
            {
                fontComboBox.Items.Add(fontFamily.Name);
                fontComboBox.SelectedItem = textBox.Font.Name;
            }
            bindingSource.DataSource = namesList;
            allNamesListBox.DataSource = bindingSource;
        }

        public static bool ValidateName(string name)
        {
            return name != string.Empty && name.All(Char.IsLetter);

        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            if(loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(StringComparer.CurrentCultureIgnoreCase.Compare(Path.GetExtension(loadFileDialog.FileName), ".txt") != 0)
                {
                    MessageBox.Show("The extension is incorrect!");
                }
                else
                {
                    StreamReader sr = new StreamReader(loadFileDialog.FileName);
                    namesList.Clear();
                    while (!sr.EndOfStream)
                    {
                        string name = sr.ReadLine();
                        if (ValidateName(name))
                            namesList.Add(name);
                    }
                    sr.Close();
                    namesList.Sort();
                    RedrawNames();
                    sortedAsc = true;
                }  
            }
        }

        private bool isPartOf(string part, string name)
        {
            return name.Length >= part.Length && StringComparer.CurrentCultureIgnoreCase.Compare(name.Substring(0, part.Length), part) == 0;
        }

        private void wrongPattern()
        {
            namesBox.Visible = false;
            namesBox.DataSource = null;
            namePart = "";
        }

        private void textBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (namesList == null)
                return;
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                Point p = textBox.GetPositionFromCharIndex(textBox.SelectionStart);
                p.Offset(textBox.Location);
                p.Y += textBox.Font.Height;
                namesBox.Location = p;
                List<string> currentList;
                if (namePart.Length == 0)
                    currentList = namesList;
                else
                {
                    currentList = (List<string>)namesBox.DataSource;
                }
                string selectedName = (string)namesBox.SelectedItem;
                namePart += (char)e.KeyCode;
                currentList = currentList.FindAll(name => isPartOf(namePart, name));
                if (currentList.Count == 0)
                {
                    wrongPattern();
                }
                else
                {
                    namesBox.DataSource = currentList;
                    if (selectedName != null && isPartOf(namePart, selectedName))
                        namesBox.SelectedItem = selectedName;
                    namesBox.Visible = true;
                }  
            }
            else if(namesBox.Visible)
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (namesBox.SelectedIndex < namesBox.Items.Count - 1)
                        namesBox.SelectedIndex += 1;
                }
                else if(e.KeyCode == Keys.Up)
                {
                    if (namesBox.SelectedIndex > 0)
                        namesBox.SelectedIndex -= 1;
                }
                else
                {
                    if(e.KeyCode == Keys.Tab)
                    {
                        string addedText = ((string)namesBox.SelectedItem).Substring(namePart.Length);
                        int selection = textBox.SelectionStart;
                        textBox.Text = textBox.Text.Insert(textBox.SelectionStart, addedText);
                        textBox.SelectionStart = selection + addedText.Length;
                    }
                    wrongPattern();
                }
            }    
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) && namesBox.Visible)
                e.Handled = true;
            if (e.KeyCode == Keys.Tab)
                e.SuppressKeyPress = true;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                foreach(string name in namesList)
                {
                    sw.WriteLine(name);
                }
                sw.Close();
            }
        }

        private void RedrawNames()
        {
            bindingSource.ResetBindings(false);
        }

        public void SortNamesList()
        {
            if (sortedAsc)
                namesList.Sort((string left, string right) => StringComparer.CurrentCultureIgnoreCase.Compare(left, right));
            else
                namesList.Sort((string left, string right) => StringComparer.CurrentCultureIgnoreCase.Compare(right, left));
            RedrawNames();
        }

        public bool AddToNamesList(string name)
        {
            if(!namesList.Contains(name))
            {
                namesList.Add(name);
                SortNamesList();
                return true;
            }
            return false;
        }

        public void AddToNamesList(IEnumerable<string> names)
        {
            foreach(string name in names)
            {
                if (!namesList.Contains(name))
                {
                    namesList.Add(name);
                }
            }
            SortNamesList();
        }

        private void allNamesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i=0; i<allNamesListBox.SelectedIndices.Count; i++)
                {
                    namesList.RemoveAt(allNamesListBox.SelectedIndices[i] - i);
                }
                RedrawNames();
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            sortedAsc = !sortedAsc;
            SortNamesList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new NewWordForm().ShowDialog(this);
        }

        private void contextMenuItem_AddClick(object sender, EventArgs e)
        {
            new NewWordForm(clickedWord).ShowDialog(this);
        }

        private void contextMenuItem_RemoveClick(object sender, EventArgs e)
        {
            namesList.Remove(clickedWord);
            RedrawNames();
        }

        private void addWordMenu_Opening(object sender, CancelEventArgs e)
        {
            int index = textBox.GetCharIndexFromPosition(textBox.PointToClient(Cursor.Position));
            if(index < textBox.Text.Length && Char.IsLetter(textBox.Text[index]))
            {
                int leftId, rightId;
                leftId = rightId = index;
                while(leftId - 1 >= 0 && Char.IsLetter(textBox.Text[leftId - 1]))
                {
                    leftId--;
                }
                while(rightId + 1 < textBox.Text.Length && Char.IsLetter(textBox.Text[rightId + 1]))
                {
                    rightId++;
                }
                clickedWord = textBox.Text.Substring(leftId, rightId - leftId + 1);
                if(namesList.Contains(clickedWord))
                {
                    contextMenuItem.Text = $"Remove {clickedWord}";
                    if(isWordToAdd != false)
                    {
                        isWordToAdd = false;
                        contextMenuItem.Click -= contextMenuItem_AddClick;
                        contextMenuItem.Click += contextMenuItem_RemoveClick;
                    }
                }
                else
                {
                    contextMenuItem.Text = $"Add {clickedWord}";
                    if (isWordToAdd != true)
                    {
                        isWordToAdd = true;
                        contextMenuItem.Click -= contextMenuItem_RemoveClick;
                        contextMenuItem.Click += contextMenuItem_AddClick;       
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }   
        }

        private void allNamesListBox_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void allNamesListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> names = new List<string>();
            foreach (string file in files)
            {
                if (StringComparer.CurrentCultureIgnoreCase.Compare(Path.GetExtension(file), ".txt") == 0)
                {
                    StreamReader sr = new StreamReader(file);
                    while(!sr.EndOfStream)
                    {
                        string name = sr.ReadLine();
                        if (ValidateName(name))
                            names.Add(name);
                    }
                    sr.Close();
                }
            }
            AddToNamesList(names);
        }

        private void fontChangeStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, textBox.Font.Style ^ FontStyle.Bold);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, textBox.Font.Style ^ FontStyle.Italic);
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, textBox.Font.Style ^ FontStyle.Underline);
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = colorDialog.Color;
            }
        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.BackColor = colorDialog.Color;
            }
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(fontComboBox.SelectedItem.ToString(), textBox.Font.Size);
        }
    }
}
