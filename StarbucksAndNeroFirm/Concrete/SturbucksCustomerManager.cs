using StarbucksAndNeroFirm.Abstract;
using StarbucksAndNeroFirm.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksAndNeroFirm.Concrete
{
    class SturbucksCustomerManager: BaseCustomerManager
    {
        private ICustomerCheckService _personCheckService;

        public SturbucksCustomerManager(ICustomerCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    }
}
