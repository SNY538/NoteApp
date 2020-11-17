using System;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Сериализация заметок
    /// </summary>
    public class ProjectManager
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\NoteApp.notes";  //Закрытая константа, содержащая путь 

        public static void WritingToFile(Project project)
        {
            JsonSerializer serializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };

            using (StreamWriter sw = new StreamWriter(_path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        public static Project ReadingFromFile ()
        {
            Project project = null;
            JsonSerializer serializer= new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            using (StreamReader sr= new StreamReader(_path))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project) serializer.Deserialize<Project>(reader);
            }

            return project;
        }

  

    }
}
