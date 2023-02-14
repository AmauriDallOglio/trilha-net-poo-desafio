using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "7773311122", modelo:"SuperNokia", imei:"987654321", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Iphone iphone = new Iphone(numero: "888339933", modelo: "SuperIphone", imei: "123456789", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");