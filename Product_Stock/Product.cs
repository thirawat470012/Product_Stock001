using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Stock
{
    internal class Product
    {
        private string _idPd;
        private string _namePd;
        private string _categoryPd;
        private double _pricePd;
        private int _quantityPd;

        public string IdPd
        {
            get { return _idPd; }
            set { _idPd = value; }
        }

        public string NamePd
        {
            get { return _namePd; }
            set { _namePd = value; }
        }

        public string CategoryPd
        {
            get { return _categoryPd; }
            set { _categoryPd = value; }
        }

        public double PricePd
        {
            get { return _pricePd; }
            set { _pricePd = value; }
        }

        public int QuantityPd
        {
            get { return _quantityPd; }
            set { _quantityPd = value; }
        }
    }
}
