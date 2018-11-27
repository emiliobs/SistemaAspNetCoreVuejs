namespace Sistema.Web.Models.Almacen.Categorias
{
    using System.ComponentModel.DataAnnotations;

    public class CrearViewModel
    {
       [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El Nombre no debe tener más de 50 caracteres, ni menos de 3 caracters")]
        public string Nombre { get; set; }    

        [StringLength(256)]
        public string Descripcion { get; set; }
    }
}
