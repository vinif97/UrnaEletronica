namespace UrnaEletronica.Application.Interfaces.ValidationHandler
{
    public interface IResult
    {
        bool IsSuccess { get; set; }
        IList<string> Errors { get; set; }
    }
}
