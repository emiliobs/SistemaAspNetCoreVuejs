using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Entidades.Almacen
{
    using System.ComponentModel.DataAnnotations;


    public class Categoria
    {
        [Column("idcategoria")]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3,ErrorMessage = "El Nombre no debe tener más de 50 caracteres, ni menos de 3 caracters")]

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("descripcion")]
        [StringLength(256)]
        public string Descripcion { get; set; }

        [Column("condicion")]
        public bool Condicion { get; set; }
    }
}
