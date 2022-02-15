using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Descripcion{ get; set; }
        public Carrera()
        {

        }
        public Carrera(int id, string nom)
        {
            Id = id;
            Descripcion = nom;
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
