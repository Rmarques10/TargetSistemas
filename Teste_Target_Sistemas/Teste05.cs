
Console.WriteLine("Digite uma string para ser invertida:");
        string input = Console.ReadLine();
       

        string resultadoInvertido = InverterString(input);

        
        Console.WriteLine("String invertida: " + resultadoInvertido);
    

    static string InverterString(string input)
    {
        
        char[] chars = new char[input.Length];

        
        int j = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            chars[j] = input[i];
            j++;
        }

        
        return new string(chars);
    }

