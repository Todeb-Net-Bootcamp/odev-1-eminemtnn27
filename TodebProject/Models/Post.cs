using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodebProject.Models
{
    public class Post
    {
        [Key] 
        public int Id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string body {  get; set; }
    }
    
}
