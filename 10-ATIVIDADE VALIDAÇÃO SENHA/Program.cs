//10 VALIDAÇÃO SENHA

//* O programa pede uma senha ao usuário.
//* Se for igual a "12345", exibe “Acesso Permitido”, caso contrário, “Acesso Negado”.

int senha = 12345;

Console.WriteLine("DIGITE SUA SENHA");

int respostasenha = Convert.ToInt32(Console.ReadLine());

if (respostasenha == senha)
{
    Console.WriteLine("Acesso Permitido");
}
else
{
    Console.WriteLine("Acesso Negado !");
}