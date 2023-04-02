// See https://aka.ms/new-console-template for more information
int primeironumero, segundonumero, resultado;

Console.WriteLine("--- Subtração ---");

Console.WriteLine("Digite o primeiro numero: ");
primeironumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
segundonumero = Convert.ToInt32(Console.ReadLine());

resultado = primeironumero - segundonumero;

Console.WriteLine($"Subtração: {resultado}");