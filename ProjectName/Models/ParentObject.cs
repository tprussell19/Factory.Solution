using System.Collections.Generic;

namespace ProjectName.Models
{
  public class ParentObject
  {
    public ParentObject()
    {
      this.ChildObjects = new HashSet<ChildObject>();
    }
    public int ParentObjectId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<ChildObject> ChildObjects { get; set; }
  }
}