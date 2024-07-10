using System;

class Program
{
    static void Main()
    {
        // Pedir al usuario que ingrese el primer número
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Pedir al usuario que ingrese el segundo número
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Realizar las operaciones matemáticas
        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;
        double division = num1 / num2;
        double modulo = num1 % num2;

        // Mostrar los resultados
        Console.WriteLine($"\nResultados:");
        Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
        Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");
        Console.WriteLine($"División: {num1} / {num2} = {division}");
        Console.WriteLine($"Módulo: {num1} % {num2} = {modulo}");
    }
}