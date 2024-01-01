using System.ComponentModel.DataAnnotations;

namespace Building_Cost_Mngt_Sys.Models.Account
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        public string Description { get; set; }
        public string Type { get; set; }

        public int Amount { get; set; }
        public String Date { get; set; }
        public String Time { get; set; } 

        public Guid project_id { get; set; }
        public Guid user_id { get; set; }
    }
}
