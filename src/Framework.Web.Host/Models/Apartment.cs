using System.ComponentModel.DataAnnotations;

namespace Framework.Web.Models
{
    public class Apartment
    {
        [Key]
        public string ApartmentId { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public int AmountOfPeople { get; set; }
        public int AmountOfRooms { get; set; }
        public string BuildingId { get; set; }
        public int Floor { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
    }
}
