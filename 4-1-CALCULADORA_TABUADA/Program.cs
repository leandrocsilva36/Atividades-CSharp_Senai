// === calculadora tabuada



bool calcularNovamente;

do
{
    Console.WriteLine("== Calculadora de Tabuada ==");
    Console.Write("Insira o número que deseja calcular: ");
    int numeroEscolhido = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"\n== Tabuada do {numeroEscolhido} ==");
    for (int contador = 1; contador <= 10; contador = contador + 1)
    {
        Console.WriteLine($"{contador} x {numeroEscolhido} = {contador * numeroEscolhido}");
    }

    Console.WriteLine("\nVocê deseja calcular mais uma tabuada? (s/n): ");
    string decisao = Console.ReadLine();

    if (decisao == "s")
    {
        calcularNovamente = true;
    }
    else
    {
        calcularNovamente = false;
    }


} while (calcularNovamente);

