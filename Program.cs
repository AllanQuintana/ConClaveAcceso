using System;

class Program
{
    static void Main(string[] args)
    {
        int intentosRestantes = 3;

        while (intentosRestantes > 0)
        {
            Console.WriteLine("Ingrese una clave; ");
            string clave = Console.ReadLine();

            if (clave.Length <= 6)
            {
                Console.WriteLine("La clave debe tener un largo sobre los 6 caracteres.");
            }
            else if (!Char.IsUpper(clave[0]))
            {
                Console.WriteLine("La primera letra de la clave debe ser mayúscula.");
            }
            else
            {
                bool tieneNumero = false;
                for (int i = 1; i < clave.Length; i++)
                {
                    if (Char.IsDigit(clave[i]))
                    {
                        tieneNumero = true;
                        break;
                    }
                }
                if (!tieneNumero)
                {
                    Console.WriteLine("La clave debe tener un número en cualquier posición excepto la primera.");
                }
                else
                {
                    Console.WriteLine("Clave creada.");
                    break;
                }
            }

            intentosRestantes--;
            if (intentosRestantes > 0)
            {
                Console.WriteLine("Intentos restantes: {0}.", intentosRestantes);
            }
        }

        if (intentosRestantes == 0)
        {
            Console.WriteLine("Se han agotado los 3 intentos. Intente nuevamente más tarde.");
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
