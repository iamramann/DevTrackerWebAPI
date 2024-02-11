using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevTrackerWebAPI.Models
{
    [Serializable]
    public class MyTask
    {
        public int Id { get; set; }

        [Column("title")]
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Column("description")]
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        [Column("associated_with")]
        public int AssociateId { get; set; }

        public Associate Associate { get; set; }

        [Column("task_type")]
        public int TaskTypeId { get; set; }

        public TaskType TaskType { get; set; }

        [Column("time_taken")]
        [Required]
        public int TimeTaken { get; set; }

    }
}
