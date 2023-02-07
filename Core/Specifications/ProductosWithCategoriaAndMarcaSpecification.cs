using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductosWithCategoriaAndMarcaSpecification : BaseSpecification<Producto>
    {
        public ProductosWithCategoriaAndMarcaSpecification()
        {
            AddInclude(p => p.Categoria);
            AddInclude(p => p.Marca);
        }

        public ProductosWithCategoriaAndMarcaSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(p => p.Categoria);
            AddInclude(p => p.Marca);
        }
    }
}
