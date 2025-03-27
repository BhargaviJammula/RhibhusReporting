using Newtonsoft.Json.Linq;

namespace Rhibhus.Reports.API.Services
{
    public class LanguageService
    {
        public JObject ReadJsonFromFile(string countryName)
        {
            try
            {
                string fileName = GetLangFileName(countryName);
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

        private static string GetLangFileName(string _countryName)
        {
            string fileName = "english.json";

            var countryName = _countryName?.ToString() ?? "USA";

            switch (countryName.ToLower()) // Use ToLower() for case-insensitive comparison
            {
                case "malaysia":
                    fileName = "malaysia.json";
                    break;
                case "taiwan":
                    fileName = "taiwan.json";
                    break;
                case "indonesia":
                    fileName = "indonesia.json";
                    break;
                case "usa":
                    fileName = "english.json";
                    break;
            }

            return fileName;
        }
    }
}
