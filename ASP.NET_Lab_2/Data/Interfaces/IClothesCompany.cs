using ASP.NET_Lab_2.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_2.Data.Interfaces
{
    public interface IClothesCompany
    {
        IEnumerable<Company> AllCompanies { get; }
    }
}
