using UrnaEletronica.Application.Interfaces.ValidationHandler;

namespace UrnaEletronica.Application.ValidationHandler
{
    public class OperationResult : IResult
    {
        public bool IsSuccess { get; set; }
        public IList<string> Errors { get; set; }

        public OperationResult()
        {
            IsSuccess = true;
            Errors = new List<string>();
        }
    }
}
