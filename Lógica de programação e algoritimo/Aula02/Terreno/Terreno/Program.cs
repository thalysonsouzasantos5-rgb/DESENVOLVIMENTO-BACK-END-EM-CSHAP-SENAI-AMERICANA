//Declaração de variáveis

double largura;
double comprimento;
double valor;
double area;
double preco;

//Entrada de dados
Console.Write("Digite a largura do terreno: ");
largura = double.Parse(Console.ReadLine());

Console.Write("Digite o comprimento do terreno: ");
comprimento = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do metro quadrado do terreno: ");
valor = double.Parse(Console.ReadLine());

//Processamento de dados
area = largura * comprimento;
preco = area * valor;

//Saída de dados
Console.WriteLine($"A área do terreno é: {area:n}\nPreço do terreno: R$ {preco:n}");