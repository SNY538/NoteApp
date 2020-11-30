using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void InitNote()
        {
            _note = new Note("Тестовая заметка", Category.Work, "Текст", DateTime.Today) { TimeLastChange = DateTime.Today };
        }

        [TestCase("Тестовая заметка", "Геттер Name возвращает неправильный заголовок",
            TestName = "Позитивный тест геттера Name")]
        [TestCase("Тестовая заметка", "Сеттер Name записывает неправильный заголовок",
            TestName = "Позитивный тест сеттера Name")]
        public void TestNameGetSet_CorrectValue(string expected, string message)
        {
            _note.Name = expected;
            var actual = _note.Name;
            Assert.AreEqual(expected, actual, message);
        }

        [Test(Description = "Негативный тест set, если поле Name больше 50 символов")]
        
        public void TestNameSet_Longer50Symbols()
        {
          
            var wrongTitle = "ОшибкаОшибкаОшибкаОшибкаОшибкаОшибкаОшибкаОшибкаОшибкаОшибкаОшибкаОшибка";

            Assert.Throws<ArgumentException>(
                () => { _note.Name = wrongTitle; },
                "Должно возникнуть исключение, если длина Name больше 50 символов");
        }

        [Test(Description = "Тест значения поля Name по умолчанию")]
        public void TestNameSet_CorrectValue()
        {
            var expected = "Без названия";
            _note.Name = String.Empty;
            var actual = _note.Name;

            Assert.AreEqual(expected, actual, "Если поле пустое, сеттер Name не ставит заголовок Без названия");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestCase(Category.Work, "Геттер Category возвращает неправильный заголовок",
            TestName = "Позитивный тест геттера Category")]
        [TestCase(Category.Work, "Сеттер Category записывает неправильный заголовок",
            TestName = "Позитивный тест сеттера Category")]
        public void TestCategoryGet_CorrectValue(Category expected, string message)
        {
            _note.Category = expected;
            var actual = _note.Category;
            Assert.AreEqual(expected, actual, message);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestCase("Текст", "Геттер Text возвращает неправильный заголовок",
            TestName = "Позитивный тест геттера Text")]
        [TestCase("Текст", "Сеттер Text записывает неправильный заголовок",
            TestName = "Позитивный тест сеттера Text")]
        public void TestTextGet_CorrectValue(string expected, string message)
        {
            _note.Text = expected;
            var actual = _note.Text;
            Assert.AreEqual(expected, actual, message);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [Test(Description = "Позитивный тест геттера TimeCreation")]
        public void TestTimeCreationGet_CorrectValue()
        {
            var expected = DateTime.Today;
            var actual = _note.TimeCreation;

            Assert.AreEqual(expected, actual, "Геттер TimeCreation возвращает неправильную дату");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestCase("Геттер TimeLastChange возвращает неправильную дату",
            TestName = "Позитивный тест геттера TimeLastChange")]
        [TestCase("Сеттер TimeLastChange записывает неправильную дату",
            TestName = "Позитивный тест сеттера TimeLastChange")]
        public void TestDateChangeGetSet_CorrectValue(string message)
        {
            var expected = DateTime.Now;
            _note.TimeLastChange = expected;
            var actual = _note.TimeLastChange;

            Assert.AreEqual(expected, actual, message);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [Test(Description = "Тест коструктора класса Note")]
        public void TestNoteConstructor_CorrectValue()
        {
            var expectedNote = new Note("Тестовая заметка", Category.Work, "Текст", DateTime.Today) { TimeLastChange = DateTime.Today };
            var actual = _note;

            Assert.AreEqual(expectedNote.Name, actual.Name, "Неправиьное значение в поле Title");
            Assert.AreEqual(expectedNote.Category, actual.Category, "Неправиьное значение в поле Category");
            Assert.AreEqual(expectedNote.Text, actual.Text, "Неправиьное значение в поле Text");
            Assert.AreEqual(expectedNote.TimeCreation, actual.TimeCreation, "Неправиьное значение в поле DateCreate");
            Assert.AreEqual(expectedNote.TimeLastChange, actual.TimeLastChange, "Неправиьное значение в поле DateChange");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [Test(Description = "Тест Clone в классе Note")]
        public void TestClone_CorrectValue()
        {
            var expectedNote = new Note("Тестовая заметка", Category.Work, "Текст", DateTime.Today) { TimeLastChange = DateTime.Today };
            var actual = (Note)_note.Clone();

            Assert.AreEqual(expectedNote.Name, actual.Name, "Неправиьное значение в поле Title");
            Assert.AreEqual(expectedNote.Category, actual.Category, "Неправиьное значение в поле Category");
            Assert.AreEqual(expectedNote.Text, actual.Text, "Неправиьное значение в поле Text");
            Assert.AreEqual(expectedNote.TimeCreation, actual.TimeCreation, "Неправиьное значение в поле DateCreate");
            Assert.AreEqual(expectedNote.TimeLastChange, actual.TimeLastChange, "Неправиьное значение в поле DateChange");
        }









    }
}
