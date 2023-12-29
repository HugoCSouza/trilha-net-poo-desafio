using DesafioPOO.Models;

Console.WriteLine("Nokia \n \n");
Smartphone nokia = new Nokia(numero: "99935812", modelo: "Nokia 8.3 5G", imei: "13245", memoria: 128);
nokia.Ligar("91234567");
nokia.ReceberLigacao("97654321");
nokia.InstalarAplicativo("COD Black Ops");

Console.WriteLine("Iphone \n \n");
Smartphone iphone = new Iphone(numero: "99935812", modelo: "Nokia 8.3 5G", imei: "13245", memoria: 512);
iphone.Ligar("91234567");
iphone.ReceberLigacao("97654321");
iphone.InstalarAplicativo("COD Black Ops");