using System;

namespace EasyLiTwo.Database.Output.DTOs
{
    public class ClientDTO
    {
        public string Guid { get; set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string SHA { get; private set; }
        public DateTime Birth { get; private set; }
        public DateTime RegDate { get; private set; }
        public int Status { get; private set; }
    }
}
