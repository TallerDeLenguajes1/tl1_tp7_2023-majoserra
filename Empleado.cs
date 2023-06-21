namespace Empleado_Class;

//Apartado 1
public enum cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
class Empleado
{
    public string? nombre;
    public string? apellido;
    public DateTime nacimiento;
    public char estadoCivil;
    public char genero;
    public DateTime ingreso;
    public double sueldoB;
    public cargos cargo;

    //Apartado 2
    public int Antiguedad
    {
        get
        {
            int antiguedad = DateTime.Now.Year - ingreso.Year;
            return antiguedad;
        }
    }

    public int edad
    {
        get
        {
            int Edad = DateTime.Now.Year - nacimiento.Year;
            return Edad;
        }
    }

    public int aniosParaJubilarse
    {
        get
        {
            int anios;
            if (genero == 'M') //Entonces es Mujer
            {
                anios = 60 - edad;
            }
            else
            {
                anios = 65 - edad;
            }
            return anios;
        }
    }

    public double Salario()
    {
        double adicional = 0;
        if (Antiguedad <= 20)
        {
            adicional = sueldoB * (Antiguedad / 100);
        }
        else
        {
            adicional = sueldoB * 0.20;
        }

        if (cargo == cargos.Ingeniero || cargo == cargos.Especialista)
        {
            adicional = adicional * 1.5;
        }

        if (estadoCivil == 'c')
        {
            adicional = adicional + 15000;
        }

        return (sueldoB + adicional);
    }
}
