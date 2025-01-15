

namespace BaseLibrary.Responses
{
    public record LoginResponse(bool Flag, string Messsage = null!, string Token = null!, string RefreshToken = null!);

}
