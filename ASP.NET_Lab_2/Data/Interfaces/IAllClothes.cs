using ASP.NET_Lab_2.Data.Models;
using System.Collections.Generic;

namespace ASP.NET_Lab_2.Data.Interfaces
{
    public interface IAllClothes
    {
        IEnumerable<Clothes> Clothes { get; }
        Clothes getObjectClothes(int clothId);
    }
}
