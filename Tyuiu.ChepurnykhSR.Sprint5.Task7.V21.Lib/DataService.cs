using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChepurnykhSR.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V21.txt";
            string pathSaveFile2 = $@"C:\Users\user\source\repos\Tyuiu.ChepurnykhSR.Sprint5.Review\Tyuiu.ChepurnykhSR.Sprint5.Task7.V21\bin\Debug\OutPutDataFileTask7V21.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            FileInfo fileInfo2 = new FileInfo(pathSaveFile2);
            bool fileExists2 = fileInfo.Exists;

            if (fileExists2)
            {
                File.Delete(pathSaveFile2);
            }

            string MyStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != ',') && (line[i] != '.') && (line[i] != '-') && (line[i] != '!') && (line[i] != '?') && (line[i] != ':') && (line[i] != ';'))
                        {
                            MyStr += line[i];
                        }
                    }
                }
            }
            File.AppendAllText(pathSaveFile, MyStr + Environment.NewLine);
            File.AppendAllText(pathSaveFile2, MyStr + Environment.NewLine);

            return pathSaveFile2;
        }
    }
}
