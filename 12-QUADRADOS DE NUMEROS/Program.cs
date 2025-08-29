// 12 - Quadrados de Números

//**Usuário informa um número.
//    O programa exibe os quadrados de todos os números de 1 até o número informado.

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Quadrados dos números de 1 até {numero}:");
for (int i = 1; i <= numero; i++)
{
    Console.WriteLine($"{i}² = {i * i}");
}

