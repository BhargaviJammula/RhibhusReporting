using Newtonsoft.Json.Linq;

namespace Rhibhus.Reports.API.Services
{
    public class LanguageService
    {
        public JObject ReadJsonFromFile(string fileName)
        {
            try
            {
                string folderName = "MultilingualData";
                string projectDirectory = Directory.GetCurrentDirectory(); // Gets the current directory of the project
                string folderPath = Path.Combine(projectDirectory, folderName, fileName);

                // Ensure the file exists before attempting to read it
                if (File.Exists(folderPath))
                {
                    string json = File.ReadAllText(folderPath);
                    JObject jsonObject = JObject.Parse(json);
                    return jsonObject;
                }
                else
                {
                    Console.WriteLine("File does not exist: " + folderPath);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading JSON file: " + ex.Message);
                return null;
            }
        }
    }
}
