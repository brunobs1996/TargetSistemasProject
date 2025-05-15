namespace TargetSistemasProject;

public class Exercicio4
{

    public void CalcularFaturamentoPorEstado()
    {
        var faturamentoPorEstado = new Dictionary<string, decimal>
        {
            {"SP", 67836.43M},
            {"RJ", 36678.66M},
            {"MG", 29229.88M},
            {"ES", 27165.48M},
            {"Outros", 19849.53M}
        };

        // Calcula o total mensal
        decimal totalMensal = 0;
        foreach (var valor in faturamentoPorEstado.Values)
        {
            totalMensal += valor;
        }

        // Calcula e exibe os percentuais
        Console.WriteLine("Percentual por estado:");
        foreach (var estado in faturamentoPorEstado)
        {
            decimal percentual = (estado.Value / totalMensal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:N2}%");
        }
    }

}