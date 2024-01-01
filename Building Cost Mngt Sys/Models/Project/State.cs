using System.ComponentModel.DataAnnotations;

namespace Building_Cost_Mngt_Sys.Models.Project
{
    public class State
    {
        [Key]
        public Guid Id { get; set; }
        public string State_Name { get; set;}
    }
}
