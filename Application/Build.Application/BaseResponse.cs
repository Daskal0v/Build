﻿namespace Build.Application;
public class BaseResponse<T>
{
    public Guid UID { get; set; }
    public int Status { get; set; }
    public bool IsSuccess { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }
    public IList<string>? Errors { get; set; }
}

