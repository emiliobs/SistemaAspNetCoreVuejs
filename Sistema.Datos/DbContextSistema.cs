namespace Sistema.Datos
{
    using Microsoft.EntityFrameworkCore;
    using Sistema.Datos.Mapping.Almacen;
    using Sistema.Entidades.Almacen;
    public class DbContextSistema : DbContext
    {

        #region Properties
            //aqui espongo todos los datos de la entidad categoria:
        public DbSet<Categoria> Categorias { get; set; }
        #endregion

        #region Construct
        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {

        }

        #endregion

        //aqui mapeo las entidades con el modelo de dato:
        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //aqui colo todas las entidades mapeadas:
            modelBuilder.ApplyConfiguration(new CategoriaMap());


        } 
        #endregion
    }
}
