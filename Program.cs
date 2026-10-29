Console.WriteLine("==== CALCULADORA MODULAR ====");

Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.WriteLine("5. Salir");
Console.WriteLine();
Console.Write("Seleccione la operación: ");

int opcionDeMenu;
if (!int.TryParse(Console.ReadLine(), out opcionDeMenu))
{
    Console.WriteLine("Error: Opción Inválida");
}
else
{
    if (opcionDeMenu < 1 || opcionDeMenu > 5)
    {
        Console.WriteLine("Error: Opción Fuera del Rango (1 - 5)");
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
