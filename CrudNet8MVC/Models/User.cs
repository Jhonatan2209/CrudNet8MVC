using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudNet8MVC.Models
{
    public class User
    {
        // Propiedades de la clase Contacto
        // Estas propiedades corresponden a las columnas de la tabla Contactos en la base de datos
        // La propiedad Id es la clave primaria de la tabla
        [Column("id")]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty; 
        [Column("dni")]
        public string DNI { get; set; } = string.Empty; 
        [Column("telefono")]
        public string Telefono { get; set; }
        [Column("correo")]
        public string Correo { get; set; } = string.Empty; 
        [Column("fecha_creacion")]
        public DateOnly FechaCreacion { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
