using System;

class Program
{
    static void Main()
    {
        // Ejecutamos los ejercicios en orden, como en el repositorio actual.
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
        Ejercicio4();
        Ejercicio5();
        Ejercicio6();
        Ejercicio7();
        Ejercicio8();
        Ejercicio9();
        Ejercicio10();
    }

    // EJERCICIO 1: operaciones con dos numeros.
    static void Ejercicio1()
    {
        Console.WriteLine("\n--- Ejercicio 1 ---");

        Console.Write("Introduce el primer numero: ");
        int numero1 = int.Parse(Console.ReadLine()!);

        Console.Write("Introduce el segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"La suma es {numero1 + numero2}");
        Console.WriteLine($"La resta es: {numero1} - {numero2} = {numero1 - numero2}");
        Console.WriteLine($"La multiplicacion es: {numero1 * numero2}");

        // El ejemplo del PDF tambien muestra la division, aunque no aparece
        // en la primera frase del enunciado.
        if (numero2 != 0)
        {
            Console.WriteLine($"La division es: {numero1 / numero2}");
            Console.WriteLine($"El modulo es: {numero1 % numero2}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero ni calcular el modulo.");
        }
    }

    // EJERCICIO 2: total de una cuenta de un bar.
    static void Ejercicio2()
    {
        Console.WriteLine("\n--- Ejercicio 2 ---");

        const decimal PRECIO_HAMBURGUESA = 4.50m;
        const decimal PRECIO_PAPAS = 2.25m;
        const decimal PRECIO_BEBIDA = 1.35m;

        Console.Write("Cantidad de hamburguesas: ");
        int hamburguesas = int.Parse(Console.ReadLine()!);

        Console.Write("Cantidad de papas: ");
        int papas = int.Parse(Console.ReadLine()!);

        Console.Write("Cantidad de bebidas: ");
        int bebidas = int.Parse(Console.ReadLine()!);

        decimal total = hamburguesas * PRECIO_HAMBURGUESA
                      + papas * PRECIO_PAPAS
                      + bebidas * PRECIO_BEBIDA;

        Console.WriteLine($"Cantidad a pagar: {total:F2}€");
    }

    // EJERCICIO 3: operaciones de la clase Math.
    static void Ejercicio3()
    {
        Console.WriteLine("\n--- Ejercicio 3 ---");

        Console.Write("Introduce un numero: ");
        double numero = double.Parse(Console.ReadLine()!);

        // El enunciado permite crear por codigo el segundo argumento
        // necesario para Max y Min. Usamos el valor 5 como ejemplo.
        double otroNumero = 5;

        Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
        Console.WriteLine($"Potencia al cubo: {Math.Pow(numero, 3)}");
        Console.WriteLine($"Raiz cuadrada: {Math.Sqrt(numero)}");
        Console.WriteLine($"Seno: {Math.Sin(numero)}");
        Console.WriteLine($"Coseno: {Math.Cos(numero)}");
        Console.WriteLine($"Numero maximo entre {numero} y {otroNumero}: {Math.Max(numero, otroNumero)}");
        Console.WriteLine($"Numero minimo entre {numero} y {otroNumero}: {Math.Min(numero, otroNumero)}");
    }

    // EJERCICIO 4: perimetro de un cuadrado.
    static void Ejercicio4()
    {
        Console.WriteLine("\n--- Ejercicio 4 ---");

        Console.Write("Introduce el valor de un lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine()!);

        double perimetro = lado * 4;
        Console.WriteLine($"El perimetro del cuadrado es: {perimetro}");
    }

    // EJERCICIO 5: suma de los dos primeros y producto de los dos ultimos.
    static void Ejercicio5()
    {
        Console.WriteLine("\n--- Ejercicio 5 ---");

        Console.Write("Introduce el primer numero: ");
        double numero1 = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el segundo numero: ");
        double numero2 = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el tercer numero: ");
        double numero3 = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el cuarto numero: ");
        double numero4 = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"La suma de los dos primeros es: {numero1 + numero2}");
        Console.WriteLine($"El producto del tercero y el cuarto es: {numero3 * numero4}");
    }

    // EJERCICIO 6: suma y promedio de cuatro numeros.
    static void Ejercicio6()
    {
        Console.WriteLine("\n--- Ejercicio 6 ---");

        Console.Write("Introduce el primer valor: ");
        double numero1 = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el segundo valor: ");
        double numero2 = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el tercer valor: ");
        double numero3 = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el cuarto valor: ");
        double numero4 = double.Parse(Console.ReadLine()!);

        double suma = numero1 + numero2 + numero3 + numero4;
        double promedio = suma / 4;

        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"El promedio es: {promedio}");
    }

    // EJERCICIO 7: coste total de un articulo.
    static void Ejercicio7()
    {
        Console.WriteLine("\n--- Ejercicio 7 ---");

        Console.Write("Introduce el precio del articulo: ");
        decimal precio = decimal.Parse(Console.ReadLine()!);

        Console.Write("Introduce la cantidad de articulos: ");
        int cantidad = int.Parse(Console.ReadLine()!);

        decimal total = precio * cantidad;
        Console.WriteLine($"El coste total es: {total:F2}€");
    }

    // EJERCICIO 8: nota final ponderada.
    static void Ejercicio8()
    {
        Console.WriteLine("\n--- Ejercicio 8 ---");

        Console.Write("Introduce la primera nota parcial: ");
        decimal parcial1 = decimal.Parse(Console.ReadLine()!);

        Console.Write("Introduce la segunda nota parcial: ");
        decimal parcial2 = decimal.Parse(Console.ReadLine()!);

        Console.Write("Introduce la nota del examen: ");
        decimal examen = decimal.Parse(Console.ReadLine()!);

        Console.Write("Introduce la nota del trabajo final: ");
        decimal trabajo = decimal.Parse(Console.ReadLine()!);

        decimal promedioParciales = (parcial1 + parcial2) / 2m;
        decimal notaFinal = promedioParciales * 0.50m
                          + examen * 0.30m
                          + trabajo * 0.20m;

        Console.WriteLine($"La nota final del modulo es: {notaFinal:F2}");
    }

    // EJERCICIO 9: porcentaje de participacion de tres socios.
    static void Ejercicio9()
    {
        Console.WriteLine("\n--- Ejercicio 9 ---");

        Console.Write("Aportacion del socio 1: ");
        decimal socio1 = decimal.Parse(Console.ReadLine()!);

        Console.Write("Aportacion del socio 2: ");
        decimal socio2 = decimal.Parse(Console.ReadLine()!);

        Console.Write("Aportacion del socio 3: ");
        decimal socio3 = decimal.Parse(Console.ReadLine()!);

        decimal totalAportaciones = socio1 + socio2 + socio3;

        if (totalAportaciones == 0)
        {
            Console.WriteLine("No se pueden calcular porcentajes si las aportaciones suman cero.");
            return;
        }

        decimal porcentaje1 = socio1 / totalAportaciones * 100;
        decimal porcentaje2 = socio2 / totalAportaciones * 100;
        decimal porcentaje3 = socio3 / totalAportaciones * 100;

        Console.WriteLine($"El porcentaje del socio 1 es {porcentaje1:F2}%, del socio 2 es {porcentaje2:F2}% y del socio 3 es {porcentaje3:F2}%.");
    }

    // EJERCICIO 10: comprobar si un texto empieza por "www".
    static void Ejercicio10()
    {
        Console.WriteLine("\n--- Ejercicio 10 ---");
        Console.Write("Introduce un texto: ");
        string texto = Console.ReadLine() ?? "";

        bool resultado = ComienzaPorWww(texto);

        Console.WriteLine(resultado.ToString().ToLower());
    }
}