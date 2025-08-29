// 06 - Divisão de Conta
//*Solicite ao usuário o valor total de uma refeição e a quantidade de pessoas.
//   *Mostre quanto cada pessoa deve pagar.


Console.WriteLine("QUAL FOI O VALOR TOTAL DA CONTA R$ ? :");

    double valordaconta = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("QUANTAS PESSOAS IRÃO DIVIDIR A CONTA ? :");
    double pessoas = Convert.ToDouble(Console.ReadLine());

double total = valordaconta / pessoas;

Console.WriteLine  ($"CADA PESSOA IRA PAGAR {total} R$");



