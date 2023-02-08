
Console.WriteLine("Hello, World!");

string[]  nome = new string[100];
double[] valorHosp = new double[100];
double xxx = 1, diariaP, total = 0;
int[] idade= new int[100];
int qtdG = 0, qtdM = 0 , qtd;

Console.WriteLine(">>>Valor da hospedagem para hóspedes<<<");
Console.WriteLine("Digite o valor da diária padrão:");
diariaP = double.Parse(Console.ReadLine());

do
{
    Console.WriteLine("Digite a quantidade de hóspedes (até 100):");
    qtd = int.Parse(Console.ReadLine());
} while (qtd<=0);

for (int i = 0; i < qtd; i++)
{
    Console.WriteLine($"Digite o nome do " + (i + 1) + "º hóspede:");
    nome[i] = Convert.ToString(Console.ReadLine());

    if (nome[i] != "pare") 
    {
        Console.WriteLine($"Digite a idade de ", nome[i],":");
        idade[i] = int.Parse(Console.ReadLine());
        if (idade[i] >= 80)
        {
            Console.WriteLine(nome[i], " paga meia.");
            xxx = 0.5;
            qtdM = qtdM + 1;
        }
        else if (idade[i] < 5)
        {
            Console.WriteLine(nome[i], " possui gratuidade.");
            xxx = 0.5;
            qtdG = qtdG + 1;
        }
        else
        {
            xxx = 1;
        }
    }
    else
    {
        Console.WriteLine("Você cadastrou ", i, " hóspedes.");
        xxx = 1;
        qtd = i;
    }
    valorHosp[i] = diariaP * xxx;
    total = total + valorHosp[i];
}

Console.WriteLine("A quantidade de meias hospedagens é: ", qtdM);
Console.WriteLine("A quantidade gratuidades é: ", qtdG);
Console.WriteLine("O valor total da diária de hospedagem para essas ", qtd, " pessoas é de ", total, " Reais.");
