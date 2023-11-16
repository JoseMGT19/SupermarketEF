using SupermarketEF.Data;
using SupermarketEF.Models;

namespace SupermarketEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SupermaerketContext context = new SupermaerketContext();
            //se crea el objeto oilcategory de tipo category
            Category oilCategory = new Category()
            {
                Name = "Oil",
                Description = "Oil Category"
            };
            //Se agrega el objeto creado al contexto de la BD 
            //Usando la propieda Categories del Contexto
            context.Categories.Add(oilCategory);
            //Se crea el objeto grainsCategory de tipo Category
            Category grainsCategory = new Category()
            {
                Name= "Grains",
                Description = "Grains Category"
            };
            //Se agrega el objeto creado al contexto de la BD
            //context.Add(grainsCategory);
            //Se graban los cambios realizados al contexto
            //context.SaveChanges();
            
            //Recupera todas las categorias y las ordena por el nombre
            var grainCategory = context.Categories
                .Where(p=>p.Name == "Grains")
                .FirstOrDefault();
            if(grainsCategory is Category)
            {
                grainCategory.Description = "New description applied";
                context.SaveChanges();
            }
            

            var categories = context.Categories.OrderBy(p=> p.Name );
            foreach ( var category in categories )
            {
                Console.WriteLine($"{category.Name} | {category.Description}");
            }

		}
    }
}