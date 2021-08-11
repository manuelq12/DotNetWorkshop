using System;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PRFTLatam.DotNetWorkshop.Services.Util
{
    public class FileReader{

        private static readonly string CSVPath = @"/Users/mquinteroc/Documents/PSL/Workshops/FullStack_Workshop/DotNetWorkshop/resources/CSV_Hex.csv";
        private StreamReader reader;

        private List<String> whitelistIds;

        public FileReader(){
            reader = new StreamReader(CSVPath);
        }

        public void ReadCSV(){
            whitelistIds = new List<string>();
            while(!reader.EndOfStream){
                String line = reader.ReadLine();
                String[] values = line.Split(',');
                whitelistIds.Add(values[0]);
            }
        }

        public List<String> GetWhitelistIds(){
            return whitelistIds;
        }
    }
}