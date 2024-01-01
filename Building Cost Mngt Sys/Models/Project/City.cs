using System.ComponentModel.DataAnnotations;

namespace Building_Cost_Mngt_Sys.Models.Project
{
    public class City
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public State State { get; set; }

    }
}
