
namespace ShanyGoldvaserProject.Entities
{
    public enum LevelErov
    {
        A = 1, B = 2, C = 3
    }
    public class Erov
    {
        public int Id { get; set; }
        public LevelErov Level { get; set; }
        public string BorderErov { get; set; }
        public bool YardErov { get; set; }
        public bool Status { get; set; }
        public int IdRav { get; set; }
        public string Message { get; set; }
        public Place City { get; set; }
        public Place TypePlace { get; set; }
    }
}
