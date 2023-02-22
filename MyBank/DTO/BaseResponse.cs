namespace MyBank.DTO;

public record BaseResponse<T>(bool IsSucceed, string meessage, T Data);
public record BaseResponse(bool IsSucceed, string meessage);
