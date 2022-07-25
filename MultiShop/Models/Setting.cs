using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Setting:BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
