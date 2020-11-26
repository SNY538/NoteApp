using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    class ProjectTest
    {
        private List<Note> _allNotes;

        [SetUp]
        public void InitAllNotes()
        {
            _allNotes = new List<Note>();

            _allNotes.Add(new Note("Заголовок1", Category.Work, "Текст1", DateTime.Today) { TimeLastChange = DateTime.Today });
            _allNotes.Add(new Note("Заголовок3", Category.Work, "Текст3", DateTime.Today) { TimeLastChange = DateTime.Today });
            _allNotes.Add(new Note("Заголовок2", Category.Work, "Текст2", DateTime.Today) { TimeLastChange = DateTime.Today });
            _allNotes.Add(new Note("Заголовок4", Category.Work, "Текст4", DateTime.Today) { TimeLastChange = DateTime.Today });

        }

        [Test(Description = "Проверка, что все элементы списка заметок заполнены(не нулевые)")]
        public void AllItemsAreNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(_allNotes, "Список заметок содержит незаполненые заметки");
        }

        [Test(Description = "Проверка, что сортировка по категории работает")]
        public void SortRightCategory()
        {
            List<Note> allNotesTest = new List<Note>();

            allNotesTest.Add(new Note("Заголовок1", Category.Work, "Текст1", DateTime.Today) { TimeLastChange = DateTime.Today });
            allNotesTest.Add(new Note("Заголовок3", Category.Documents, "Текст3", DateTime.Today) { TimeLastChange = DateTime.Today });
            allNotesTest.Add(new Note("Заголовок2", Category.HealthSports, "Текст2", DateTime.Today) { TimeLastChange = DateTime.Today });
            allNotesTest.Add(new Note("Заголовок4", Category.Work, "Текст4", DateTime.Today) { TimeLastChange = DateTime.Today });
            Project PNotes = new Project();
            for (int i = 0; i < allNotesTest.Count; i++)
            {
                PNotes.Glossary.Add(allNotesTest[i]);
            }
            List<Note> actualNotes = new List<Note>();
            actualNotes.Add(new Note("Заголовок1", Category.Work, "Текст1", DateTime.Today) { TimeLastChange = DateTime.Today });
            actualNotes.Add(new Note("Заголовок4", Category.Work, "Текст4", DateTime.Today) { TimeLastChange = DateTime.Today });

            var category = 1;
            var expectedNotes = PNotes.SortWithSelectionCategory(category);
            for (int i = 0; i < expectedNotes.Count; i++)
            {
                Assert.AreEqual(expectedNotes[i].Category, actualNotes[i].Category, "Список заметок не совпадает");
            }

        }

        [Test(Description = "Проверка, что сортировка по категории All работает")]
        public void SortAllCategory()
        {
            List<Note> allNotesTest = new List<Note>();

            allNotesTest.Add(new Note("Заголовок1", Category.Work, "Текст1", DateTime.Today) { TimeLastChange = DateTime.Today });
            allNotesTest.Add(new Note("Заголовок3", Category.Documents, "Текст3", DateTime.Today) { TimeLastChange = DateTime.Today });
            allNotesTest.Add(new Note("Заголовок2", Category.HealthSports, "Текст2", DateTime.Today) { TimeLastChange = DateTime.Today });
            allNotesTest.Add(new Note("Заголовок4", Category.Work, "Текст4", DateTime.Today) { TimeLastChange = DateTime.Today });
            Project PNotes = new Project();
            for (int i = 0; i < allNotesTest.Count; i++)
            {
                PNotes.Glossary.Add(allNotesTest[i]);
            }

            var category = 0;
            var expectedNotes = PNotes.SortWithSelectionCategory(category);
            for (int i = 0; i < expectedNotes.Count; i++)
            {
                Assert.AreEqual(expectedNotes[i].Category, allNotesTest[i].Category, "Список заметок не совпадает");
            }

        }
    }
}