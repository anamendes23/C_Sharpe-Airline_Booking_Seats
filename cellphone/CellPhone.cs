using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cellphone
{
    public class CellPhone
    {
        //fields
        private string _brand;
        private string _carrier;
        private decimal _price; //monthly payment
        private string _plan;
        private string _phoneNumber;
        //constructor
        public CellPhone(string brand, string carrier, decimal price, string plan, string phoneNumber)
        {
            _brand = brand;
            _carrier = carrier;
            _price = price;
            _plan = plan;
            _phoneNumber = phoneNumber;
        }
        //properties
        public string Brand
        { get { return _brand; } }
        public string Carrier
        { get { return _carrier; } }
        public decimal Price
        { get { return _price; } }
        public string Plan
        {
            get { return _plan; }
            set { _plan = value; }
        }
        private string PhoneNumber
        { get { return _phoneNumber; } }
        //methods
    }
}
