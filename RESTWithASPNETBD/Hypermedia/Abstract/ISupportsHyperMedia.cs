namespace RESTWithASPNETBD.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set;  }
    }
}
