using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Clothes
    {
        private string _name;
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public Clothes(string name)
        {
            _name = name;
        }
    }
}
