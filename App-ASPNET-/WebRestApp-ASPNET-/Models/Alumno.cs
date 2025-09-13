using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebRestApp_ASPNET_.Models
{
    [Table("alumnos")]
    public class Alumno
    {
        
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [Column("nombre")]
        public string? Name { get; set; }
        [Range(0, 100)]
        [Column("edad")]
        public int Age {  get; set; }
    }
}
