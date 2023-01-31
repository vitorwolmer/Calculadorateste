// See https://aka.ms/new-console-template for more information

Console.WriteLine("Maconha!!!!:");


double N1;
double N2;
double A;
double S;
double M;
double D;
char escolha;


Console.WriteLine("Qual operação deseja realizar: [a]Adição  [s]Subtração  [m]Multiplicação  [d]Divisão");
escolha= Char.Parse(Console.ReadLine());


        switch (escolha)
        {
            case 'A':
            case 'a':
        
                Console.WriteLine("Você escolheu Adição:");
                Console.WriteLine("Digite o primeiro número:");
                N1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                N2 = Double.Parse(Console.ReadLine());

                A = N1 + N2;
                Console.WriteLine($"O Resultado da adição é: {A}");
                break;


            case 'S':
            case 's':
      
                Console.WriteLine("Você escolheu Subtração:");
                Console.WriteLine("Digite o primeiro número:");
                N1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                N2 = Double.Parse(Console.ReadLine());

                S = N1 - N2;
                Console.WriteLine($"O Resultado da Subtração é: {S}");
                break;


            case 'M':
            case 'm':
       
                Console.WriteLine("Você escolheu Multiplicação:");
                Console.WriteLine("Digite o primeiro número:");
                N1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                N2 = Double.Parse(Console.ReadLine());

                M = N1 * N2;
                Console.WriteLine($"O Resultado da multiplicação é: {M}");

                break;


            case 'D':
            case 'd':
        
                Console.WriteLine("Você escolheu Divisão:");
                Console.WriteLine("Digite o primeiro número:");
                N1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                N2 = Double.Parse(Console.ReadLine());

                D = N1 / N2;
                Console.WriteLine($"O Resultado da divisão é: {D}");

                break;

            default:
        
                Console.WriteLine("Opção inválida. Escolha novamente.Aperte qualquer tecla para voltar.");
                Console.ReadKey();
                break;
        }




