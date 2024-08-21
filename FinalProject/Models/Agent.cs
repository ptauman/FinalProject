using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FinalProject.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        public string Image { get; set; } = string.Empty;
       
        public string Nickname { get; set; } = string.Empty;
        public Location location { get; set; }
        public bool IsOnline { get; set; } = false;

    }
}
