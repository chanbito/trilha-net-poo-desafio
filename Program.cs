using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "12", modelo:"mod", iMEI:"111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WPP");


Smartphone iphone = new Iphone(numero: "12", modelo: "mod", iMEI: "111111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("telegrão");