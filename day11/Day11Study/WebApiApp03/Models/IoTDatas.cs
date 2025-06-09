using System.ComponentModel.DataAnnotations;

namespace WebApiApp03.Models
{
    public class IoTDatas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime SensingDt { get; set; }
        [Required]
        public string logId { get; set; }

        public string temp { get; set; }

        public string humid { get; set; }
    }
}
