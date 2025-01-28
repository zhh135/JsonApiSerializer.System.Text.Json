using System;
using System.Collections.Generic;
using System.Text;

namespace JsonApiSerializer.Abstraction.JsonApi
{
    public interface ILink
    {
        string Href { get; set; }
    }
}
