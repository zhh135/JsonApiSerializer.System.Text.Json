namespace JsonApiSerializer.Abstraction.JsonApi
{
    public interface IResourceIdentifier<TResourceObject>
    {
        TResourceObject Value { get; set; }
    }
}
