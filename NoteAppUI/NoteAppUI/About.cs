using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

       private void GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SNY538/NoteApp/tree/main");
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
