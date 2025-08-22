// ==== DIA DA SEMANA EM NUMEROS =====

using System;

Console.Write(" Escreva Um Numero ' de 1 a 7 ' e Eu Te direi Qual é o Dia Da Semana : ");
   int numero = Convert.ToInt32 (Console.ReadLine());
   string dia;


if (numero == 1)
{
    Console.Write ("DOMINGO");
}
else if (numero == 2)
{
    Console.Write ("SEGUNDA");
}
else if (numero == 3)
{
    Console.Write ("TERÇA");
}
else if (numero == 4 )
{
    Console.Write ("QUARTA");
}
else if (numero == 5)
{
    Console.Write ("QUINTA");
}
else if (numero == 6)
{
    Console.Write ("SEXTA");
}
else if (numero == 7)
{
    Console.Write("SABADO");
}
else
{
    Console.Write("NUMERO INVALIDO");

}



//Console.WriteLine ("parabens hoje é  " + dia  );