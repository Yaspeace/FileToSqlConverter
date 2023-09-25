using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToSqlConverter.Models.Files
{
    public class NativeExcelFileAdapter : IFileAdapter, IDisposable
    {
        public bool End => end;

        private Stream stream;

        private IExcelDataReader reader;

        private bool end;

        public NativeExcelFileAdapter(string filename)
        {
            stream = File.Open(filename, FileMode.Open);
            reader = ExcelReaderFactory.CreateReader(stream);
        }

        public NativeExcelFileAdapter(string filename, string listname)
        {
            stream = File.Open(filename, FileMode.Open);
            reader = ExcelReaderFactory.CreateReader(stream);
            while (reader.Name != listname)
            {
                if (!reader.NextResult())
                {
                    throw new Exception($"Лист {listname} не обнаружен");
                }
            }
        }
        
        public void Close()
        {
            reader.Close();
            stream.Close();
        }

        public string[]? Read()
        {
            end = reader.Read();
            return end
                ? null
                : Enumerable.Range(0, reader.FieldCount).Select(i => reader.GetString(i)).ToArray();
        }

        public void Reset() => reader.Reset();

        public void Dispose()
        {
            reader.Dispose();
            stream.Dispose();
        }
    }
}
