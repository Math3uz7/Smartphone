using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_C_3.models
{
    public class Nokia : Smarthphone
    {
        public Nokia(int numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {
        }

        public override void InstalarAplicativo(string appNome)
        {
            Console.WriteLine($"Abra a PlayStore e procure pelo aplicativo {appNome} depois instale ele em seu dispositivo");

        }
    }
}