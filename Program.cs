using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"145456", modelo: "Modelo2",imei:"hu3hu3hu3",128);
nokia.Ligar();
nokia.InstalarAplicativo("Whats");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"789123", modelo: "Modelo1",imei:"serie 0",246);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");