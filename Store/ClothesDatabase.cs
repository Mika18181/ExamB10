using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class ClothesDatabase
    {
        internal List<ClothesStore> Clothes { get; private set; }

        public void Initialize()
        {
            Clothes = new List<ClothesStore>
            {
                new ClothesStore(new Seller("Иван"), "Джинсы", 1500),
                new ClothesStore(new Seller("Кристина"), "Блузка", 999),
                new ClothesStore(new Seller("Илона"), "Рубашка", 10000),
                new ClothesStore(new Seller("Полина"), "Брюки", 2999),
            };
        }
    }
}
