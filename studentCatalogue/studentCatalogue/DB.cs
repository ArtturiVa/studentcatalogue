using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace studentCatalogue
{
    
    public class Student
    {
        
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Email { get; set; }
       
        public string? Phone { get; set; }
        

    }
}
