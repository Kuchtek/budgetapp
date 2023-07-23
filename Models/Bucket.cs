using System.ComponentModel.DataAnnotations;

namespace budgetapp.Models
{
    public class Bucket
    {
        public int Id {get;set;}

        [Required]
        public string? Name {get;set;}

    }
}