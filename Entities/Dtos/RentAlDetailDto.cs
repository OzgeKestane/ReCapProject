using Core.Entities;

namespace Entities.Dtos
{
    public class RentAlDetailDto : IDto
    {
        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
