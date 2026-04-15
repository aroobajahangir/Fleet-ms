using System;
using System.Collections.Generic;
using System.IO;

namespace Mid_project.Data
{
    public class FileHelper
    {
        public static void WriteToFile(string path, string data)
        {
            File.AppendAllText(path, data + Environment.NewLine);
        }

        public static List<string> ReadFromFile(string path)
        {
            if (!File.Exists(path))
                return new List<string>();

            return new List<string>(File.ReadAllLines(path));
        }
    }
}