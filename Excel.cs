using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using Excel = Microsoft.Office.Interop.Excel;

namespace testratingscore
{
    class ExcelAppload : IDisposable
    {
        private Application _excel; 
        private Workbook _workbook;
        private string _filePath;

        public ExcelAppload()
        {
            _excel = new Excel.Application();
        }

        public void Dispose()
        {
            try
            {
                _workbook.Close();
            }
            catch { 
            
            }
        }

        internal bool Open(string FilePath)
        {
            try
            {
                if(File.Exists(FilePath))
                {
                    _workbook = _excel.Workbooks.Open(FilePath);
                }
                else {
                    _workbook = _excel.Workbooks.Add();
                    _filePath = FilePath;
                }
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return false;
        }

        internal void Save()
        {
            if(!string.IsNullOrEmpty(_filePath))
            {
                MessageBox.Show("Filе is save!");
                _excel.Save();
            }
            else{
                _excel.Save();
            }
        }

        internal bool Set(string colum, int row, string data)
        {
            try
            {
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, colum] = data; 
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return false;
        }
    }
}
