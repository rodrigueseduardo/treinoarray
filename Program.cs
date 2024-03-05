Console.WriteLine("Bem vindo a calculadora de média para treino de array!");

int[] numeros = new int[10];
int soma = 0;

//vou pedir ao usuario para digitar 10 numeros aleatórios
Console.WriteLine("Digite 10 números para calcular a média: ");

//vou armazenar os numeros em uma array
for (int i = 0; i < 10; i++)
    {
        Console.Write($"Número {i + 1}: ");
        numeros[i] = Convert.ToInt32(Console.ReadLine());
        soma += numeros[i];
    }

    //calculo da média
    double media = (double)soma / 10;

    //exiba a média
    Console.WriteLine($"A média dos números digitados é: {media}");
