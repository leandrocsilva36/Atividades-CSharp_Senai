// 07 Velocidade da Via

//**Usuário informa a idade..
//    **O programa informa se o voto é obrigatório, facultativo ou não permitido.

Console.WriteLine("QUAL A SUA IDADE  ? :");
int IDADE = Convert.ToInt32(Console.ReadLine());


switch (IDADE)
{
    case >= 16:
        Console.WriteLine("SEU VOTO É OBRIGATORIO");
        break;

    default:
        Console.WriteLine("SEU VOTO É FACULTATIVO");
        break;
}