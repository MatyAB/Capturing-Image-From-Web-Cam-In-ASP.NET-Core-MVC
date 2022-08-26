using System.ComponentModel.DataAnnotations;

namespace DemoWebCam.Models
{
    public class BlackList
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
         public string blackList { get; set; }  
    }
}
