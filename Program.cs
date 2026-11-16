void sectEjer(int num)
{
    switch (num)
    {
        case 1:
            Ejercicio1();
            break;
        case 2:
            Ejercicio2();
            break;
        case 3:
            Ejercicio3();
            break;
        case 4:
            Ejercicio4();
            break;
        case 5:
            Ejercicio5();
            break;
        case 6:
            Ejercicio6();
            break;
        case 7:
            Ejercicio7();
            break;
        case 8:
            Ejercicio8();
            break;
        case 9:
            Ejercicio9();
            break;
        case 10:
            Ejercicio10();
            break;
        case 0:
            Console.WriteLine($"Saliendo del Programa");
            break;
        default:
            Console.WriteLine($"No existe el ejercicio {num}");
            break;
    }
}

int ej = 0;

do{
    Console.WriteLine();
    Console.WriteLine("Ejercicios de Delegados.");
    Console.WriteLine("Ejercicio 1: Delegado Básico");
    Console.WriteLine("Ejercicio 2: Múltiples Métodos");
    Console.WriteLine("Ejercicio 3: Uso de Multicast Delegates");
    Console.WriteLine("Ejercicio 4: Delegados con Diferentes Métodos");
    Console.WriteLine("Ejercicio 5: Delegados y Retornos");
    Console.WriteLine("Ejercicio 6: Delegados y Nombres");
    Console.WriteLine("Ejercicio 7: Delegados y Arrays");
    Console.WriteLine("Ejercicio 8: Delegados y Retornos Condicionales");
    Console.WriteLine("Ejercicio 9: Delegados y Funciones de Callback");
    Console.WriteLine("Ejercicio 10: Delegados y Manejo de Errores");
    Console.WriteLine();

    Console.Write("Introduce el Ejercicio a ver: ");
    ej = Convert.ToInt32(Console.ReadLine());
    sectEjer(ej);
}
while (ej != 0);

void Ejercicio1()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 1 ---");
    Console.WriteLine();

    Console.Write("Introduce un numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce otro numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Operacion op = Sumar;

    Console.WriteLine($"El reustado de la suma de {num1} + {num2} es {op(num1, num2)}");

}

void Ejercicio2(){
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 2 ---");
    Console.WriteLine();

    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");

    Console.WriteLine();
    Console.Write("Que Operación vas a realizar: ");
    int type = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.Write("Introduce un numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce otro numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Operacion op;

    switch (type){
        case 1:
            op = Sumar;
            Console.WriteLine($"El resutado de la suma de {num1} + {num2} es {op(num1, num2)}");
            break;
        case 2:
            op = Restar;
            Console.WriteLine($"El resutado de la resta de {num1} - {num2} es {op(num1, num2)}");
            break;
        default:
            Console.WriteLine($"No exite esa operación");
            break;
    }

}

void Ejercicio3()
{
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 3 ---");
    Console.WriteLine("");

    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicación");

    Console.WriteLine();
    Console.Write("Que Operación vas a realizar: ");
    int type = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.Write("Introduce un numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce otro numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Operacion op;

    switch (type)
    {
        case 1:
            op = Sumar;
            Console.WriteLine($"El resutado de la suma de {num1} + {num2} es {op(num1, num2)}");
            break;
        case 2:
            op = Restar;
            Console.WriteLine($"El resutado de la resta de {num1} - {num2} es {op(num1, num2)}");
            break;
        case 3:
            op = Multiplicar;
            Console.WriteLine($"El resutado de la Multiplicación es {num1} * {num2} es {op(num1, num2)}");
            break;
        default:
            Console.WriteLine($"No exite esa operación");
            break;
    }

}
void Ejercicio4()
{
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 4 ---");
    Console.WriteLine("");

}

void Ejercicio5()
{
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 5 ---");
    Console.WriteLine("");

}

void Ejercicio6()
{
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 6 ---");
    Console.WriteLine("");

}
void Ejercicio7()
{
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 7 ---");
    Console.WriteLine("");

}

void Ejercicio8()
{
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 8 ---");
    Console.WriteLine("");

}

void Ejercicio9()
{
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 9 ---");
    Console.WriteLine("");

}

void Ejercicio10()
{
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 10 ---");
    Console.WriteLine("");

}

int Sumar(int a, int b)
{
    return a + b;
}

int Restar(int a, int b)
{
    return a - b;
}

int Multiplicar(int a, int b){
    return a * b;
}

public delegate int Operacion(int a, int b);