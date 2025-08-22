//3. * *Relatório Financeiro * *
//    -Solicite ao usuário seu salário atual e o valor de uma despesa mensal.
//    - Exiba o saldo disponível após pagar a despesa.


Console.WriteLine("QUAL SEU SALARIO ATUAL ? :");
double salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("QUAL SUA DESPESA MENSAL TOTAL ? :");
double despesa = Convert.ToDouble(Console.ReadLine());

double despesatotal = salario - despesa;

Console.WriteLine($"O Saldo Do Seu Salario é De   {despesatotal} R$");
