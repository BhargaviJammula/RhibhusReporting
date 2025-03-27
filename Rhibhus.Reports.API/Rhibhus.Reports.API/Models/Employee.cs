using System.ComponentModel.DataAnnotations.Schema;

namespace Rhibhus.Reports.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }

        [NotMapped]
        public List<Address> Addresses { get; set; } = new List<Address>();
    }

    public class Address
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? ZipCode { get; set; }
        public string? Type { get; set; }
    }
}
