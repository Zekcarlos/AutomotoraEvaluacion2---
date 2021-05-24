using System;
using System.Collections.Generic;
using System.Text;

namespace Automotora
{
    class validar
    { 
public static int readInput()
    {
        int num = 0;
        while (num == 0)
        {
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Debes Ingresar Un Número Válido.");
            }
        }
        return num;
    }
}
}
