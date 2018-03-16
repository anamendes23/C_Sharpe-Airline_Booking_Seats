using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cellphone
{
    public class Person
    {
        //fields
        private string _firstName;
        private string _lastName;
        private List<CellPhone> _cellPhoneList = new List<CellPhone>();
        //constructor
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        //properties
        public string FirstName
        { get { return _firstName; } }
        public string LastName
        { get { return _lastName; } }
        public CellPhone[] CellPhone
        { get { return _cellPhoneList.ToArray(); } }
        //methods
        public void AddCellPhone(CellPhone cellPhone)
        {
            _cellPhoneList.Add(cellPhone);
        }
        public void RemoveCellPhone(CellPhone cellPhone)
        {
            _cellPhoneList.Remove(cellPhone);
        }
        public decimal GetTotalPayment()
        {
            decimal totalPayment = 0;
            for (int i = 0; i < _cellPhoneList.Count; i++)
            {
                totalPayment += _cellPhoneList[i].Price;
            }
            return totalPayment;
        }
    }
}
