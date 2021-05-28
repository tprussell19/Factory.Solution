using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<Machine>();
    }
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Machine> Machines { get; set; }
  }
}