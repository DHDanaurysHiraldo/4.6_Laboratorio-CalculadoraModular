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
            Console.WriteLine($"Operación {opcionDeMenu}: pendiente de implementar");
            Pausar();
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