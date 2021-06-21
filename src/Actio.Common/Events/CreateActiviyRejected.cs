namespace Actio.Common.Events
{
  public class CreateActiviyRejected : IRejectedEvent
  {
    public string Category  {get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Reason { get; }
    public string Code { get; }

    protected CreateActiviyRejected() {}

    public CreateActiviyRejected(string category,
        string name, string description,
        string reason, string code)
    {
        Category = category;
        Name = name;
        Description = description;
        Reason = reason;
        Code = code;
    }
  }
}