using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Web.Services.Product
{
    public class ProductInfoDto
    {
        public IEnumerable<BrandDto> Brands { get; set; }

        public IEnumerable<CategoryDto> Categories { get; set; }
    }
}
