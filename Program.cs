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
    Console.WriteLine("--- Ejercicios de Delegados ---");
    Console.WriteLine();

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

    Operacion op = Operadores.Sumar;

    Console.WriteLine($"El resutado de la suma de {num1} + {num2} es {op(num1, num2)}");

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
            op = Operadores.Sumar;
            Console.WriteLine($"El resutado de la suma de {num1} + {num2} es {op(num1, num2)}");
            break;
        case 2:
            op = Operadores.Restar;
            Console.WriteLine($"El resutado de la resta de {num1} - {num2} es {op(num1, num2)}");
            break;
        default:
            Console.WriteLine($"No exite esa operación");
            break;
    }

}

void Ejercicio3()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 3 ---");
    Console.WriteLine();

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
            op = Operadores.Sumar;
            Console.WriteLine($"El resutado de la suma de {num1} + {num2} es {op(num1, num2)}");
            break;
        case 2:
            op = Operadores.Restar;
            Console.WriteLine($"El resutado de la resta de {num1} - {num2} es {op(num1, num2)}");
            break;
        case 3:
            op = Operadores.Multiplicar;
            Console.WriteLine($"El resutado de la Multiplicación es {num1} * {num2} es {op(num1, num2)}");
            break;
        default:
            Console.WriteLine($"No exite esa operación");
            break;
    }

}
void Ejercicio4()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 4 ---");
    Console.WriteLine();

    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");

    Console.WriteLine();
    Console.Write("Que Operación vas a realizar: ");
    int type = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.Write("Introduce un numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce otro numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Operacion op;

    switch (type)
    {
        case 1:
            op = Operadores.Sumar;
            Console.WriteLine($"El resutado de la suma de {num1} + {num2} es {op(num1, num2)}");
            break;
        case 2:
            op = Operadores.Restar;
            Console.WriteLine($"El resutado de la resta de {num1} - {num2} es {op(num1, num2)}");
            break;
        case 3:
            op = Operadores.Multiplicar;
            Console.WriteLine($"El resutado de la Multiplicación es {num1} * {num2} es {op(num1, num2)}");
            break;
        case 4:
            op = Operadores.Dividir;
            Console.WriteLine($"El resutado de la División es {num1} / {num2} es {op(num1, num2)}");
            break;
        default:
            Console.WriteLine($"No exite esa operación");
            break;
    }

}

void Ejercicio5()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 5 ---");
    Console.WriteLine();

    Console.Write("Introduce un numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce otro numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine("Usando Sumar:");
    Calcular(Operadores.Sumar, num1, num2);

    Console.WriteLine("Usando Restar:");
    Calcular(Operadores.Restar, num1, num2);

    Console.WriteLine("Usando Multiplicar:");
    Calcular(Operadores.Multiplicar, num1, num2);

    void Calcular(Operacion op, int num1, int num2)
    {
        Console.WriteLine($"Resultado: {op(num1, num2)}");
    }

}

void Ejercicio6()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 6 ---");
    Console.WriteLine();

    Operar operaciones = Operadores.Sumar;
    operaciones += Operadores.Restar;
    operaciones += Operadores.Multiplicar;

    Console.Write("Introduce un numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce otro numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    foreach (Operar op in operaciones.GetInvocationList()){
        
        int resultado = op(num1, num2);

        string nombre = op.Method.Name;

        Console.WriteLine($"Metodo {nombre}({num1},{num2}) Resultado: {resultado}");
    }
}
void Ejercicio7()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 7 ---");
    Console.WriteLine();

    Console.Write("Cuantos numeros vas a introducir: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[] numeros = new int[n];
    for (int i = 0; i < n; i++){
        Console.Write($"Numero {i + 1}: ");
        numeros[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();

    OperarArray operaciones = Operadores.SumarArray;
    operaciones += Operadores.MultiplicarArray;

    foreach (OperarArray op in operaciones.GetInvocationList()){
        int resultado = op(numeros);
        string nombre = op.Method.Name;
        Console.WriteLine($"Metodo {nombre} Resultado: {resultado}");
    }

}

void Ejercicio8(){
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 8 ---");
    Console.WriteLine();

    Console.Write("Introduce un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Transformar transformar = Operadores.Doblar;
    transformar += Operadores.Triplicar;
    transformar += Operadores.Cuadrado;

    foreach (Transformar trans in transformar.GetInvocationList()){
        int resultado = trans(num);
        string nombre = trans.Method.Name;
        Console.WriteLine($"Metodo {nombre}({num}) = {resultado}");
    }

}

void Ejercicio9(){
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 9 ---");
    Console.WriteLine();

    Console.Write("Introduce un numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce un numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Suma:           {EjecutarOperacion(Operadores.Sumar, num1, num2)}");
    Console.WriteLine($"Resta:          {EjecutarOperacion(Operadores.Restar, num1, num2)}");
    Console.WriteLine($"Multiplicacion: {EjecutarOperacion(Operadores.Multiplicar, num1, num2)}");

    int EjecutarOperacion(OperacionCallback op, int a, int b) => op(a, b);
}

void Ejercicio10(){
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 10 ---");
    Console.WriteLine();

    Calculo op = Operadores.RaizCuadrada;
    op += Operadores.Logaritmo;

    Console.Write("Introduce un numero: ");
    double num = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine($"Raiz cuadrada de {num}:");
    EjecutarCalculo(Operadores.RaizCuadrada, num);
    
    Console.WriteLine();
    Console.WriteLine($"Logaritmo de {num}:");
    EjecutarCalculo(Operadores.Logaritmo, num);

    void EjecutarCalculo(Calculo calc, double n){
        try{
            double resultado = calc(n);
            Console.WriteLine($"Resultado: {resultado}");
        }catch (ArgumentException ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    ;
}


public static class Operadores
{
    public static int Sumar(int a, int b) => a + b;
    public static int Restar(int a, int b) => a - b;
    public static int Multiplicar(int a, int b) => a * b;
    public static int Dividir(int a, int b) => b == 0 ? 0 : a / b;
    public static int SumarArray(int[] num){
        int rest = 0;
        foreach (int n in num) rest += n;
        return rest;
    }
    public static int MultiplicarArray(int[] num){
        int rest = 1;
        foreach (int n in num) rest *= n;
        return rest;
    }
    public static int Doblar(int n) => n * 2;
    public static int Triplicar(int n) => n * 3;
    public static int Cuadrado(int n) => n * n;
    public static double RaizCuadrada(double n) {
        if (n < 0)
            throw new ArgumentException("No se puede calcular la raiz cuadrada de un numero negativo.");
        return Math.Sqrt(n);
    }

    public static double Logaritmo(double n) {
        if (n <= 0)
            throw new ArgumentException("El logaritmo solo esta definido para numeros positivos.");
        return Math.Log(n);
    }
}


public delegate int Operacion(int a, int b);
public delegate int Operar(int a, int b);
public delegate int OperarArray(int[] array);
public delegate int Transformar(int a);
public delegate int OperacionCallback(int a, int b);
public delegate double Calculo(double n);
