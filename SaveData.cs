using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace testratingscore
{
    internal class SaveData
    {
        static public void Save_data(List<Subject> S) {
            SaveFileDialog sdtable = new SaveFileDialog();
            sdtable.InitialDirectory = @"C:\Users\alexs\Downloads";
            sdtable.RestoreDirectory = true;
            sdtable.FileName = "data";
            sdtable.DefaultExt = "csv"; 
            sdtable.Filter = "csv files (*.csv) | *.csv";

            if (sdtable.ShowDialog() == DialogResult.OK)
            {
                Stream file = sdtable.OpenFile();
                StreamWriter sw = new StreamWriter(file, Encoding.GetEncoding(1251));
                sw.WriteLine("Предмет" + ";" + "Оцінка" + "\n");
                foreach (Subject subject in S) {
                   string str = subject.name + ";" + subject.Score ;
                   sw.WriteLine(str);
                }
                sw.Close();
                file.Close();
            }
        }
    }
}
