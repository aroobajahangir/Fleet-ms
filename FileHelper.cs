using System;
using System.IO;

namespace MidProject.Data // Space nahi hona chahiye
{
    public static class FileHelper
    {
        private static string folderPath = "ProjectData";

        public static void SaveToFile(string fileName, string content)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, fileName);
                File.AppendAllText(filePath, content + Environment.NewLine);
                Console.WriteLine($"Data saved to {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving to file: " + ex.Message);
            }
        }
    } // Class khatam
} // Namespace khatam