namespace Swashbuckle.HeaderParameter.Extension
{
    public class HeaderParameterAttribute : System.Attribute, IHeaderParameter
    {
        private readonly IHeaderParameter _headerParameterImplementation = new HeaderParameter();

        public bool AllowReserved
        {
            get => _headerParameterImplementation.AllowReserved;
            set => _headerParameterImplementation.AllowReserved = value;
        }

        public bool Required
        {
            get => _headerParameterImplementation.Required;
            set => _headerParameterImplementation.Required = value;
        }

        public bool AllowEmptyValue
        {
            get => _headerParameterImplementation.AllowEmptyValue;
            set => _headerParameterImplementation.AllowEmptyValue = value;
        }

        public bool Deprecated
        {
            get => _headerParameterImplementation.Deprecated;
            set => _headerParameterImplementation.Deprecated = value;
        }

        public string Name
        {
            get => _headerParameterImplementation.Name;
            set => _headerParameterImplementation.Name = value;
        }

        public string Description
        {
            get => _headerParameterImplementation.Description;
            set => _headerParameterImplementation.Description = value;
        }

        public string Example
        {
            get => _headerParameterImplementation.Example;
            set => _headerParameterImplementation.Example = value;
        }

        public bool Explode
        {
            get => _headerParameterImplementation.Explode;
            set => _headerParameterImplementation.Explode = value;
        }

        public string Type
        {
            get => _headerParameterImplementation.Type;
            set => _headerParameterImplementation.Type = value;
        }

        public string Format
        {
            get => _headerParameterImplementation.Format;
            set => _headerParameterImplementation.Format = value;
        }
    }
}
