//Estrutura_Condicional

//Console.Write("Digite sua primeira nota: ");
//int nota1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Digite sua segunda nota: ");
//int nota2 = Convert.ToInt32(Console.ReadLine());

//double media = (nota1 + nota2) / 3;
//Console.WriteLine("Média das notas: " + media);


//if (media >= 5)
//{
//    Console.Write("Parabens Voce Passou De Ano ");
//}
//else
//{
//    Console.Write("Infelizmente voce Reprovou de Ano ");
//}

//--DESAFIO
//Desenvolva uma calculadora em C# que utilize **estruturas condicionais** para realizar operações matemáticas.
//O programa deve:
//  ----
// 1.Solicitar ao usuário dois números.
//2. Solicitar ao usuário a operação desejada (`+`, `-`, `*`, `/`).
//3. Usar estruturas condicionais (`if/else` ou `switch`) para identificar a operação escolhida.
//4. Exibir o resultado da operação.
//5. Tratar divisões por zero, exibindo uma mensagem de erro adequada.

//**********************************************************************************************

// Solicita o primeiro número
Console.Write("Digite o primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

// Solicita o segundo número
Console.Write("Digite o segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

// Solicita a operação desejada
Console.Write("Digite a operação desejada (+, -, *, /): ");
string operacao = Console.ReadLine();

double resultado;


// Estrutura condicional para identificar a operação
switch (operacao)
{
    case "+":
        resultado = numero1 + numero2;
        Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
        break;

    case "-":
        resultado = numero1 - numero2;
        Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
        break;

    case "*":
        resultado = numero1 * numero2;
        Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultado}");
        break;


}













