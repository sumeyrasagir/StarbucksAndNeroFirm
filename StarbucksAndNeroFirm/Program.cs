using StarbucksAndNeroFirm.Abstract;
using StarbucksAndNeroFirm.Adapter;
using StarbucksAndNeroFirm.Concrete;
using StarbucksAndNeroFirm.Entities;
using System;

namespace StarbucksAndNeroFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = 1999, FirstName = "Sümeyra", LastName = "Sağır", NationalityId = 20604260072 }); //Yanlış bilgi gönderdiğim için Exceptiona gidecek !!
            Console.ReadLine();
        }
    }
}
