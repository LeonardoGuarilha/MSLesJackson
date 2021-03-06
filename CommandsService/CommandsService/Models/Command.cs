namespace CommandsService.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string CommandLine { get; set; }
        
        // FK para platform
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}