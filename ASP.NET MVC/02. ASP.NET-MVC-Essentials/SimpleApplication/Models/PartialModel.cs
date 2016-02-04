using System.Collections.Generic;

namespace SimpleApplication.Models
{
    public partial class PartialModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public partial class PartialModel
    {
        public List<PartialModel> partialModel { get; set; }
    }
}
