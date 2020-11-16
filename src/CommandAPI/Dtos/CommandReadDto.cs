namespace CommandAPI.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        
        // Comment out the line below
        public string Platform { get; set; }
        public string CommandLine { get; set; }
    }
}