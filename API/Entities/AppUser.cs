// using System.ComponentModel.DataAnnotations; automatically imported

namespace API.Entities
{
    public class AppUser
    {
        // [Key] command to set the primary key in a data table 
        public int Id { get; set; }
        public string Username { get; set; }
        
    }
}