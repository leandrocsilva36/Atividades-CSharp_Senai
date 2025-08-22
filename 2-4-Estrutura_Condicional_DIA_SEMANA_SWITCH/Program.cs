
// ==== DIA DA SEMANA EM NUMEROS =====

using System;
using System.Security.Cryptography;

Console.Write(" Escreva Um Numero ' de 1 a 7 ' e Eu Te direi Qual é o Dia Da Semana : ");
int numero = Convert.ToInt32(Console.ReadLine());
string dia;


switch (numero)
{ 
  case 1:  
    
    Console.Write("DOMINGO");
        break;

    case 2:

        Console.Write("SEGUNDA");
        break;
        ecase 3: 

    Console.Write("TERÇA");
        break;
    case 4:

        Console.Write("QUARTA");
        break;
    case 5: 

    Console.Write("QUINTA");
        break;
        ecase 6: 

    Console.Write("SEXTA");
        break;
    case 7:

        Console.Write("SABADO");
        break;
    default:

        Console.Write("NUMERO INVALIDO");
        break;




//Console.WriteLine ("parabens hoje é  " + dia  );