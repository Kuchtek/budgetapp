using System.ComponentModel.DataAnnotations;

namespace budgetapp.Models 
{
    public class Operation 
    {
        public int Id {get;set;}
        [Required]
        public Bucket? Bucket {get;set;}
        [Required]
        public decimal Value {get;set;}

        public TransactionType TransactionType {get;set;}

        public Account? AccountSource {get;set;}

        public Account? AccountDestination {get;set;}
    }
}