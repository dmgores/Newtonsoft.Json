using System;

namespace Newtonsoft.Json.Serialization
{
    /// <summary>
    /// Contract details for a <see cref="Type"/> used by the <see cref="JsonSerializer"/>.
    /// </summary>
    public class JsonCustomNumberContract : JsonContract
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonCustomNumberContract"/> class.
        /// </summary>
        /// <param name="underlyingType">The underlying type for the contract.</param>
        public JsonCustomNumberContract(Type underlyingType)
            : base(underlyingType)
        {
            ContractType = JsonContractType.CustomNumber;
        }
    }
}
