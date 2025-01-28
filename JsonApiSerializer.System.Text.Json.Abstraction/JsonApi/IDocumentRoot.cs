namespace JsonApiSerializer.Abstraction.JsonApi
{
    public interface IDocumentRoot<TData>
    {
        TData Data { get; set; }
    }
}
