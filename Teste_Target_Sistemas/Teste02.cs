using System;

class Teste02
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para calcular a sequência de Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        // Chamar função que imprime a sequência de Fibonacci até o valor informado
        Fibonacci(n);
    }

    static void Fibonacci(int n)
    {
        int a = 0, b = 1, proximo;

        Console.WriteLine("Sequência de Fibonacci até " + n + ":");

        if (n == 0)
        {
            Console.WriteLine(a);
            return;
        }

        Console.WriteLine(a); // Primeiro número da sequência
        Console.WriteLine(b); // Segundo número da sequência

        // Calculando e imprimindo a sequência
        for (int i = 2; i < n; i++)
        {
            proximo = a + b; // Próximo número é a soma dos dois anteriores
            Console.WriteLine(proximo);

            a = b; // Atualizando os valores para o próximo cálculo
            b = proximo;
        }
    }
}
