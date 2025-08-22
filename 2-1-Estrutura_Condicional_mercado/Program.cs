Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine();

Console.Write("\nDigite a quantidade do produto: ");
int quantidadeProduto = int.Parse(Console.ReadLine());

Console.Write("\nDigite o valor unitário do produto: ");
double valorUnitario = double.Parse(Console.ReadLine());

Console.Write("\nDigite quanto você tem para pagar: ");
double temDeDinheiro = double.Parse(Console.ReadLine());

double valorAPagar = valorUnitario * quantidadeProduto;

if (temDeDinheiro >= valorAPagar)
{
    double troco = temDeDinheiro - valorAPagar;
    Console.WriteLine($"\nVocê está comprando {quantidadeProduto} {nomeProduto}(s), no valor de R${valorUnitario:F2} cada, totalizando R${valorAPagar:F2}. Seu troco é R${troco:F2}.");
}
else
{
    double falta = valorAPagar - temDeDinheiro;
    Console.WriteLine($"\nVocê está tentando comprar {quantidadeProduto} {nomeProduto}(s), no valor de R${valorUnitario:F2} cada, totalizando R${valorAPagar:F2}, porém você não tem saldo suficiente. Faltam R${falta:F2}.");
}