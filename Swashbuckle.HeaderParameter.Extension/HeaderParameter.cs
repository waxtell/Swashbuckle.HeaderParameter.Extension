using System;
using System.Collections.Generic;
using System.Text;

namespace Swashbuckle.HeaderParameter.Extension
{
    public class HeaderParameter : IHeaderParameter
    {
        public bool AllowReserved { get; set; } = false;
        public bool Required { get; set; } = false;
        public bool AllowEmptyValue { get; set; } = false;
        public bool Deprecated { get; set; } = false;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }
        public bool Explode { get; set; } = false;
    }
}
