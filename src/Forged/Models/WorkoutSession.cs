using System.ComponentModel.DataAnnotations;

namespace Forged.Models
{
    public enum ActivityType
    {
        Gym,
        [Display(Name = "Home Workout")]
        HomeWorkout,
        Calisthenics,
        Running,
        Cycling,
        Yoga,
        [Display(Name = "Team Sport")]
        TeamSport,
        Tennis,
        Swimming,
        Other
    }

    public class WorkoutSession
    {
        public int Id { get; set; }
        public int UserId { get; set; } = 1;
        public User? User { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Today;
        public ActivityType? ActivityType { get; set; } = null;
        public string Notes { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<ActivityDetail> ActivityDetails { get; set; } = new List<ActivityDetail>();
    }
}