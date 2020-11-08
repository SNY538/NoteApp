using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Сериализация заметок
    /// </summary>
    public class ProjectManager
    {
        public static void WritingToFile(Project project, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };

            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        public static Project ReadingFromFile (string fileName)
        {
            Project project = null;
            JsonSerializer serializer= new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            using (StreamReader sr= new StreamReader(@"C:\json.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project) serializer.Deserialize<Project>(reader);
            }

            return project;
        }

    }
}
