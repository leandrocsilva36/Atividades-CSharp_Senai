// 5 -Cálculo de Desconto
//*Peça ao usuário o valor de um produto e um percentual de desconto.
// *Calcule e mostre o valor final com desconto.


Console.WriteLine ("ESCREVA O NOME DE UM PRODUTO QUE DESEJA COMPRAR :");
string nomeprod = Console.ReadLine();

Console.WriteLine("COLOQUE O VALOR DO PRODUTO :");
double preco = Convert.ToDouble (Console.ReadLine());

double desconto = preco * 50/100;



Console.WriteLine($"VOCE COMPROU O {nomeprod} e voce pagou {desconto} R$ com 50% de desconto");