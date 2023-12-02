using Newtonsoft.Json;
namespace adminUI
{
    public class Role
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonConstructor]
        public Role(string description)
        {
            Description = description;
        }
    }
}
