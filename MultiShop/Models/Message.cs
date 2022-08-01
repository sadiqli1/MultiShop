using System.Collections.Generic;
using MultiShop.Models.Base;
using MultiShop.ViewModels;

namespace MultiShop.Models
{
    public class Message:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Messag { get; set; }
    }
}
