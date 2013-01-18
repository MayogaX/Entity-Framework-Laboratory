using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventures_First
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureWorks2008Entities context = new AdventureWorks2008Entities();

            //Address address = new Address();
            //address.AddressLine1 = "Rua dos Bobos, 0";
            //address.AddressLine2 = "Bairro do Morais";
            //address.City = "Vinicius";
            //address.PostalCode = "00000-000";
            //address.StateProvinceID = 1;
            //address.rowguid = new Guid();
            //address.ModifiedDate = DateTime.Now;
            //context.AddToAddresses(address);

            //Address address = (from a in context.Addresses where a.AddressID == 32525 select a).First();
            //address.City = "Rio de Janeiro";

            Address address = context.Addresses.Single(a => a.AddressID == 32525);
            context.Addresses.DeleteObject(address);

            context.SaveChanges();

        }
    }
}
