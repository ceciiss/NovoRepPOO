// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
q1  int numeroInteiro = 10;
        float numeroFlutuante = 20.5f;
        string texto = "Olá, mundo!";
        bool valorBooleano = true;

        Console.WriteLine("Valor do inteiro: " + numeroInteiro);
        Console.WriteLine("Valor do float: " + numeroFlutuante);
        Console.WriteLine("Valor da string: " + texto);
        Console.WriteLine("Valor do bool: " + valorBooleano);  
q2
        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        
        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

      
        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;
        int multiplicacao = numero1 * numero2;
        float divisao = (float)numero1 / numero2; 

        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Subtração: " + subtracao);
        Console.WriteLine("Multiplicação: " + multiplicacao);

        Console.WriteLine("Divisão: " + divisao); 

q3
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Olá, {nome}, você tem {idade} anos.");

q4
         Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");
q5
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        
q6
       Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
           
            Console.WriteLine("Você está apto a votar.");

            Console.WriteLine("Você está apto a dirigir.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");

            if (idade >= 16)
            {
                Console.WriteLine("Você está apto a votar, mas não pode dirigir.");
            }
            else
            {
                Console.WriteLine("Você não está apto a votar nem a dirigir.");
            }
        }
q7
        Console.Write("Digite a primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        float nota3 = float.Parse(Console.ReadLine());

        float media = CalcularMedia(nota1, nota2, nota3);

        Console.WriteLine($"A média das notas é: {media}");

        Console.ReadLine();
   
    static float CalcularMedia(float n1, float n2, float n3)
    {
        return (n1 + n2 + n3) / 3;
    } 
q8
    Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int numero3 = int.Parse(Console.ReadLine());

        int maior = numero1;
        if (numero2 > maior)
        {
            maior = numero2;
        }
        if (numero3 > maior)
        {
            maior = numero3;
        }

        int menor = numero1;
        if (numero2 < menor)
        {
            menor = numero2;
        }
        if (numero3 < menor)
        {
            menor = numero3;
        }

        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
q9
        int soma = 0;
        int numero;

        Console.WriteLine("Digite números para somar. Digite 0 para terminar.");

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            soma += numero;

        } while (numero != 0);
 
 q10
        Console.WriteLine($"A soma dos números digitados é: {soma}");
     
     
         Console.Write("Digite o valor em reais: ");
        decimal valorReais = decimal.Parse(Console.ReadLine());

        Console.Write("Digite a taxa de câmbio (1 dólar em reais): ");
        decimal taxaCambio = decimal.Parse(Console.ReadLine());

        decimal valorDolares = valorReais / taxaCambio;

        Console.WriteLine($"O valor de R${valorReais} convertido para dólares é: ${valorDolares:F2}");
         
q11
          Console.Write("Digite um número inteiro para calcular o fatorial: ");
        int numero = int.Parse(Console.ReadLine());

        long fatorial = CalcularFatorial(numero);


        if (fatorial >= 0)
        {
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
        else
        {
            Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
        }

        Console.ReadLine();

    static long CalcularFatorial(int n)
    {

        if (n < 0)
        {
            return -1;
        }

        else if (n == 0 || n == 1)
        {
            return 1;
        }


        else
        {
            return n * CalcularFatorial(n - 1);
        }
    }
   
q12
        Console.Write("Digite um número inteiro positivo para gerar a sequência de Fibonacci: ");
        int limite = int.Parse(Console.ReadLine());

        if (limite <= 0)
        {
            Console.WriteLine("O número deve ser positivo e maior que zero.");
            return;
        }

        int a = 0;
        int b = 1;

        Console.WriteLine("Sequência de Fibonacci:");

        while (a <= limite)
        {
            Console.WriteLine(a);
            int proximo = a + b;
            a = b;
            b = proximo;
        }

q13
        Console.Write("Digite o número de nomes: ");
        int quantidade = int.Parse(Console.ReadLine());


        string[] nomes = new string[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o nome {i + 1}: ");
            nomes[i] = Console.ReadLine();
        }

        OrdenarNomesBubbleSort(nomes);

        Console.WriteLine("Lista de nomes ordenada:");
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }

        Console.ReadLine();
    

    static void OrdenarNomesBubbleSort(string[] nomes)
    {
        int n = nomes.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(nomes[j], nomes[j + 1]) > 0)
                {

                    string temp = nomes[j];
                    nomes[j] = nomes[j + 1];
                    nomes[j + 1] = temp;
                }
            }
        }
    }*/ 


