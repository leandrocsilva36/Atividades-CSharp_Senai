﻿// 13-ATIVIDADE SEQUENCIA DE FIBONACCI (LIMITADA)

//**Usuário informa quantos termos deseja.
//  **O programa exibe a sequência de Fibonacci até aquele termo.


Console.Write("Quantos termos da sequência de Fibonacci deseja? ");
int termos = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1;

Console.Write("Sequência de Fibonacci: ");

for (int i = 0; i < termos; i++)
{
    Console.Write(a + " ");
    int temp = a;
    a = b;
    b = temp + b;
}

Console.WriteLine();
