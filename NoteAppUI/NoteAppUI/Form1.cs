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
            Note note = new Note("Тестовая заметка", Category.Other, "Заметка для теста", DateTime.Now);
            project.Glossary.Add(note);
            Console.WriteLine(note.Name + "  " + note.Category + "  " + note.Text + "  " + note.TimeCreation);
         
        }
    }
}
