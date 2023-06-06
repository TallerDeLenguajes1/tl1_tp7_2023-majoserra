namespace EspacioCalculadora;

public class Calculadora
{
    private double dato = 0;
    /*Cree también una propiedad llamada Resultado para obtener el valor del atributo
    dato. (Es decir solo defina el get).*/
    public double Resultado { get => dato; }


    public void Sumar(double termino)
    {
        dato += termino;
    }
    public void Restar(double termino)
    {
        dato -= termino;
    }
    public void Multiplicar(double termino)
    {
        dato *= termino;
    }
    public void Dividir(double termino)
    {
        dato /= termino;
    }
    public void Limpiar()
    {
        dato = 0;
    }
}
