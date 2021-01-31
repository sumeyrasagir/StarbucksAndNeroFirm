using StarbucksAndNeroFirm.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksAndNeroFirm.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
