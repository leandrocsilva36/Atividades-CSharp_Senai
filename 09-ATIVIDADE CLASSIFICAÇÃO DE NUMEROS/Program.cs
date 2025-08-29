//  09 - ATIVIDADE Classificação de Números

//**Usuário informa um número.
//    ** O programa verifica se ele é positivo, negativo ou zero.


Console.WriteLine("Digite um número: ");
int velocidade = Convert.ToInt32(Console.ReadLine());


switch (velocidade)
{
    case > 0:
        Console.WriteLine("O número é positivo.");
        break;

    case < 0:
        Console.WriteLine("O número é negativo.");
        break;


    default:
        Console.WriteLine("O número é zero.");
        break;
}




