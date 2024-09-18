using System;

class Teste04
{
    static void Main(string[] args)
    {
        
        decimal sp = 67836.43m;
        decimal rj = 36678.66m;
        decimal mg = 29229.88m;
        decimal es = 27165.48m;
        decimal outro = 19849.53m;

        
        decimal faturamentoTotal = sp + rj + mg + es + outro;

        
        CalcularPercentual("SP", sp, faturamentoTotal);
        CalcularPercentual("RJ", rj, faturamentoTotal);
        CalcularPercentual("MG", mg, faturamentoTotal);
        CalcularPercentual("ES", es, faturamentoTotal);
        CalcularPercentual("Outros", outro, faturamentoTotal);

        Console.WriteLine($"Faturamento total: {faturamentoTotal:C}");
    }

    static void CalcularPercentual(string estado, decimal valorEstado, decimal faturamentoTotal)
    {
        decimal percentual = (valorEstado / faturamentoTotal) * 100;
        Console.WriteLine($"Percentual de {estado}: {percentual:F2}%");
    }
}
