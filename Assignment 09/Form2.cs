using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ServiceNoteSpace;
using System.IO;
using System.Text.RegularExpressions;

namespace FormSpace
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void OpenNewForm()
        {
            Form3 form3 = new Form3
            {
                MdiParent = this
            };

            form3.Show();
        }

        private void MenuStripFileNewNote_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void MenuStripOpen_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();

                        Form3 form3 = new Form3
                        {
                            MdiParent = this
                        };

                        form3.Show();
                        form3.RichTextBox0_TextAddition(fileContent);

                    }
                }
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            var storageFile = string.Empty;

            Form tempChild = this.ActiveMdiChild;

            for (int i = 0; i < tempChild.Controls.Count; i++)
            {
                if (tempChild.Controls[i] is RichTextBox)
                {
                    storageFile = tempChild.Controls[i].Text;
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.Title = "Save a Text File";
            saveDialog.ShowDialog();

            FileStream fileStream1 = (FileStream)saveDialog.OpenFile();

            StreamWriter streamWrite = new StreamWriter(fileStream1);

            using (streamWrite)
            {
                streamWrite.WriteLine(storageFile);
                streamWrite.Close();
            }
        }


        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemFilenames_Click(object sender, EventArgs e)
        {

            string search = string.Empty;

            foreach(Form3 form3 in MdiChildren)
            {
                if (ActiveMdiChild == null)
                {
                    search += $"no text in {form3.Text} \n";
                }
                else
                {
                    search += form3.Controls[0].Text + " \n";
                }
            }

            string finalOutput = string.Empty;

            string textPattern = "((\\([2-9][0-9][0-9]\\))?|([2-9][0-9][0-9]-)?)[2-9][0-9][0-9]-[0-9][0-9][0-9][0-9]";

            //string textPattern = "([a-zA-Z]:)?(\\[.a-zA-Z0-9_-]+)+\\?";


            Regex regexExpression = new Regex(textPattern);

            foreach (var exp in regexExpression.Matches(search))
            {
                finalOutput += exp + " ";
            }

            MessageBox.Show(finalOutput);
        }
    }
}

