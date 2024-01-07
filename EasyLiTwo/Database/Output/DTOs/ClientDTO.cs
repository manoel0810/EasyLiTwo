using System;

namespace EasyLiTwo.Database.Output.DTOs
{
    public class ClientDTO
    {
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string SHA { get; set; }
        public DateTime Birth { get; set; }
        public DateTime RegDate { get; set; }
        public int Status { get; set; }
    }
}
