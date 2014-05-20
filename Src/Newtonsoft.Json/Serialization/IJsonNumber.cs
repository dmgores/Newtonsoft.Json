using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Serialization
{
    /// <summary>
    /// Represents a number that can be converted to/from a json number.  this.ToString() must return a json number.
    /// </summary>
    public interface IJsonNumber
    {
        /// <summary>
        /// Deserializes the passed in json number
        /// </summary>
        /// <param name="s">Json number</param>
        void Parse(string s);
    }
}
