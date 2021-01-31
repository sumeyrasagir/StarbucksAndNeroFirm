using StarbucksAndNeroFirm.Abstract;
using StarbucksAndNeroFirm.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksAndNeroFirm.Adapter
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
