using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasLinQ
{
    public enum Departamento
    {
        RH = 201,
        Desarrollo = 520,
        Soporte= 402,
        Admin = 309
    }
    class Empleado
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Departamento Departamento { get; set; }

    }
}
