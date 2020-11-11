using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;
using System.IO;

namespace NoteAppUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Project project = new Project();
            Note[] note = new Note[2];
            for (int i = 0; i < 2; i++)
            {
               note[i]=new Note("Тестовая заметка "+i, Category.Other, "Заметка для теста", DateTime.Now);
Console.WriteLine(note[i].Name + "  " + note[i].Category + "  " + note[i].Text + "  " + note[i].TimeCreation);
            project.Glossary.Add(note[i]);
            }
            ProjectManager.SaveToFile(project);
        }

    }
}
