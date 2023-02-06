var planilha = new string[4,2];

planilha[0,0] = "Josefina";
planilha[0, 1] = "65";

planilha[1, 0] = "Seu Dário";
planilha[1, 1] = "75";

planilha[2, 0] = "Kátia";
planilha[2, 1] = "12";

planilha[3, 0] = "Amauri";
planilha[3, 1] = "25";

for (int i = 0; i < 4; i++)
{
	for (int j = 0; j < 2; j++)
	{
		if (j == 1)
		{
           var idade = Convert.ToInt32( planilha[i, j] );
			if (idade < 5)
			{
				planilha[i, j] = "não paga";


			}
			else if (idade >= 5 && idade < 65)
			{
				planilha[i, j] = "Paga inteira";

			}
			else 
			{
                planilha[i, j] = "Paga meia";
            }

        }
    }
}


Console.WriteLine("SISTEMA HOSPEDAGEM");

Console.WriteLine("por favor digite seu nome : ");
Console.ReadLine();