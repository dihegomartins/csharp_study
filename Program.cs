using Projetos_C_.Models;


int quantidadeEmEstoque = 10;
int quantidadeEmCompra = 1;
bool possivelVenda = quantidadeEmCompra > 0 && quantidadeEmEstoque >= quantidadeEmCompra;


Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade em compra: {quantidadeEmCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if(quantidadeEmCompra == 0)
{
    Console.WriteLine("Venda Invalida");
}
else if(possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade em estoque");
}


//string a = "15-";

//int.TryParse(a, out int b);

//Console.WriteLine(b);
//int a = Convert.ToInt32("5");
//int a = int.Parse("5c");

// int a = 20;
// int b = 30;
// int c = a + b;

// c *= 5;

// Console.WriteLine(c);


// DateTime dateNow = DateTime.Now;

// Console.WriteLine(dateNow.ToString("dd/MM/yyyy"));


// string apresentacao = "Hello, welcome";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.85M;
// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade:" + quantidade);
// Console.WriteLine("Valor da variável altura:" + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço:" + preco);
// Console.WriteLine("Valor da variável condição:" + condicao);


//Pessoa person1 = new Pessoa();

//person1.Name = "Dihêgo";
//person1.Age = 24;
//person1.Apresentar();