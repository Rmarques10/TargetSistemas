using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Teste03
{
    public class FaturamentoDiario
    {
        public int Dia { get; set; }
        public decimal Faturamento { get; set; }
    }

    static void Main(string[] args)
    {
        
        string json = File.ReadAllText("faturamento.json");
        List<FaturamentoDiario> faturamentos = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(json);

        
        var diasComFaturamento = faturamentos.Where(f => f.Faturamento > 0).ToList();

        
        if (diasComFaturamento.Count == 0)
        {
            Console.WriteLine("Nenhum dado de faturamento disponível.");
            return;
        }

        
        decimal menorFaturamento = diasComFaturamento.Min(f => f.Faturamento);
        decimal maiorFaturamento = diasComFaturamento.Max(f => f.Faturamento);

        
        decimal mediaMensal = diasComFaturamento.Average(f => f.Faturamento);

        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Faturamento > mediaMensal);

        
        Console.WriteLine($"Menor faturamento do mês: {menorFaturamento:C}");
        Console.WriteLine($"Maior faturamento do mês: {maiorFaturamento:C}");
        Console.WriteLine($"Número de dias com faturamento superior à média mensal: {diasAcimaDaMedia}");
    }
}
