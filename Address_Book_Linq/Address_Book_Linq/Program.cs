using System;

namespace AddressBookLinq;

class Program
{
    public static void Main(string[] args)
    {
        List<Address> listperson = new List<Address>()
        {
            new Address() { EmpId = 1, empFirstName = "Pawan", empLastName = "Yadav", Adress = "Gopal NAgar Durga MAndir", city = "Asansol", state="West Bengal", Zip="713340", email="niravpandit0002@gmail.com" },
            new Address() { EmpId = 2, empFirstName = "Premwa", empLastName = "Giri", Adress = "Claifornia 223", city = "Calfornia", state = "Continant", Zip = "713340", email = "David johon@gmail.com" },
            new Address() { EmpId = 3, empFirstName = "Anand", empLastName = "Priyadarshi", Adress = "kaloplis", city = "PDosidon", state = "Temple of Zeus", Zip = "713340", email = "Kassandra0002@gmail.com" },
            new Address() { EmpId = 4, empFirstName = "Piyush", empLastName = "varshney", Adress = "Giza", city = "Egypt", state = "mishr", Zip = "713340", email = "BAyek@gmail.com" }


        };

        foreach (var list in listperson)
        {
            Console.WriteLine("EmpId" + list.EmpId + "empFirstName:" + list.empFirstName);
        }

        //UC3 Adding New Contacts

        listperson.Add(new Address() { EmpId = 1, empFirstName = "Vis", empLastName = "akaha", Adress = "Gopal NAgar Durga MAndir", city = "Asansol", state = "West Bengal", Zip = "713340", email = "niravpandit0002@gmail.com", contact = 775667 });
        listperson.Add(new Address() { EmpId = 1, empFirstName = "Vishal", empLastName = "Dute", Adress = "", city = "Mahara", state = "Maharasrtra", Zip = "2213", email = "vishalDute@gmail.com", contact = 775667 });

        foreach (var list in listperson)
        {
            Console.WriteLine("EmpId" + list.EmpId + "empFirstName:" + list.empFirstName + "LatName" + list.empLastName);
        }



        //UC5
        //listperson.Remove(new Adress() { EmpId = 1, empFirstName = "Vis", empLastName = "akaha", Address = "Gopal NAgar Durga MAndir", city = "Asansol", state = "West Bengal", Zip = "713340", email = "niravpandit0002@gmail.com", contact = 775667 });


        MAnagmentAda m = new MAnagmentAda();

        m.Retrive(listperson);
        m.Size(listperson);
        m.Alpha(listperson);
        m.RetriveContact(listperson);


    }
}