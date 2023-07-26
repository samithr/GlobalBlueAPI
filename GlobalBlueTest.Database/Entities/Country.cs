using GlobalBlueTest.Database.Common;

namespace GlobalBlueTest.Database.Entities
{
    public class Country : BaseEntity
    {
        public string? Name { get; set; }
        public List<int> VatRates { get; set; } = new List<int>();
    }
}
