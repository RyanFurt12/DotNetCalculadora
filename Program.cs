float n1, n2, op, result = 0;

Console.Clear();
Console.WriteLine("Bem vindo a Calculadora\n");

do{
    Console.Write("Digite o primeiro número: ");
    string input = Console.ReadLine() ?? " ";

    try{
        n1 = float.Parse(input);
        break; 
    }
    catch (FormatException){
        Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
    }
} while (true);

do{
    Console.Write("Digite o segundo número: ");
    string input = Console.ReadLine() ?? " ";

    try{
        n2 = float.Parse(input);
        break;
    }
    catch (FormatException){
        Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
    }
} while (true);

do{
    Console.WriteLine("\n-------------");
    Console.WriteLine("1 - Adição: ");
    Console.WriteLine("2 - Subtração: ");
    Console.WriteLine("3 - Divisão: ");
    Console.WriteLine("4 - Multiplicação: ");
    Console.Write("-- Qual operação deseja: ");

    string input = Console.ReadLine() ?? " ";

    try{
        op = int.Parse(input);
        Console.WriteLine();
        switch (op)
        {
            case 1:
                result = n1+n2;
                Console.Write("O resultado da Adição");
                break;
            case 2:
                result = n1-n2;
                Console.Write("O resultado da Subtração");
                break;
            case 3:
                result = n1/n2;
                Console.Write("O resultado da Divisão");
                break;
            case 4:
                result = n1*n2;
                Console.Write("O resultado da Multiplicação");
                break;
            default:
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                break;
        }

        if(op>=1 & op<=4){
            Console.Write($" é {result}");
            break;
        } 
    }
    catch (FormatException){
        Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
    }

} while (true);

Console.ReadLine();