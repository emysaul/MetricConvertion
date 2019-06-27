using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la ruta del archivo a convertir");
            string path = Console.ReadLine();
            ConvertUnity(path);
            Console.WriteLine("Fin de conversion");
            Console.ReadKey();
        }

        /// <summary>
        ///  Formato de archivo permitido.
        ///  Value,origin,destiny,output
        /// </summary>

        private static void ConvertUnity(string path)
        {
            new FileController().LoadFileAndConvert(path);
        }
    }
}
