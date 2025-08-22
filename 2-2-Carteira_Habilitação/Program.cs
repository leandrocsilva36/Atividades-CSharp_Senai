// =====      2-1-Estrutura_Condicional CARTEIRA DE HABILITAÇÃO   ====




Console.Write("CARTEIRA NACIONAL DE HABILITAÇÃO");

Console.Write("\n\nQual Seu Nome ? :");
string nome = Console.ReadLine();

Console.Write("QUAL A SUA IDADE ? :");
int idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Voce Passou no Examen psicotécnico ? \nDigite '1' Para Sim e '2' para Não' ");
int examepsico = Convert.ToInt32(Console.ReadLine());

Console.Write("QUAL FOI SUA NOTA NO EXAME TEORICO ?");
double exameteorico = Convert.ToDouble(Console.ReadLine());

Console.Write("QUAL FOI SUA NOTA NO EXAME PRATICO ?");
double examepratico = Convert.ToDouble(Console.ReadLine());

//CALCULO TOTAL DAS NOTAS

double totalnotas = (exameteorico + examepratico) /2;


if (examepsico ==1 && totalnotas >=5 && idade>=18)
{
    Console.WriteLine("\n Parabens Voce Conseguiu Sua Habilitação");
}

else
{
    Console.WriteLine("\n  Que Pena, Voce Não Conseguiu Sua Habilitação");
}











