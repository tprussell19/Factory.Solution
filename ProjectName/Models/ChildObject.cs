using System.Collections.Generic;

namespace ProjectName.Models
{
  public class ChildObject
  {
    public int ChildObjectId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Location { get; set; }
    public int ParentObjectId { get; set; }
    public virtual ParentObject ParentObject { get; set; }
  }
}