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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            
            InitializeComponent();
            
            CategorysComboBox.Items.Add("All");
            foreach (Category element in Enum.GetValues(typeof(Category)))
            {
                CategorysComboBox.Items.Add(element);
            }
            try
            {
                allNotes = ProjectManager.ReadingFromFile(); //загрузка списка заметок
            }
            catch (Exception e)
            {
                ProjectManager.WritingToFile(allNotes);
            }

            CategorysComboBox.SelectedIndex = 0; //по умолчанию 1 категория 

            if (allNotes._currentNote != -1 && allNotes._currentNote < TitlesListBox.Items.Count)
            {
                TitlesListBox.SelectedIndex = allNotes._currentNote;
            }
            

        }
            Project allNotes = new Project();
            List<Note> sortNotes = new List<Note>();

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
            ProjectManager.WritingToFile(project);
            Project project2 = new Project();
            project2 = ProjectManager.ReadingFromFile();
            Note[] note1 = new Note[2];
            for (int i = 0; i < 2; i++)
            {
                project2.Glossary.Add(note1[i]);
            }

            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(project2.Glossary[i].Name + "  " + project2.Glossary[i].Category + "  " + project2.Glossary[i].Text + "  " + project2.Glossary[i].TimeCreation);
            }
        }

        

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About help = new About();
            help.Show();
        }

        private void TitlesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            allNotes._currentNote = allNotes.RealIndexes[TitlesListBox.SelectedIndex];

            ProjectManager.WritingToFile(allNotes);

            CategoryTextBox.Clear();
            TitleTextBox.Clear();
            NoteTextBox.Clear();

            

            sortNotes = allNotes.SortWithSelectionCategory(CategorysComboBox.SelectedIndex);

            //заполняем данными правую часть окна
            NoteTextBox.Text = sortNotes[TitlesListBox.SelectedIndex].Name;
            CategoryTextBox.Text = "Category: " + sortNotes[TitlesListBox.SelectedIndex].Category;
            CreateDateTimePicker.Value = sortNotes[TitlesListBox.SelectedIndex].TimeCreation;
            ChangeDateTimePicker.Value = sortNotes[TitlesListBox.SelectedIndex].TimeCreation;
            NoteTextBox.Text = sortNotes[TitlesListBox.SelectedIndex].Text;
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DeleteNote();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ChangeNote();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // CreateNote();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //CreateNote();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
           // ChangeNote();
        }

        private void DeletButton_Click(object sender, EventArgs e)
        {
           // DeleteNote();
        }
    }
}
