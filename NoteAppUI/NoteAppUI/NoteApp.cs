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
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NoteApp.notes";
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
                allNotes = ProjectManager.ReadingFromFile(_path); //загрузка списка заметок
            }
            catch (Exception e)
            {
                ProjectManager.WritingToFile(allNotes, _path);
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
            FillListbox();
            CategorysComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //Лабораторная работа  №2
            //Project project = new Project();
            //Note[] note = new Note[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    note[i] = new Note("Тестовая заметка " + i, Category.Other, "Заметка для теста", DateTime.Now);
            //    Console.WriteLine(note[i].Name + "  " + note[i].Category + "  " + note[i].Text + "  " + note[i].TimeCreation);
            //    project.Glossary.Add(note[i]);
            //}
            //ProjectManager.WritingToFile(project);
            //Project project2 = new Project();
            //project2 = ProjectManager.ReadingFromFile();
            //Note[] note1 = new Note[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    project2.Glossary.Add(note1[i]);
            //}


            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(project2.Glossary[i].Name + "  " + project2.Glossary[i].Category + "  " + project2.Glossary[i].Text + "  " + project2.Glossary[i].TimeCreation);
            //}
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

            ProjectManager.WritingToFile(allNotes, _path);

            CategoryTextBox.Clear();
            TitleTextBox.Clear();
            NoteTextBox.Clear();

            

            sortNotes = allNotes.SortWithSelectionCategory(CategorysComboBox.SelectedIndex);

            //заполняем данными правую часть окна
            TitleTextBox.Text = sortNotes[TitlesListBox.SelectedIndex].Name;
            CategoryTextBox.Text = "Category: " + sortNotes[TitlesListBox.SelectedIndex].Category;
            CreateDateTimePicker.Value = sortNotes[TitlesListBox.SelectedIndex].TimeCreation;
            ChangeDateTimePicker.Value = sortNotes[TitlesListBox.SelectedIndex].TimeCreation;
            NoteTextBox.Text = sortNotes[TitlesListBox.SelectedIndex].Text;


        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ChangeNote();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNote();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateNote();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ChangeNote();
        }

        private void DeletButton_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }
        private void FillListbox()
        {
            //проверка на null(если заметок еще нет)
            if (allNotes != null)
            {
                TitlesListBox.Items.Clear();

                sortNotes = allNotes.SortWithSelectionCategory(CategorysComboBox.SelectedIndex);

                {
                    for (int i = 0; i < sortNotes.Count; i++)
                    {
                        TitlesListBox.Items.Add(sortNotes[i].Name);

                    }
                }
            }
        }
        private void CreateNote()
        {
            //получаем выбранную заметку
            Note newNote = new Note(string.Empty, Category.Work, string.Empty, DateTime.Now); //сама заметка

            newNote.TimeLastChange = DateTime.Now;

            NoteForm inner = new NoteForm(); //создаем форму
            inner.Note = newNote; //передаем форме данные
            inner.Text = ("Add Note");
            //если было нажато Cancel завершаем выполнение обработчика
            if (inner.ShowDialog() == DialogResult.OK)
            {
                var updatedNote = inner.Note; //забираем измененные данные

                //добавляем новую заметку в список
                allNotes.Glossary.Add(updatedNote);

                var changeTitle = updatedNote.Name;

                FillListbox();

                TitlesListBox.SelectedItem = changeTitle;

                ProjectManager.WritingToFile(allNotes, _path);
            }
        }

        //изменение заметки
        private void ChangeNote()
        {
            //если заметка не выбрана завершаем выполнение обработчика(ничего не происходит при нажатии на "Изменить")
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            //получаем выбранную заметку
            var selectedIndex = TitlesListBox.SelectedIndex; //индекс нашей заметки в списке всех заметок allNotes

            var selectedNote = sortNotes[selectedIndex]; //сама заметка

            NoteForm inner = new NoteForm(); //создаем форму
            inner.Note = selectedNote; //передаем форме данные
            inner.Text = ("Edit Note");
            //если было нажато Cancel завершаем выполнение обработчика
            if (inner.ShowDialog() == DialogResult.OK)
            {
                var updatedNote = inner.Note; //забираем измененные данные

                //удалить и заменить старые данные
                allNotes.Glossary.RemoveAt(allNotes.RealIndexes[selectedIndex]);

                allNotes.Glossary.Add(updatedNote);

                FillListbox();

                var changeTitle = updatedNote.Name;

                TitlesListBox.SelectedItem = changeTitle;

                ProjectManager.WritingToFile(allNotes, _path);
            }
        }

        //удаление заметки
        private void DeleteNote()
        {
            //если заметка не выбрана завершаем выполнение обработчика(ничего не происходит при нажатии на "Удалить")
            if (TitlesListBox.SelectedIndex == -1)
            {
                return;
            }

            if (MessageBox.Show("Вы уверены что хотите удалить заметку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //получаем выбранную заметку
                var selectedIndex = TitlesListBox.SelectedIndex; //индекс нашей заметки в списке всех заметок allNotes

                TitlesListBox.Items.RemoveAt(selectedIndex);

                allNotes.Glossary.RemoveAt(allNotes.RealIndexes[selectedIndex]);

                allNotes._currentNote = -1;

                FillListbox();

                CategoryTextBox.Clear();
                TitleTextBox.Clear();
                NoteTextBox.Clear();



                ProjectManager.WritingToFile(allNotes, _path);
            }
        }

        private void CategorysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListbox();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
