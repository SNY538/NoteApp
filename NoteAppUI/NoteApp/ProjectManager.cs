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
        //private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NoteApp.notes";  //Закрытая константа, содержащая путь 

        public static void WritingToFile(Project project, string path)
        {
            JsonSerializer serializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        public static Project ReadingFromFile (string path)
        {
            Project project = null;
            JsonSerializer serializer= new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            using (StreamReader sr= new StreamReader(path))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project) serializer.Deserialize<Project>(reader);
            }

            return project;
        }

  

    }
}
