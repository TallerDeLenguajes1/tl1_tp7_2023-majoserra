using EspacioCalculadora;

Calculadora dato = new Calculadora();
int opcion = 1, operacion;
double num;
while (opcion != 0)
{
    Console.WriteLine("\nIngrese un numero");
    double.TryParse(Console.ReadLine(), out num);
    Console.WriteLine("\nIngrese una operacion:\r\n1-Suma \r\n2-Resta \r\n3-Multiplicacion \r\n4-Division");
    int.TryParse(Console.ReadLine(), out operacion);
    switch (operacion)
    {
        case 1:
            dato.Sumar(num);
            break;
        case 2:
            dato.Restar(num);
            break;
        case 3:
            dato.Multiplicar(num);
            break;
        case 4:
            dato.Dividir(num);
            break;
    }
    Console.WriteLine("\nDesea realizar otra operacion? 1-SI 0-NO");
    int.TryParse(Console.ReadLine(), out opcion);
}
Console.WriteLine("\nEl Resultado es: " + dato.Resultado);
