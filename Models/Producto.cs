namespace PC3.Models
{
    public class Producto
    {
        public int Id {get; set; }
        public string NomProducto {get;set; }
        public string Foto {get;set; }
        public string  Descripcion {get; set;}
        public string  Precio {get;set;}
        public string Nombre {get;set;}
        public string Celular {get;set;}
       
        public Categoria Categoria {get;set;}

        public int CategoriaId {get;set; }
    }

    
}