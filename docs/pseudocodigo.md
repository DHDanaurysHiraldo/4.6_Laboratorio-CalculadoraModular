# Pseudocódigo — Calculadora Modular (Laboratorio 4.6)

Algoritmo principal de la calculadora de consola. Cada método del pseudocódigo corresponde a un método en `Program.cs`.

- **PROCEDIMIENTO**: método que realiza una acción y no retorna valor (`void` en C#).
- **FUNCIÓN**: método que retorna un valor (`int`, `decimal`, etc. en C#).

```text
ALGORITMO CalculadoraModular

// ======================= PROGRAMA PRINCIPAL =======================
INICIO
    ENTERO opcion

    HACER
        MostrarMenu()
        opcion ← LeerOpcion()              // retorna 0 si la opción no es válida

        SEGÚN opcion HACER
            CASO 1, 2, 3, 4:
                EjecutarOperacion(opcion)
            CASO 5:
                Escribir "Gracias por usar la calculadora. ¡Hasta luego!"
        FIN SEGÚN
    MIENTRAS opcion ≠ 5
FIN

// ======================= MÉTODOS DEL MENÚ =======================
PROCEDIMIENTO MostrarMenu()
    Escribir "==== CALCULADORA MODULAR ===="
    Escribir "1. Sumar"
    Escribir "2. Restar"
    Escribir "3. Multiplicar"
    Escribir "4. Dividir"
    Escribir "5. Salir"
    Escribir "Seleccione la operación: "
FIN PROCEDIMIENTO

FUNCIÓN LeerOpcion() : ENTERO
    entrada ← Leer()

    SI NO TryParse(entrada, opcion) ENTONCES
        Escribir "Error: Opción inválida."
        RETORNAR 0
    FIN SI

    SI opcion < 1 O opcion > 5 ENTONCES
        Escribir "Error: Opción fuera del rango (1 - 5)."
        RETORNAR 0
    FIN SI

    RETORNAR opcion
FIN FUNCIÓN

// ======================= OPERACIONES =======================
PROCEDIMIENTO EjecutarOperacion(opcion : ENTERO)
    a ← LeerDecimal("Ingrese el primer número: ")
    b ← LeerDecimal("Ingrese el segundo número: ")

    SEGÚN opcion HACER
        CASO 1: MostrarResultado("+", a, b, Sumar(a, b))
        CASO 2: MostrarResultado("-", a, b, Restar(a, b))
        CASO 3: MostrarResultado("*", a, b, Multiplicar(a, b))
        CASO 4:
            SI b = 0 ENTONCES
                Escribir "Error: No se puede dividir entre cero."
            SINO
                MostrarResultado("/", a, b, Dividir(a, b))
            FIN SI
    FIN SEGÚN
FIN PROCEDIMIENTO

FUNCIÓN LeerDecimal(mensaje : TEXTO) : DECIMAL
    HACER
        Escribir mensaje
        entrada ← Leer()
        valido ← TryParse(entrada, valor)
        SI NO valido ENTONCES
            Escribir "Error: Valor inválido. Ingrese un número."
        FIN SI
    MIENTRAS NO valido
    RETORNAR valor
FIN FUNCIÓN

PROCEDIMIENTO MostrarResultado(simbolo : TEXTO, a : DECIMAL, b : DECIMAL, resultado : DECIMAL)
    Escribir "Resultado: ", a, " ", simbolo, " ", b, " = ", resultado
FIN PROCEDIMIENTO

FUNCIÓN Sumar(a : DECIMAL, b : DECIMAL) : DECIMAL
    RETORNAR a + b
FIN FUNCIÓN

FUNCIÓN Restar(a : DECIMAL, b : DECIMAL) : DECIMAL
    RETORNAR a - b
FIN FUNCIÓN

FUNCIÓN Multiplicar(a : DECIMAL, b : DECIMAL) : DECIMAL
    RETORNAR a * b
FIN FUNCIÓN

FUNCIÓN Dividir(a : DECIMAL, b : DECIMAL) : DECIMAL
    RETORNAR a / b                      // se llama solo si b ≠ 0 (RF-07, RN-03)
FIN FUNCIÓN
```

## Correspondencia con C#

| Pseudocódigo | C# |
|---|---|
| `PROCEDIMIENTO MostrarMenu()` | `static void MostrarMenu()` |
| `FUNCIÓN LeerOpcion() : ENTERO` | `static int LeerOpcion()` |
| `PROCEDIMIENTO EjecutarOperacion(opcion : ENTERO)` | `static void EjecutarOperacion(int opcion)` |
| `FUNCIÓN LeerDecimal(mensaje : TEXTO) : DECIMAL` | `static decimal LeerDecimal(string mensaje)` |
| `PROCEDIMIENTO MostrarResultado(...)` | `static void MostrarResultado(string simbolo, decimal a, decimal b, decimal resultado)` |
| `FUNCIÓN Sumar(a, b : DECIMAL) : DECIMAL` | `static decimal Sumar(decimal a, decimal b)` |
| `FUNCIÓN Restar(a, b : DECIMAL) : DECIMAL` | `static decimal Restar(decimal a, decimal b)` |
| `FUNCIÓN Multiplicar(a, b : DECIMAL) : DECIMAL` | `static decimal Multiplicar(decimal a, decimal b)` |
| `FUNCIÓN Dividir(a, b : DECIMAL) : DECIMAL` | `static decimal Dividir(decimal a, decimal b)` |