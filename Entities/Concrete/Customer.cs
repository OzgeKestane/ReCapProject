using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public Customer(int customerId, int userId, string companyName)
        {
            CustomerId = customerId;
            UserId = userId;
            CompanyName = companyName;
        }
        public Customer()
        {

        }

        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }

        public User? Users { get; set; } = null;
        public Rental? Rentals { get; set; } = null;
    }
}
