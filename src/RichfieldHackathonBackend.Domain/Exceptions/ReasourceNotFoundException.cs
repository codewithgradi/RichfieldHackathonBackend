namespace RichfieldHackathonBackend.Domain.Exceptions;

public class ReasourceNotFoundException : Exception
{
    public ReasourceNotFoundException(string message) : base(message)
    {

    }
}