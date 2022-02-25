using System;

namespace Big_Mamma_Pizzaria
{
    public class Customer
    {
        #region Instance Fields
        string _name;
        int _phoneNumber;
        string _mail;
        string _adress;
        int _idNumber;
        #endregion

        #region Constructor
        public Customer(string name, int phoneNumber, string mail, string adress, int idNumber)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _mail = mail;
            _adress = adress;
            _idNumber = idNumber;
        }
        #endregion

        #region Properties

        public string Name
        { get { return _name; } }

        public int PhoneNumber
        { get { return _phoneNumber; } }

        public string Mail 
        { get { return _mail; } }

        public string Adress
        { get { return _adress; } }

        public int IdNumber
        { get { return _idNumber; } }
        #endregion

        #region Methods
        public void PrintCustomerInfo()
        {
            Console.WriteLine($"{_name} who has the ID Number: {_idNumber}.");
            Console.WriteLine($"To see more info about this customer, press any key.");
            Console.ReadLine();
            Console.WriteLine($"Phone Number: {_phoneNumber}");
            Console.WriteLine($"Mail: {_mail}");
            Console.WriteLine($"Adress: {_adress}");
        }

        #endregion
    }
}
