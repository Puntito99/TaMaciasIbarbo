using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerBackendMaciasIbarbo.models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public string NombreUsario { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public string Clave { get; set; }
        [Required]

        public bool Estado { get; set; }

        public int GeneroId { get; set; }

        public Genero Genero { get; set; }


    }

}