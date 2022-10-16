using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo: "Modelo1", imei: "11111121222",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");