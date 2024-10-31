namespace ShanyGoldvaserProject.Entities
{
    public enum Type
    {
        City, Neighborhood,  Complex
    }
    public enum Area
    {
        North, South, Center
    }
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Type Type { get; set; }
        public Area Area { get; set; }
    }
}
