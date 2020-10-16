using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public class FileReader :IFileReader
    {
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
