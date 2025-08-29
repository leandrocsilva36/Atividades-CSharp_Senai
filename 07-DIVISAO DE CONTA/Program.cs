// 7 Velocidade da Via

//*Usuário informa a velocidade de um carro
//    * O programa verifica se está dentro do limite (até 80 km/h) ou se foi multado.

Console.WriteLine("QUAL A VELOCIDADE DO CARRO ? :");
int velocidade  =  Convert.ToInt32(Console.ReadLine());


switch (velocidade)
{
    case <= 80:
        Console.WriteLine("Sua velocidade está de acordo com a via");
        break;

    default:
        Console.WriteLine("Você foi multado por estar acima do limite de 80 KM/H");
        break;
}
