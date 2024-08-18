using DesafioPOO.Models;

// Instânciando e implementando os testes com as classes
Console.WriteLine("Exibindo Status do Iphone");
Iphone iphone = new Iphone(numero:"98210-2019", modelo:"14", imei:"356080099898233", memoria:128);

iphone.Ligar();
iphone.InstalarAplicativo("Spotify");

Console.WriteLine("--------------------\n");


Console.WriteLine("Exibindo Status do Nokia");
Nokia nokia = new Nokia(numero:"98877-6655", modelo:"C20", imei:"3340802099828233", memoria:32);

nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
