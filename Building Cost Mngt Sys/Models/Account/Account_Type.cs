using System.ComponentModel.DataAnnotations;

namespace building_cost_managment_system.Models.Account
{
    public class Account_Type
    {
        [Key]
        public int Type_Id { get; set; }
        public string Type_Name { get; set; }
    }
}
