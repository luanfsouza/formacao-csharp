int soma = 0, numero = 0;

do
{
    Console.WriteLine("digite um numero");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
    Console.WriteLine(soma);
} while (soma < 100);

