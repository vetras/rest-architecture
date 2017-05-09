using System;

namespace layeredapi.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Manufacturer Maker { get; set; }
        public int Power { get; set; }
    }
}
