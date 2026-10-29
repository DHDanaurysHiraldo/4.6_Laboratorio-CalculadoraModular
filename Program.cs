int opcionDeMenu;
do
{
    MostrarMenu();

    if (!int.TryParse(Console.ReadLine(), out opcionDeMenu))
    {
        Console.WriteLine("Error: Opción Inválida");
        Pausar();
    }
    else
    {
        if (opcionDeMenu < 1 || opcionDeMenu > 5)
        {
            Console.WriteLine("Error: Opción Fuera del Rango (1 - 5)");
            Pausar();
        }


    }




    //switch (opcionDeMenu)
    //{
    //    case 1:
    //        break;

    //    case 2:
    //        break;

    //    case 3:
    //        break;

    //    case 4:
    //        break;

    //    default:
    //        break;
    //}

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
    Console.WriteLine("Presione una tecla para reintentar...");
    Console.ReadKey();
}