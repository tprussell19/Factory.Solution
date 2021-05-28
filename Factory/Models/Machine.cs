using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Location { get; set; }
    public int EngineerId { get; set; }
    public virtual Engineer Engineer { get; set; }
  }
}