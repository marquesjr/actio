using System;

namespace Actio.Common.Events
{
  public class CreateActivityRejected : IRejectedEvent
  {
    public Guid Id  {get; set; }
    public string Reason { get; }
    public string Code { get; }

    protected CreateActivityRejected() {}

    public CreateActivityRejected(Guid id,
      string code, string reason)
    {
      Id = id;
      Code = code;
      Reason = reason;
    }
  }
}