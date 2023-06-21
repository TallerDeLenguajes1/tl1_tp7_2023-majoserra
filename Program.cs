using EspacioCalculadora;

/*Calculadora dato = new Calculadora();
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
*/
//todo Ejercicio2
using Empleado_Class;
Empleado emp1 = new Empleado();
Empleado emp2 = new Empleado();
Empleado emp3 = new Empleado();

emp1.nombre = "Tadeo";
emp1.apellido = "Serra";
emp1.nacimiento = new DateTime(1997, 10, 5);
emp1.estadoCivil = 'C';
emp1.genero = 'H';
emp1.ingreso = new DateTime(2018, 11, 5);
emp1.sueldoB = 180500;
emp1.cargo = cargos.Ingeniero;

emp2.nombre = "Maria";
emp2.apellido = "Serra";
emp2.nacimiento = new DateTime(1967, 10, 5);
emp2.estadoCivil = 'S';
emp2.genero = 'M';
emp2.ingreso = new DateTime(2011, 11, 5);
emp2.sueldoB = 10500;
emp2.cargo = cargos.Especialista;

emp3.nombre = "Jacob";
emp3.apellido = "ruiz";
emp3.nacimiento = new DateTime(1995, 12, 8);
emp3.estadoCivil = 'C';
emp3.genero = 'H';
emp3.ingreso = new DateTime(2018, 10, 6);
emp3.sueldoB = 110500;
emp3.cargo = cargos.Auxiliar;

