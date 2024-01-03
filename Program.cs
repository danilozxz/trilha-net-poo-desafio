using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("== Nokia ==");
Smartphone nokia = new Nokia(numero: "10203040", modelo: "Nokia C3", imei: "12345678", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Orkut");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("== Iphone ==");
Smartphone iphone = new Iphone(numero: "40302010", modelo: "Iphone 5s", imei: "87654321", memoria: 16);
iphone.Ligar();
iphone.InstalarAplicativo("Dubsmash");
iphone.ReceberLigacao();