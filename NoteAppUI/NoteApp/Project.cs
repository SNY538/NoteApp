using System.Collections.Generic;
namespace NoteApp
{

    /// <summary>
    /// Класс заметок, содержащий список всех заметок.
    /// </summary>
    public class Project
    {

        public List<Note> Glossary = new List<Note>();
        public List<int> RealIndexes = new List<int>();

        // <summary>
        /// Индекс текущей заметки
        /// </summary>
        public int _currentNote = -1;
        public List<Note> SortWithSelectionCategory(int category)
        {
            var sortNotes = new List<Note>();

            //если выбрана категория All
            if (category == 0)
            {
                RealIndexes.Clear();

                for (int i = 0; i < Glossary.Count; i++)
                {
                    sortNotes.Add(Glossary[i]);
                    RealIndexes.Add(i);
                }
            }
            //если другая категория
            else
            {
                RealIndexes.Clear();

                for (int i = 0; i < Glossary.Count; i++)
                {
                    if ((int)Glossary[i].Category == category - 1)
                    {
                        sortNotes.Add(Glossary[i]);
                        RealIndexes.Add(i);
                    }
                }
            }
            return sortNotes;
        }
    }
}

