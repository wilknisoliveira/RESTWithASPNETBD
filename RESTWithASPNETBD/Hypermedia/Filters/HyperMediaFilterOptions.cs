using RESTWithASPNETBD.Hypermedia.Abstract;

namespace RESTWithASPNETBD.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
