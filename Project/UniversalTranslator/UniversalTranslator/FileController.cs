using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalTranslator
{
    public class FileController
    {
        public void LoadFileAndConvert(string path)
        {
            var result = LoadFile(path);
            if (result.Count() > 0)
                WriteResult(result, path);
        }


        public IEnumerable<Entry> LoadFile(string path)
        {
            string[] lines = LoadFilePath(path);

            // line = "value,origin,destiny"
            foreach (var line in lines)
            {
                string[] splitedLine = line.Split(',');
                if (!ValidateLine(splitedLine))
                {
                    Console.WriteLine("Linea no valida");
                    continue;
                }

                double value = double.Parse(splitedLine[0]);
                string origin = splitedLine[1];
                string destinty = splitedLine[2];

                yield return new Entry()
                {
                    Value = value,
                    Origin = origin,
                    Destiny = destinty,
                };
            }

        }


        private string[] LoadFilePath(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Esta direccion no existe");
                return Array.Empty<string>();
            }

            return File.ReadAllLines(path);
        }
        // line = "value,origin,destiny"
        private bool ValidateLine(string[] splitedLine)
        {
            if (splitedLine.Length != 3)
            {
                Console.WriteLine("El formato valido es value,origin,destiny. Usted no cumple con este formato");
                return false;
            }

            if (!IsNumeric(splitedLine[0]))
            {
                Console.WriteLine("El valor a convertir debe ser numerico.");
                return false;
            }

            if (!(Converter.allowedConvertion.Keys.Contains(splitedLine[1]) && Converter.allowedConvertion.Keys.Contains(splitedLine[2])))
            {
                Console.WriteLine("conversion de " + splitedLine[1] + " a " + splitedLine[2] + " no permitida");
                return false;
            }

            return true;
        }


        private bool IsNumeric(string v)
        {
            if (v == "0")
                return true;

            decimal.TryParse(v, out decimal value);
            return value != 0;
        }


        private void WriteResult(IEnumerable<Entry> result, string path)
        {
            var r = result.Select(e => { return $"{e.Value.ToString()},{e.Origin.ToString()},{e.Destiny.ToString()}, {Converter.GetConvertion(e.Origin.ToString(), e.Destiny.ToString(), e.Value)}"; }).ToArray();


            var originPath = System.IO.Path.GetDirectoryName(path);


            string pathOutput = originPath + $"\\result_{DateTime.Now.Hour}_{DateTime.Now.Minute}__{DateTime.Now.Second}_{DateTime.Now.Millisecond}.txt";
            File.WriteAllLines(pathOutput, r);
        }


      

    }
}
