using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utileria
{
    class Alumno
    {
        public String Archivo { get; set; }
        public int Estatus { get; set; }
        public String Descripcion { get; set; }
        public String FolioControl { get; set; }

        public Alumno(String archivo, int estatus, String descripcion, String folioControl) {
            this.Archivo = archivo;
            this.Estatus = estatus;
            this.Descripcion = descripcion;
            this.FolioControl = folioControl;
        }
        public Alumno() {

        }
    }
}
