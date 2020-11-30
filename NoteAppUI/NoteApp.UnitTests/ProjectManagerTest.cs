using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp.UnitTests
{
    class ProjectManagerTest
    {
        private Project _notesForSave;

        private Project _notesForLoad;

        private List<Note> _actualList;

        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\NoteAppTest.notes";

        [SetUp]
        public void InitNote()
        {
            _notesForSave = new Project();
            _notesForLoad = new Project();
            _actualList = new List<Note>();

            _notesForSave.Glossary.Add(new Note("Заголовок1", Category.Work, "Текст1", DateTime.Today) { TimeLastChange = DateTime.Today });
            _notesForSave.Glossary.Add(new Note("Заголовок3", Category.Work, "Текст3", DateTime.Today) { TimeLastChange = DateTime.Today });
            _notesForSave.Glossary.Add(new Note("Заголовок2", Category.Work, "Текст2", DateTime.Today) { TimeLastChange = DateTime.Today });
            _notesForSave.Glossary.Add(new Note("Заголовок4", Category.Work, "Текст4", DateTime.Today) { TimeLastChange = DateTime.Today });
        }

        [Test(Description = "Тест сериализации")]
        public void TestSerialize_CorrectValue()
        {
            var expected = _notesForSave;
            var path = _path;
            var actualList = _actualList;

            ProjectManager.WritingToFile(expected,_path);

            var actual = _notesForLoad;

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(path))

            using (JsonReader reader = new JsonTextReader(sr))

                actual = (Project)serializer.Deserialize<Project>(reader);


            for (int i = 0; i < actual.Glossary.Count; i++)
            {
                actualList.Add(actual.Glossary[i]);
            }

            for (int i = 0; i < expected.Glossary.Count; i++)
            {
                Assert.AreEqual(expected.Glossary[i].Name, actualList[i].Name);
                Assert.AreEqual(expected.Glossary[i].Category, actualList[i].Category);
                Assert.AreEqual(expected.Glossary[i].Text, actualList[i].Text);
                Assert.AreEqual(expected.Glossary[i].TimeLastChange, actualList[i].TimeLastChange);
                Assert.AreEqual(expected.Glossary[i].TimeCreation, actualList[i].TimeCreation);
            }
        }

        [Test(Description = "Тест десериализации")]
        public void TestDeserialize_CorrectValue()
        {
            var expected = _notesForSave;
            var path = _path;
            var actualList = _actualList;

            var actual = ProjectManager.ReadingFromFile(_path);

            for (int i = 0; i < actual.Glossary.Count; i++)
            {
                actualList.Add(actual.Glossary[i]);
            }

            for (int i = 0; i < expected.Glossary.Count; i++)
            {
                Assert.AreEqual(expected.Glossary[i].Name, actualList[i].Name);
                Assert.AreEqual(expected.Glossary[i].Category, actualList[i].Category);
                Assert.AreEqual(expected.Glossary[i].Text, actualList[i].Text);
                Assert.AreEqual(expected.Glossary[i].TimeLastChange, actualList[i].TimeLastChange);
                Assert.AreEqual(expected.Glossary[i].TimeCreation, actualList[i].TimeCreation);
            }
        }
    }
}
