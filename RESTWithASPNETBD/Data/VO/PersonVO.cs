using RESTWithASPNETBD.Hypermedia;
using RESTWithASPNETBD.Hypermedia.Abstract;

namespace RESTWithASPNETBD.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        //[JsonPropertyName("name")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        //[JsonIgnore]
        public string Gender { get; set; }

        public bool Enabled { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
