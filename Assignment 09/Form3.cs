using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//using ServiceNoteSpace;

namespace FormSpace
{
    public partial class Form3 : Form
    {
        ServiceNotes serviceNotes = new ServiceNotes();


        public Form3()
        {
            InitializeComponent();
        }

        private void RichTextBox0_TextChanged(object sender, EventArgs e)
        {         
            serviceNotes.ServiceNoteInput = richTextBox0.Text;
            Debug.WriteLine(serviceNotes.ServiceNoteInput);
        }

        public void RichTextBox0_TextAddition(string fileStream)
        {
            richTextBox0.Text = fileStream;
            Debug.WriteLine(fileStream);
        }


    }

    internal class ServiceNotes
    {
        string userServiceNotes;

        public string ServiceNoteInput
        {
            get
            {
                return userServiceNotes;
            }
            set
            {
                userServiceNotes = value;
            }
        }
    }
}
