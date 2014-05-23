using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Serialization
{

    /// <summary>
    /// Converts the json number into an IJsonNumber
    /// </summary>
    /// <param name="s">a json number</param>
    /// <returns>a .net object that represents the json number</returns>
    public delegate IJsonNumber JsonNumberDeserialize(string s);

    /// <summary>
    /// A .net object that represents a json number. Must have at least one of the two following public static methods:
    /// IJsonNumber JsonNumberDeserialize(string s);
    /// YourClass Parse(string s); // where YourClass : IJsonNumber.
    /// Not implementing the former (JsonNumberDeserialize) will result in using reflection on every deserialization.
    /// </summary>
    public interface IJsonNumber
    {
        /// <summary>
        /// returns a json number
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}
