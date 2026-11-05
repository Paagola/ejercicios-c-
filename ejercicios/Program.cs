using System;

class Program
{
    static void Main()
    {
        Ejercicio1();
        Ejercicio2();
    }


    static void Ejercicio1()
    {
        Console.Write("Introduce el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"La suma es {numero1 + numero2}");
        Console.WriteLine($"La resta es: {numero1} - {numero2} = {numero1 - numero2}");
        Console.WriteLine($"La multiplicación es: {numero1 * numero2}");
        Console.WriteLine($"La división es: {numero1 / numero2}");
        Console.WriteLine($"El módulo es: {numero1 % numero2}");
    }

    // 2. Total a pagar en un bar (precios con constantes)
    static void Ejercicio2()
    {
        const decimal PRECIO_HAMBURGUESA = 4.50m;
        const decimal PRECIO_PAPAS = 2.25m;
        const decimal PRECIO_BEBIDA = 1.35m;

        Console.Write("Cantidad de hamburguesas: ");
        int hamburguesas = int.Parse(Console.ReadLine());
        Console.Write("Cantidad de papas: ");
        int papas = int.Parse(Console.ReadLine());
        Console.Write("Cantidad de bebidas: ");
        int bebidas = int.Parse(Console.ReadLine());

        decimal total = hamburguesas * PRECIO_HAMBURGUESA
                      + papas * PRECIO_PAPAS
                      + bebidas * PRECIO_BEBIDA;

        Console.WriteLine($"Cantidad a pagar: {total:0.00}€");
    }
}