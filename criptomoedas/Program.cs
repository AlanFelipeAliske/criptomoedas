// See https://aka.ms/new-console-template for more information


using criptomoedas;

Moeda brl = new Moeda();
Cliente cli = new Cliente();
ItemCarteira IteCart = new ItemCarteira();

//Console.WriteLine("Olá mundo!");

Console.WriteLine(brl.Codigo);
Console.WriteLine(brl.Nome);


brl.ImprimeMoeda("Codigo", "Alan");
cli.ImprimeCliente();
IteCart.ImprimeItemCarteira();

//cli.ImprimeCliente("0", "alan", "alan@gmail", "995555555", "sd56v41s68g4135s1r3yhs3r84hs354");


Console.WriteLine(brl.Nome);