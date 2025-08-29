
//// ("==Calculcadora de IMC");


Console.WriteLine("==Calculcadora de IMC");

Console.Write("Digite seu Peso (kg)");

double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura (mt)");

double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc <= 18.5)
{
    Console.WriteLine($"IMC de {imc:F2} clasificacao baixo peso");
}
else if (imc >= 18.6 && imc <= 24.9)
{
    Console.WriteLine($"IMC de {imc:F2} clasificacao Peso Normal");
}
else if (imc >= 25 && imc <= 29.9)
{
    Console.WriteLine($"IMC de {imc:F2} clasificacao Sobre Peso");
}
else if (imc >= 30 && imc <= 34.9)
{
    Console.WriteLine($"IMC de {imc:F2} clasificacao Obesidade Grau I");
}
else if (imc >= 35 && imc <= 39.9)
{
    Console.WriteLine($"IMC de {imc:F2} clasificacao Obesidade Grau II");
}
else
{
    Console.WriteLine($"IMC de {imc:F2} clasificacao Obesidade Grau III");

}