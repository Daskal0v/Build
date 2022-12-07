namespace Build.Shared.Communication;
public abstract class BaseResponse<T>
{
  public int Status { get; set; }
  public bool IsSuccess { get; set; }
  public string? Message { get; set; }
  public T? Data { get; set; }
  public IList<string>? Errors { get; set; }
}

