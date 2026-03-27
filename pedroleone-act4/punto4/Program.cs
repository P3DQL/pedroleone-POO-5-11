using System;

class Program
{
    static void Main()
    {
        /*4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
          cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
          finalizar al ingresar un valor negativo en el número de cuenta.
          Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
          informe:
          a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
          que:
            Estado de la cuenta:
                ○ “Acreedor” si el saldo es &gt;0.
                ○ “Deudor” si el saldo es &lt;0.
                ○ “Nulo” si el saldo es =0.
          b) La suma total de los saldos acreedores.
         */
        int cuenta;
        double saldo;
        double totalAcreedor = 0;

        Console.Write("Número de cuenta: ");
        cuenta = Convert.ToInt32(Console.ReadLine());

        while (cuenta >= 0)
        {
            Console.Write("Saldo: ");
            saldo = Convert.ToDouble(Console.ReadLine());

            string estado;

            if (saldo > 0)
            {
                estado = "Acreedor";
                totalAcreedor += saldo;
            }
            else if (saldo < 0)
            {
                estado = "Deudor";
            }
            else
            {
                estado = "Nulo";
            }

            Console.WriteLine("Cuenta: " + cuenta + " - Estado: " + estado);

            Console.Write("Número de cuenta: ");
            cuenta = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Total acreedores: " + totalAcreedor);

        Console.ReadKey();
    }
}