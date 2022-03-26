// See https://aka.ms/new-console-template for more information


using criptomoedas;

Carteira ccarteira = new Carteira("Endereco carteira");
Cliente ccliente = new Cliente();
Corretora ccorretora = new Corretora(4546, "corretoraX");
ItemCarteira iitemcarteira = new ItemCarteira(10);
Moeda mmoeda = new Moeda();
ParMoeda pparmoeda = new ParMoeda(20);

mmoeda.ImprimeMoeda("Codigo", "Alan");
ccliente.ImprimeCliente();
iitemcarteira.ImprimeItemCarteira();
ccarteira.ImprimeCarteira();
ccorretora.ImprimeCorretora();
pparmoeda.ImprimeParMoeda();


//Console.WriteLine(mmoeda.Nome);