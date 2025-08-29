// 11-CONTAGEM DE PARES
//**Usuário informa um número.
//**O programa mostra todos os números pares de 0 até esse número.


Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Números pares de 0 até " + numero + ":");
for (int i = 0; i <= numero; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();
