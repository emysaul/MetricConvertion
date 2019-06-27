using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UniversalTranslator.T
{
    public class UnitTest1
    {

        //{ "km", 3}, // Kilometro
        //{ "hm", 2 }, // Hectometro
        //{ "dam", 1 }, // Decametro
        //{"m", 0 }, // Metro
        //{"dm", -1 }, // Decimetro
        //{"cm", -2 }, // Centimetro
        //{"mm", -3 }  // milimetro

        #region kilometro

        [Fact]
        public void One_KM_to_KM_1()
        {
            string origin = "km";
            string destiny = "km";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(1, result);
        }

        [Fact]
        public void One_KM_to_HM_10()
        {
            string origin = "km";
            string destiny = "hm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(10, result);

        }

        [Fact]
        public void One_KM_to_DAM_RETURN_100()
        {
            string origin = "km";
            string destiny = "dam";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(100, result);
        }

        [Fact]
        public void One_KM_to_M_RETURN_1000()
        {
            string origin = "km";
            string destiny = "m";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(1000, result);

        }

        [Fact]
        public void One_KM_to_CM_RETURN_100000()
        {
            string origin = "km";
            string destiny = "cm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(100000, result);

        }

        [Fact]
        public void One_KM_to_MM_RETURN_1000000()
        {
            string origin = "km";
            string destiny = "mm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(1000000, result);
        }

        #endregion

        #region Hectometro

        [Fact]
        public void One_HM_to_KM_RETURN_0_1()
        {
            string origin = "hm";
            string destiny = "km";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(0.1, result);
        }

        [Fact]
        public void One_HM_to_HM_RETURN_1()
        {
            string origin = "hm";
            string destiny = "hm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(1, result);

        }

        [Fact]
        public void One_HM_to_DAM_RETURN_10()
        {
            string origin = "hm";
            string destiny = "dam";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(10, result);
        }

        [Fact]
        public void One_HM_to_M_RETURN_100()
        {
            string origin = "hm";
            string destiny = "m";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(100, result);

        }

        [Fact]
        public void One_HM_to_CM_RETURN_10000()
        {
            string origin = "hm";
            string destiny = "cm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(10000, result);

        }

        [Fact]
        public void One_HM_to_MM_RETURN_100000()
        {
            string origin = "hm";
            string destiny = "mm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(100000, result);
        }

        #endregion


        #region Decametro

        [Fact]
        public void One_DAM_to_KM_RETURN_0_01()
        {
            string origin = "dam";
            string destiny = "km";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(0.01, result);
        }

        [Fact]
        public void One_DAM_to_HM_RETURN_0_1()
        {
            string origin = "dam";
            string destiny = "hm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(0.1, result);

        }

        [Fact]
        public void One_DAM_to_DAM_RETURN_1()
        {
            string origin = "dam";
            string destiny = "dam";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(1, result);
        }

        [Fact]
        public void One_DAM_to_M_RETURN_10()
        {
            string origin = "dam";
            string destiny = "m";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(10, result);

        }

        [Fact]
        public void One_DAM_to_CM_RETURN_1000()
        {
            string origin = "dam";
            string destiny = "cm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(1000, result);

        }

        [Fact]
        public void One_DAM_to_MM_RETURN_10000()
        {
            string origin = "dam";
            string destiny = "mm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(10000, result);
        }

        #endregion

        #region Metro

        [Fact]
        public void One_M_to_KM_RETURN_0_001()
        {
            string origin = "m";
            string destiny = "km";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(0.001, result);
        }

        [Fact]
        public void One_M_to_HM_RETURN_0_01()
        {
            string origin = "m";
            string destiny = "hm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(0.01, result);

        }

        [Fact]
        public void One_M_to_DAM_RETURN_0_1()
        {
            string origin = "m";
            string destiny = "dam";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(0.1, result);
        }

        [Fact]
        public void One_M_to_M_RETURN_10()
        {
            string origin = "m";
            string destiny = "m";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(1, result);

        }

        [Fact]
        public void One_M_to_CM_RETURN_100()
        {
            string origin = "m";
            string destiny = "cm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(100, result);

        }

        [Fact]
        public void One_M_to_MM_RETURN_1000()
        {
            string origin = "m";
            string destiny = "mm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(1000, result);
        }

        #endregion

        #region CENTIMETRO

        [Fact]
        public void One_CM_to_KM_RETURN_0_00001‬()
        {
            string origin = "cm";
            string destiny = "km";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            double expected = 0.00001;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void One_CM_to_HM_RETURN_0_0001()
        {
            string origin = "cm";
            string destiny = "hm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(0.0001, result);

        }

        [Fact]
        public void One_CM_to_DAM_RETURN_0_001()
        {
            string origin = "cm";
            string destiny = "dam";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(0.001, result);
        }

        [Fact]
        public void One_CM_to_M_RETURN_0_01()
        {
            string origin = "cm";
            string destiny = "m";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(0.01, result);

        }

        [Fact]
        public void One_CM_to_CM_RETURN_1()
        {
            string origin = "cm";
            string destiny = "cm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(1, result);

        }

        [Fact]
        public void One_CM_to_MM_RETURN_10()
        {
            string origin = "cm";
            string destiny = "mm";
            double value = 1;

            double result = Converter.GetConvertion(origin, destiny, value);

            Assert.Equal(10, result);
        }

        #endregion
    }

}
