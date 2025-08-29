// ====TESTE CODIGOS ===== 


//Console.WriteLine("ESCREVA UM NUMERO PARA SOMAR !");

//  Console.Write("Digite o primeiro numero: ");
//double num1 = coletarvalor();

//Console.Write("Digite o segundo  numero: ");
//double num2 = coletarvalor();

//double coletarvalor();

//coletarvalor = Convert.ToDouble(Console.ReadLine());


//Console.WriteLine($"A SOMA DOS NUMEROS É {coletarvalor} ");



// 1. Crie uma única instância de Random
Random geradorAleatorio = new Random();

// 2. Gere números aleatórios dentro de intervalos específicos
int dado = geradorAleatorio.Next(1, 7); // Simula o lançamento de um dado de 1 a 6
int mes = geradorAleatorio.Next(1, 13);  // Simula um mês de 1 a 12

Console.WriteLine($"Valor do dado: {dado}");
Console.WriteLine($"Número do mês: {mes}");