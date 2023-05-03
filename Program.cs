using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una clave;");
        string clave = Console.ReadLine();

        if (clave.Length <= 6)
        {
            Console.WriteLine("La clave debe tener un largo sobre los 6 caracteres;");
        }
        else
        {
            if (!Char.IsUpper(clave[0]))
            {
                Console.WriteLine("La primera letra de la clave debe ser mayúscula;");
            }
            else
            {
                bool tieneNumero = false;
                for (int i = 1; i < clave.Length; i++)
                {
                    int codigoAscii = (int)clave[i];
                    if (codigoAscii >= 48 && codigoAscii <= 57)
                    {
                        tieneNumero = true;
                        break;
                    }
                }
                if (!tieneNumero)
                {
                    Console.WriteLine("La clave debe tener un número en cualquier posición excepto la primera;");
                }
                else
                {
                    Console.WriteLine("Clave creada");
                }
            }
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
