using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Table("tbCliente")]
   public  class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        [Required] //se especifica que el campo es requerido
        [StringLength(20)] //especifica el tamño del campo
        public string NombreCliente { get; set; }
        [Required] //se especifica que el campo es requerido
        [StringLength(5)] //especifica el tamño del campo
        public string User { get; set; }
        public int IdTipoDocumento { get; set; }

    }
}
