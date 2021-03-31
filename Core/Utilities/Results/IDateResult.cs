namespace Core.Utilities.Results
{
    public interface IDateResult<T>:IResult
    {
        T Data { get;}
    }
}