﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalTranslator
{


    public class Converter
    {

        public static Dictionary<string, double> allowedConvertion = new Dictionary<string, double>() {
            { "km", 3}, // Kilometro
            { "hm", 2 }, // Hectometro
            { "dam", 1 }, // Decametro
            {"m", 0 }, // Metro
            {"dm", -1 }, // Decimetro
            {"cm", -2 }, // Centimetro
            {"mm", -3 }  // milimetro
        };

        public static double GetConvertion(string origin, string destiny, double value)
        {
            double distance = Math.Abs(allowedConvertion[origin] - allowedConvertion[destiny]);
            if (distance == 0)
                return value;

            if (allowedConvertion[origin] >= allowedConvertion[destiny])
                return value * Math.Pow(10, distance);
            else
                return value / Math.Pow(10, distance);
        }
    }
}
