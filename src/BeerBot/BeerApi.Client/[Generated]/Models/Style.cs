// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BeerBot.BeerApi.Client.Models
{
    using BeerBot.BeerApi;
    using BeerBot.BeerApi.Client;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Style
    {
        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style(int? id = default(int?), int? categoryId = default(int?), string name = default(string))
        {
            Id = id;
            CategoryId = categoryId;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "categoryId")]
        public int? CategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
