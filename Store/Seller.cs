using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Seller
    {
        private string _sellerName;

        public string SellerName
        {
            get => _sellerName;
            private set => _sellerName = value;
        }
        public Seller(string sellerName)
        {
            _sellerName = sellerName;
        }
    }
}
