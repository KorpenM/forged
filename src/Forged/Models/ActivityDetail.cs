namespace Forged.Models
{
    public class ActivityDetail
    {
        public int Id { get; set; }
        public int WorkoutSessionId { get; set; }
        public WorkoutSession? WorkoutSession { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}