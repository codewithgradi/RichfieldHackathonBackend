public record ChatResponseDto(
    bool Success,
    string? Reply,
    string? Error
);
public record ChatRequestDto(string Message);