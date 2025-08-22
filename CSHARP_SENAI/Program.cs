// Atividades de Variáveis, Entrada, Saída e operadores matemáticos

//Etapa 1 — Variáveis

//    **Atividade 1.1**

//Crie variáveis para armazenar:
//    Seu nome
//  Sua idade
//    Sua altura
//Atribua valores a elas (direto no código, sem entrada do usuário) e exiba no console.

//***Atividade 1.1

//string nome = "leandro";
//int idade = 37;
//double altura = 1.80;

//Console.WriteLine("ola senhor, seu nome é " + nome);
//Console.WriteLine("Voce Tem " + idade + " Anos De idade");
//Console.WriteLine("voce tem " + altura + " De Altura");


//Atividade 1.2

//    Crie variáveis para armazenar:
//    O nome de um produto
//    Sua quantidade em estoque
//    Seu preço unitário
//    Exiba os valores no console.


//***Atividade 1.2

//string nomeprod = "chocolate";
//int quantprod = 10;
//double valorprod = 2;

//Console.WriteLine("item selecionado é o " + nomeprod);
//Console.WriteLine("Voce Tem " + quantprod + " No estoque");
//Console.WriteLine("Custa " + valorprod + "R$");

//Etapa 2 — Entrada de Dados - Objetivo: ler valores do teclado

//    Atividade 2.1
//    Peça para o usuário informar seu nome e idade, e armazene nas variáveis correspondentes

//Console.WriteLine ("Digite seu nome:");
//string nome = Console.ReadLine();
//Console.WriteLine("Digite Sua Idade");
//int idade = int.Parse (Console.ReadLine());

//Atividade 2.2
//    Peça para o usuário informar:
//    O nome de um produto
//    O preço
//    A quantidade em estoque
//Não precisa fazer cálculos ainda, apenas armazene.

//Console.WriteLine("Qual o nome do produto");
//string nomeprod = Console.ReadLine();

//Console.WriteLine("Qual o Preço Do Produto");
//double precoprod = double.Parse(Console.ReadLine());

//Console.WriteLine("Qual a quantidade Em Estoque");
//int quantprod =int.Parse(Console.ReadLine());

//Etapa 3 — Saída de Dados
//    Objetivo: exibir informações formatadas no console
//    Atividade 3.1
//--- Usando os dados da Atividade 2.1, exiba a frase:
//**Olá, [nome]! Você tem[idade] anos.

//Console.WriteLine("Digite seu nome:");
//string nome = Console.ReadLine();
//Console.WriteLine("Digite Sua Idade");
//int idade = int.Parse (Console.ReadLine());

//Console.WriteLine(" Ola " + nome + ",voce tem " + idade + " Anos De Idade ");

//Atividade 3.2

//   --- Usando os dados da Atividade 2.2, exiba a frase:

//**O produto[nome] custa R$[preço] e temos[quantidade] em estoque.

//Console.WriteLine("Qual o nome do produto");
//string nomeprod = Console.ReadLine();

//Console.WriteLine("Qual o Preço Do Produto");
//double precoprod = double.Parse(Console.ReadLine());

//Console.WriteLine("Qual a quantidade Em Estoque");
//int quantprod = int.Parse(Console.ReadLine());

//Console.WriteLine("O Produto: " + nomeprod + " custa R$:" + precoprod + "e temos :" + quantprod + "em estoque");


//Etapa 4 — Operadores Matemáticos
//    Objetivo: aplicar soma, subtração, multiplicação e divisão.
//    **Atividade 4.1**
//Peça dois números inteiros e exiba
//    **A soma , A subtração , A multiplicação , A divisão

////Coleta o segundo numero da soma
//Console.WriteLine("Digite 2 numeros inteiros");
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int soma = num1 + num2;
//int subtracao = num1 - num2;
//int multiplicacao = num1 * num2;
//int divisao = num1 / num2;

//Console.WriteLine("O resultado da soma e =" + soma);
//Console.WriteLine("O resultado da soma e =" + subtracao);
//Console.WriteLine("O resultado da subtração é =" + subtracao);
//Console.WriteLine("O resultado da Multiplicação é  =" + multiplicacao);
//Console.WriteLine("O resultado da Divisao é =" + divisao);

//*Atividade 4.2

//---- Peça o preço de um produto e a quantidade comprada.
//Calcule o **valor total** da compra e exiba.

//Console.WriteLine("Digite o Nome do produto Que Deseja");
//string prod = Console.ReadLine();

//Console.WriteLine("Digite o Valor do Produto ");
//double precoprod = int.Parse (Console.ReadLine());

//Console.WriteLine("Qual A quantidade Que Voce Deseja Comprar ?");
// double quantidadeprod = int.Parse (Console.ReadLine());

//double valorTotal = precoprod * quantidadeprod;
//Console.WriteLine("Valor total da compra: R$" + valorTotal);


//****Atividade 4.3

//Peça três notas (decimais), calcule e exiba a média.

//Console.Write("Digite a primeira nota: ");
//double nota1 = double.Parse(Console.ReadLine());

//Console.Write("Digite a segunda nota: ");
//double nota2 = double.Parse(Console.ReadLine());

//Console.Write("Digite a terceira nota: ");
//double nota3 = double.Parse(Console.ReadLine());

//double media = (nota1 + nota2 + nota3) / 3;
//Console.WriteLine("Média das notas: " + media);








