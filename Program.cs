using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo: "Nokia", imei: "11111121222",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"123456", modelo: "Iphone", imei: "111111211111",memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");