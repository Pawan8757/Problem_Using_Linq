using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class MAnagmentAda
    {




        //UC6

        public void Retrive(List<Address> listpe)
        {
            var RecordData3 = listpe.GroupBy(x => x.city).Select(x => new { city = x.Key });

            foreach (var list in RecordData3)
            {
                Console.WriteLine("City:" + list.city);
            }
        }

        //UC7
        public void Size(List<Address> listpe)
        {
            var RecordData = listpe.GroupBy(x => x.city).Select(x => new { city = x.Key, Count = x.Count() });



            foreach (var list in RecordData)
            {
                Console.WriteLine("Product id:" + list.city + "Count" + list.Count);
            }


        }

        //UC8

        public void Alpha(List<Address> listpe)
        {
            var RecordData = (from adresreviews in listpe orderby adresreviews.empFirstName descending select adresreviews);


            foreach (var list in RecordData)
            {
                Console.WriteLine("First Nmae" + list.empFirstName + "City" + list.city);
            }
        }
        //UC10

        public void RetriveContact(List<Address> listpe)
        {
            var RecordData9 = listpe.GroupBy(x => x.contact).Select(x => new { contact = x.Key });

            foreach (var list in RecordData9)
            {
                Console.WriteLine("Contact:" + list.contact);
            }
        }


    }
}
