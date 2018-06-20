using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Entidades
{
    public class Grupos
    {

        [Key]

        public int GrupoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int grupos1 { get; set; }
        public int Integrantes { get; set; }

        public Grupos()
        {
            GrupoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Cantidad = 0;
            grupos1 = 0;
            Integrantes = 0;
        }
    }
}
