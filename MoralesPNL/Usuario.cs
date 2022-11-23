using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralesPNL
{
    public class Usuario
    {
        
        public string Nombre { get; set; }
        public string FechaNa { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Visual { get; set; }
        public string Auditivo { get; set; }
        public string Cinestesico { get; set; }
        public string Resultado { get; set; }


        public Usuario(string nombre, string fechaNa, string correo, string celular, string fecha, string hora, string visual, string auditivo, string cinestesico, string resultado)
        {
            this.Nombre = nombre;
            this.FechaNa = fechaNa;
            this.Correo = correo;
            this.Celular = celular;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Visual = visual;
            this.Auditivo = auditivo;
            this.Cinestesico = cinestesico;
            this.Resultado = resultado;
        }

        public Usuario()
        {
        }
    }
}
