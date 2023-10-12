namespace RESTWithASPNETBD.Data.Converter.Contract
{
    //Origing - Destiny
    public interface IParser<O, D>
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
