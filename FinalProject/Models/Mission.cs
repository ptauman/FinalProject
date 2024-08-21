using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FinalProject.Models
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }
        public Agent agent { get; set; }
        public Target target { get; set; }
        public TimeSpan LeftTime { get; set; } = TimeSpan.Zero;
        public TimeSpan TotalTime { get; set; } = TimeSpan.Zero;
        public string Status { get; set; } = string.Empty;

    }
}
