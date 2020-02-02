using System.Collections.Generic;

namespace Swashbuckle.HeaderParameter.Extension
{
    public class ApiConfig
    {
        public IEnumerable<IHeaderParameter> HeaderParameters { get; set; } = new List<IHeaderParameter>();
    }
}
