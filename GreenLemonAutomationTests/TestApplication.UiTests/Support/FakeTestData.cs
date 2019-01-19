using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Support
{
    public class FakeTestData
    {
        [Test]

        public void FakerTestDataGenerator()
        {
            string fullName = Faker.Name.FullName();
            string firstName = Faker.Name.First();
            string lastName = Faker.Name.Last();
            string address = Faker.Address.City();
            string phoneNumber = Faker.Phone.Number();
            string email = Faker.Internet.Email();

            Console.WriteLine("The FullName is: " + fullName);
            Console.WriteLine("The FirstName is: " + firstName);
            Console.WriteLine("The LastName is: " + lastName);
            Console.WriteLine("The Address is: " + address);
            Console.WriteLine("The Email is: " + email);
            Console.WriteLine("The PhoneNumber is: " + fullName);

        }

    }
}
