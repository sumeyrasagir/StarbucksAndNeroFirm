using StarbucksAndNeroFirm.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksAndNeroFirm.Abstract
{
    public interface ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer);
    }

}
