using System.ComponentModel.DataAnnotations;

namespace budgetapp.Models
{
    public class Account {
        public int Id {get;set;}

        [Required]
        public string? Name {get;set;}
        [Required]
        public decimal Balance {get;set;}
        public List<Operation>? Operations {get;set;}
    }
}