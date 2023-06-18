using ASP.NET_Lab_2.Data.Interfaces;
using ASP.NET_Lab_2.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_Lab_2.Data.Mocks
{
    public class MockClothes : IAllClothes
    {
        private readonly IClothesCategory _categoryClothes = new MockCategory();
        private readonly IClothesCompany _companyClothes = new MockCompany();
        private readonly IClothesType _typeClothes = new MockType();
        private readonly IClothesColor _colorClothes = new MockColor();

        public IEnumerable<Clothes> Clothes
        {
            get
            {
                return new List<Clothes>
                {
                    new Clothes {
                        Id = 1, 
                        Img = "/img/T-Shirt.jpg",
                        Name = "Black adidas T-shirt",
                        Description = "Manufacturer: adidas Originals\r\n"
                        + "Model: Adicolor Classics 3-Stripes Tee\r\n"
                        + "Article number: GN3495\r\n"
                        + "Material: 100% cotton\r\n"
                        + "Color: black / white",
                        CategoryId = 2, Category = _categoryClothes.AllCategories.ElementAt(1),
                        CompanyId = 1, Company = _companyClothes.AllCompanies.ElementAt(0),
                        TypeId = 1, Type = _typeClothes.AllTypes.ElementAt(0),
                        ColorId = 11, Color = _colorClothes.AllColors.ElementAt(10),
                        Price = 787,

                    },
                    new Clothes {
                        Id = 2,
                        Img = "/img/Skirt.jpg",
                        Name = "Red skirt made of dense corrugated cotton",
                        Description = "Red skirt made of dense corrugated cotton. It will look great with a blouse, and with a turtleneck, and with a sweater.\r\n"
                        + "- waistband with elastic at the back\r\n"
                        + "- no lining\r\n"
                        + "Made in Spain.",
                        CategoryId = 1, Category = _categoryClothes.AllCategories.ElementAt(0),
                        CompanyId = 6, Company = _companyClothes.AllCompanies.ElementAt(5),
                        TypeId = 9, Type = _typeClothes.AllTypes.ElementAt(8),
                        ColorId = 3, Color = _colorClothes.AllColors.ElementAt(2),
                        Price = 4200,

                    },
                    new Clothes {
                        Id = 3,
                        Img = "/img/Dress.jpg",
                        Name = "Black dress",
                        Description = "Black dress with an open back",
                        CategoryId = 3, Category = _categoryClothes.AllCategories.ElementAt(2),
                        CompanyId = 4, Company = _companyClothes.AllCompanies.ElementAt(3),
                        TypeId = 4, Type = _typeClothes.AllTypes.ElementAt(3),
                        ColorId = 11, Color = _colorClothes.AllColors.ElementAt(10),
                        Price = 51917,

                    },
                };
            }
        }

        public Clothes getObjectClothes(int clothId)
        {
            throw new System.NotImplementedException();
        }
    }
}
