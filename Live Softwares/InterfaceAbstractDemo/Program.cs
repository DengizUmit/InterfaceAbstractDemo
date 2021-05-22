using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer { DateOfBirth = new DateTime(1990, 1, 8), FirstName = "Engin", LastName = "Deniz", Id = 1, NationalityId = "99999999999" });


            Console.ReadLine();
        }
    }
}
