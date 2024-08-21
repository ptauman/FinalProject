using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FinalProject.Models
{
    public class Target
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;      
        public Location location { get; set; }
        public bool IsAlive { get; set; }
       
    }
}
