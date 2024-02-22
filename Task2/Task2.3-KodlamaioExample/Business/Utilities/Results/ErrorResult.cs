using Business.Utilities.Results.Concrete;

namespace Business.Utilities.Results;

public class ErrorResult : Result
{
    public ErrorResult() : base(false)
    {
    }

    public ErrorResult(string message) : base(false, message)
    {
    }
}
