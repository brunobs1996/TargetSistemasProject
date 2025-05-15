using System.Text.Json;
using TargetSistemasProject;
using TargetSistemasProject.Models;

// See https://aka.ms/new-console-template for more information

//----------------------------------------- README   --- Target Sistemas -> Normativas técnicas : 
// Candidato: Bruno Berto da Silva
//Tempo de experiência como programador: 4 anos e 3 meses(CLT)
//Tecnologias com que já trabalhei: C#, Vb.Net, Java, Node.js, SQL Server, MySql e SQL Server integration Services
//Para executar a resolução de um exercício, basta instanciar a classe correspondente e chamar o principal método da classe


//------------- Exercício 1 --------------------------------
int resultado = new Exercicio1().ReturnSum();
Console.WriteLine(resultado);
Console.ReadKey();
//RESPOSTA: 91
//-----------------------------------------------------------


//------------- Exercício 2 --------------------------------
var exercicio2 = new Exercicio2();
Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
int numero = int.Parse(Console.ReadLine());

if (exercicio2.VerifyFibonacciNumber(numero))
{
    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci!");
}
else
{
    Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
}
//-----------------------------------------------------------

//------------- Exercício 3 --------------------------------
// Nesta etapa, optei por utilizar o arquivo JSON, tendo em vista que é o formato mais utilizado hoje em dia pela maioria das aplicações, e se porventura
// fosse feito com o XML, a lógica permaneceria a mesma

string json = File.ReadAllText("faturamento.json");
var dados = JsonSerializer.Deserialize<FaturamentoMensal>(json);

// Filtragem de dias com faturamento > 0
List<double> faturamentosValidos = new List<double>();
foreach (var dia in dados.FaturamentoDiario)
{
    if (dia.Valor > 0)
    {
        faturamentosValidos.Add(dia.Valor);
    }
}

// Calcula menor e maior faturamento
double menorFaturamento = faturamentosValidos.Min();
double maiorFaturamento = faturamentosValidos.Max();

// Calcula média mensal (ignorando dias sem faturamento)
double mediaMensal = faturamentosValidos.Average();

// Conta dias com faturamento acima da média
int diasAcimaDaMedia = faturamentosValidos.Count(v => v > mediaMensal);

// Exibe resultados
Console.WriteLine($"Menor faturamento diário: {menorFaturamento:C2}");
Console.WriteLine($"Maior faturamento diário: {maiorFaturamento:C2}");
Console.WriteLine($"Dias com faturamento acima da média ({mediaMensal:C2}): {diasAcimaDaMedia}");

//----------------------------------------------------------


//------------- Exercício 4 --------------------------------
//Método VOID, portanto basta chamá-lo sem necessidade de passar nenhum parâmetro
new Exercicio4().CalcularFaturamentoPorEstado();
//----------------------------------------------------------

//------------- Exercício 5 --------------------------------
Console.Write("Digite uma string para inverter: ");
string original = Console.ReadLine();

string invertida = new Exercicio5().InverterString(original);

Console.WriteLine($"String original: {original}");
Console.WriteLine($"String invertida: {invertida}");
//----------------------------------------------------------