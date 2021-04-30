using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;


namespace OOD_ProjectShells
{
    
    public class Components
    {
        [Key]
             public string Component { get; set; }

        public override string ToString()
        {
            return Component;
        }
       

    }
    public class ComponentsData : DbContext
    {
        public ComponentsData() : base("MyComponentsData") { }
        public DbSet<Components> Components { get; set; }

      
    }
        
    
}
