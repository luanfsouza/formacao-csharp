int numero = 5;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}


string opcao;

while (true)
{
    
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro do cliente");
            break;
        case "2":
            Console.WriteLine("busca do cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        default:
            Console.WriteLine("Encerrando");
            Environment.Exit(0);
            break;
    }
   
}