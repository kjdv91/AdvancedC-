using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program01_01
{
    public interface IOperacion
    {
        decimal Suma(decimal a, decimal b);
        int Resta(int a, int b);
        int Multiplicacion(int a, int b);
        decimal Division(decimal a, decimal b);
    }
}
