using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
        this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int EngineerId { get; set; }
    public int Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<MachineEngineer> JoinEntities { get;}
  }
}