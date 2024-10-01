using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_C_3.models
{
    public class Iphone : Smarthphone
    {
        public Iphone(int numero, string modelo, string imei, int memoria) : base(numero, modelo,imei,memoria)
        {
        }
        
        public override void InstalarAplicativo(string appNome)
        {
            Console.WriteLine($"Abra a AppleStore e procure pelo aplicativo {appNome} depois instale ele em seu dispositivo");
        }
    }
}