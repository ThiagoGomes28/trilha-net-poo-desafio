using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Nokia:");
Smartphone nokia = new Nokia("94002-8922", "Nokia Tijolão", "123456", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n----------------\n");

Console.WriteLine("Testando Iphone:");
Smartphone iphone = new Iphone("98922-4002", "iphone 17", "987654", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");