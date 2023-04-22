using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class ClothesStore
    {
        private Seller _seller;
        private string _clothesName;
        private int _price;

        public string ClothesName
        {
            get => _clothesName;
        }

        private Seller Seller
        {
            get => _seller;
        }
        public int Price
        {
            get => _price;
        }

        public string SellerName
        {
            get { return Seller != null ? Seller.SellerName : "Не назначено"; }
        }

        public ClothesStore(Seller seller, string clothesName, int price)
        {

            _clothesName = clothesName;
            _seller = seller;
            _price = price;
        }
    }
}
