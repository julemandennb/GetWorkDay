using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace GetWorkDay
{
    internal class ImEx
    {
        public void Export(List<string> NameNotWorks, List<string> WorkHomes, List<bool> weekDay)
        {
            ImportExport obj = new ImportExport { NameNotWorks = NameNotWorks, WorkHomes = WorkHomes, WeekDay = weekDay } ;

            string jsonStr = JsonSerializer.Serialize(obj);

           string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\" + "Import.txt";

            File.WriteAllText(path, jsonStr);

        }

        public ImportExport Import(string path)
        {
            try
            {
                if (path != null)
                {
                    string jsonStr = File.ReadAllText(path);

                    if (jsonStr != "")
                    {

                        ImportExport obj = JsonSerializer.Deserialize<ImportExport>(jsonStr);

                        return obj;
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }

        }

    }


    internal class ImportExport
    {

        public List<string> NameNotWorks { get; set; }

        public List<string> WorkHomes { get; set; }

        public List<bool> WeekDay { get; set; }


    }
}
