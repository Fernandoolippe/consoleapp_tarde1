// See https://aka.ms/new-console-template for more information
using consoleapp_tarde;
using consoleapp_tarde.Heranca;

Produto p1 = new Produto(1, "Mouse xing ling", 10.90M);
Produto p2 = new Produto(2, "Teclado multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(1, "15906304", "Mario Miziara", 91, " Sobral", "Taquaritinga");

Cliente c1 = new Cliente(1, "Fernando", "992778422", e1);
Cliente c2 = new Cliente(2, "Alexandre", "992768455", e1);
Cliente c3 = new Cliente(3, "Arthur", "99268442", e1);
Cliente c4 = new Cliente(4, "Vinicius", "992778411", e1);
Cliente c5 = new Cliente(5, "Lucas", "996878422", e1);

Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().AtualizarEndereco("Julio de Morais", 585, "Portal Itamaraca");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Carro car = new Carro();
car.cor = "Vermelho";
car.quantidadedeAssentos = 5;
car.quantidadedeRodas = 4;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor = "Azul";
bicicleta.quantidadedeAssentos = 1;
bicicleta.quantidadedeRodas = 2;
bicicleta.TemMotor = false;

Aviao aviao = new Aviao();
aviao.cor = "Branco";
aviao.quantidadedeAssentos = 340;
aviao.quantidadedeRodas = 18;
aviao.TemMotor = true;

List<Veiculo> veiculoList = new List<Veiculo>();

veiculoList.Add(car);
veiculoList.Add(aviao);
veiculoList.Add(bicicleta);
foreach (var item in veiculoList)
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("Quantidade de itens da Lista" + veiculoList.Count);

Random rand = new Random();

List<Produto> produtoList = new List<Produto>();
for (int i = 1; i < rand.Next(200,500); i++)
{
    Produto p = new Produto(i, "Produto " + i, i * 2 + 1);
    produtoList.Add(p);
   
}

foreach (var item in produtoList)
{
    Console.WriteLine(item.ExibirDados());
}

List<Cliente> clienteList = new List<Cliente>();
for (int i = 1; i < rand.Next(200, 500); i++)
{
    Endereco e = new Endereco(1, "Rua ", "156483", i*2, " ", " ");
    Cliente c = new Cliente(i, "Nome " + i, "Telefone" + i, e );
    clienteList.Add(c);

}

foreach(var item in clienteList)
{
    Console.WriteLine(item.ExibirDados());
}



