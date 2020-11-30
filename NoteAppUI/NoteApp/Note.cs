using System;


namespace NoteApp
{

    /// <summary>
    /// Класс заметки, хранящий информацию о заголовке, категории, тексте, времени создания и изменении
    /// </summary>
    public class Note : ICloneable
    {
    
        private string _name;
        private Category _category;
        private string _text;
        private DateTime _timecreation;
        private DateTime _timelastchange;

        /// <summary>
        /// Задаёт и возвращает название заметки
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (_name.Length > 50)
                {
                    throw  new ArgumentException("Дина названия заметки не должна превышать 50 символов");
                }

                if (_name.Length == 0)
                {
                    _name = "Без названия";
                }
            }
        }
        /// <summary>
        /// Задаёт и возвращает категорию заметки
        /// </summary>
        public Category Category
        {
            get { return _category; }

            set
            {
                _category = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает текст заметки
        /// </summary>
        public string Text
        {
            get { return _text;}

            set
            {
                _text = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает время создания заметки
        /// </summary>
        public DateTime TimeCreation {

            get
            {
                return _timecreation;
            }
            private set
            {
                _timecreation = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает время изменения заметки
        /// </summary>
        public DateTime TimeLastChange
        {
            get { return _timelastchange; }

            set
            {
                _timelastchange = value;
            }
        }

        /// <summary>
        /// Конструктор заметки
        /// </summary>
        public Note(string name, Category category, string text, DateTime timecreation)
        {
            Name = name;
            Category = category;
            Text = text;
            TimeCreation = timecreation;
        }

        /// <summary>
        /// Реализация интерфейса ICloneable
        /// </summary>
        public object Clone()
        {
            return new Note(this.Name, this.Category, this.Text, this.TimeCreation)
            {
                TimeLastChange = this.TimeLastChange
            };

        }
    }
}
