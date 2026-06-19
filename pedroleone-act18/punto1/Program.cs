using System;
/*1.
Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
imprimir estos datos básicos.
Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
En el programa principal (Main):
● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
muestra de información.
 */
class DispositivoEnergia
{
    private string codigoIdentificador;
    private double generacionKwh;

    public string CodigoIdentificador
    {
        get { return codigoIdentificador; }
        set { codigoIdentificador = value; }
    }

    public double GeneracionKwh
    {
        get { return generacionKwh; }
        set
        {
            if (value >= 0)
                generacionKwh = value;
            else
                generacionKwh = 0;
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("Código: " + codigoIdentificador);
        Console.WriteLine("Generación Kwh: " + generacionKwh);
    }
}

class PanelSolar : DispositivoEnergia
{
    private double areaMetros;

    public double AreaMetros
    {
        get { return areaMetros; }
        set
        {
            if (value > 0)
                areaMetros = value;
        }
    }

    public void ImprimirPanel()
    {
        Imprimir();
        Console.WriteLine("Área del panel: " + areaMetros + " m²");
    }
}

class Program
{
    static void Main()
    {
        DispositivoEnergia dispositivo = new DispositivoEnergia();

        dispositivo.CodigoIdentificador = "D100";
        dispositivo.GeneracionKwh = 500;

        Console.WriteLine("DISPOSITIVO");
        dispositivo.Imprimir();

        Console.WriteLine();

        PanelSolar panel = new PanelSolar();

        Console.Write("Ingrese código: ");
        panel.CodigoIdentificador = Console.ReadLine();

        Console.Write("Ingrese generación Kwh: ");
        panel.GeneracionKwh = double.Parse(Console.ReadLine());

        Console.Write("Ingrese área del panel: ");
        panel.AreaMetros = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("PANEL SOLAR");
        panel.ImprimirPanel();
    }
}