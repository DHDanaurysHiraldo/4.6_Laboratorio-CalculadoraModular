using System.Globalization;

int opcionDeMenu;
do
{
    MostrarMenu();

    opcionDeMenu = LeerOpcion();

    switch (opcionDeMenu)
    {
        case 1:
        case 2:
        case 3:
        case 4:
            EjecutarOperacion(opcionDeMenu);
            break;
            
        case 5:
            Console.WriteLine();
            Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
            break;
    }

}
while (opcionDeMenu != 5);

static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("==== CALCULADORA MODULAR ====");
    Console.WriteLine("=============================");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.WriteLine();
    Console.Write("Seleccione la operación: ");
}

static void Pausar()
{
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey(true);
}

static int LeerOpcion()
{
    int opcionDeMenu;
    if (!int.TryParse(Console.ReadLine(), out opcionDeMenu))
    {
        Console.WriteLine("Error: Opción Inválida");
        Pausar();
        return 0;
    }

    if (opcionDeMenu < 1 || opcionDeMenu > 5)
    {
        Console.WriteLine("Error: Opción Fuera del Rango (1 - 5)");
        Pausar();
        return 0;
    }

    return opcionDeMenu;
}

// VALIDA QUE LA ENTRADA DEL USUARIO SEA NUMÉRICA (Tipo DecimaL)
static decimal LeerDecimal(string mensaje)
{
    decimal valor;
    bool esValido;

    do
    {
        Console.Write(mensaje);
        esValido = decimal.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out valor);

        if (!esValido)
        {
            Console.WriteLine("Error: Valor inválido. Ingrese un número (use punto para decimales).");
        }
    } while (!esValido);

    return valor;
}

//METODOS PARA LAS OPERACIONES
static decimal Sumar(decimal a, decimal b)
{
    return a + b;
}

static decimal Restar(decimal a, decimal b)
{
    return a - b;
}

static decimal Multiplicar(decimal a, decimal b)
{
    return a * b;
}

static decimal Dividir(decimal a, decimal b)
{
    return a / b;
}

static void EjecutarOperacion(int opcion)
{
    decimal a = LeerDecimal("Ingrese el primer número: ");
    decimal b = LeerDecimal("Ingrese el segundo número: ");

    switch (opcion)
    {
        case 1:
            MostrarResultado("+", a, b, Sumar(a, b));
            break;

        case 2:
            MostrarResultado("-", a, b, Restar(a, b));
            break;

        case 3:
            MostrarResultado("*", a, b, Multiplicar(a, b));
            break;

        case 4:
            if (b == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            else
            {
                MostrarResultado("/", a, b, Dividir(a, b));
            }
            break;
    }

    Pausar();
}

static void MostrarResultado(string simbolo, decimal a, decimal b, decimal resultado)
{
    Console.WriteLine($"Resultado: {a} {simbolo} {b} = {resultado}");
}