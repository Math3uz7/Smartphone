
using projeto_C_3.models;

Console.WriteLine("Celular Nokia :");
Nokia cell_Nokia = new Nokia(numero:99764532,modelo:"N17",imei:"A8G46TG",memoria:256);
cell_Nokia.Ligar();
cell_Nokia.ReceberLigacao();
cell_Nokia.InstalarAplicativo("Bloco de notas");


Console.WriteLine("Celular Iphone");
Iphone cell_Iphone = new Iphone(numero:9825674,modelo:"Iphone 15",imei:"G45J8F",memoria:128);
cell_Iphone.Ligar();
cell_Iphone.ReceberLigacao();
cell_Iphone.InstalarAplicativo("Cronometro");