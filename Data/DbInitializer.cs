using CO550TeamProject.Models;

namespace CO550TeamProject.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any customers.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer{Name="",DateOfBirth=DateTime.Parse(""),Email="",PhoneNumber=""}
            };

            context.Customer.AddRange(customers);
            context.SaveChanges();

            var customerAddresses = new CustomerAddress[]
            {
                new CustomerAddress{HouseNumber=,HouseName="",RoadName="",PostTown="",Postcode=""}
            };

            context.CustomerAddress.AddRange(customerAddresses);
            context.SaveChanges();

            var customerPayments = new CustomerPayment[]
            {
                new CustomerPayment{CardNumber=,ExpiryMonth=,ExpiryYear=,CVVNumber=}
            };

            context.CustomerPayment.AddRange(customerPayments);
            context.SaveChanges();
        }
    }
}
