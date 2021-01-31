using StarbucksAndNeroFirm.Abstract;
using StarbucksAndNeroFirm.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksAndNeroFirm.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
