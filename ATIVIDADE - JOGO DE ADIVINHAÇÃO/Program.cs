// ATIVIDADE - JOGO DE ADIVINHAÇÃO

Random random = new Random();
int numeroSecreto = random.Next(1, 101); // Número secreto entre 1 e 100
int palpite = 0;

Console.WriteLine("=== Jogo de Adivinhação ===");
Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100!");

while (palpite != numeroSecreto)
{
    Console.Write("\nDigite seu palpite: ");

    // Verifica se a entrada é válida
    if (!int.TryParse(Console.ReadLine(), out palpite))
    {
        Console.WriteLine("Por favor, digite um número válido.");
        continue;
    }

    if (palpite < numeroSecreto)
    {
        Console.WriteLine("O número secreto é MAIOR!");
    }
    else if (palpite > numeroSecreto)
    {
        Console.WriteLine("O número secreto é MENOR!");
    }
    else
    {
        Console.WriteLine("\n🎉 Parabéns! Você acertou o número secreto!");
    }
}

Console.WriteLine("\nFim do jogo. Obrigado por jogar!");








