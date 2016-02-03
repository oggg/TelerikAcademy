using System.Collections.Generic;

namespace Calculator.Models
{
    public static class Constants
    {
        public static readonly IList<int> Kilos = new List<int>() { (int)Kilo.Thousand, (int)Kilo.TwentyFour };
        public static readonly IList<SystemSiType> Types = new List<SystemSiType>()
            {
                new SystemSiType { Name = "Bit", Power = 0, Byte = false },
                new SystemSiType { Name = "Byte", Power = 0, Byte = true },
                new SystemSiType { Name = "Kilobit", Power = 1, Byte = false},
                new SystemSiType { Name = "Kilobyte", Power = 1, Byte = true},
                new SystemSiType { Name = "Megabit", Power = 2, Byte = false},
                new SystemSiType { Name = "Megabyte", Power = 2, Byte = true},
                new SystemSiType { Name = "Gigabit", Power = 3, Byte = false},
                new SystemSiType { Name = "Gigabyte", Power = 3, Byte = true},
                new SystemSiType { Name = "Terabit", Power = 4, Byte = false},
                new SystemSiType { Name = "Terabyte", Power = 4, Byte = true},
                new SystemSiType { Name = "Petabit", Power = 5, Byte = false},
                new SystemSiType { Name = "Petabyte", Power = 5, Byte = true},
                new SystemSiType { Name = "Exabit", Power = 6, Byte = false},
                new SystemSiType { Name = "Exabyte", Power = 6, Byte = true},
                new SystemSiType { Name = "Zettabit", Power = 7, Byte = false},
                new SystemSiType { Name = "Zettabyte", Power = 7, Byte = true},
                new SystemSiType { Name = "Yottabit", Power = 8, Byte = false},
                new SystemSiType { Name = "Yottabyte", Power = 8, Byte = true}
            };

        public static readonly InputModel TheModel = new InputModel()
        {
            Quantity = 0,
            Kilo = Kilos,
            Type = Types
        };
    }
}
