//4. * *Conversor de Moedas**
//    - Solicite ao usuário um valor em reais e a cotação do dólar.
//    - Exiba o valor convertido para dólares.

Console.Write("QUANTO VOCE TEM EM DINHIRO R$  ? :");

double reais = Convert.ToDouble(Console.ReadLine());
double dolar = 5.42;

Console.WriteLine($"EM DÓLAR VOCÊ TEM {(reais / dolar).ToString("F2")} $");






