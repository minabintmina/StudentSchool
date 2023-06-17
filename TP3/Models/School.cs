using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace TP3.Models
{
    public class School
    {
        public int SchoolID { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAdress { get; set; }
        public ICollection<Student> Students { get; set; }
    }
    
}
