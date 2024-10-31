using ShanyGoldvaserProject.Entities;

namespace ShanyGoldvaserProject.Servers
{
    public class ContributionsServer
    {
        public List<Contributions> Contributions { get; set; } = new List<Contributions>();
        public List<Contributions> GetContributions() => Contributions;
        public Contributions GetContributionsId(int id)
        {
            return Contributions.Find(e => e.Id == id);

        }
        public bool PostContributions(Contributions e)
        {
            Contributions.Add(e);
            return true;
        }
        public bool PutContributions(int id, Contributions e)
        {
            var index = Contributions.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                Contributions[index] = e;
                return true;
            }
            return false;
        }
        public bool DeleteContributions(int id)
        {
            var item = Contributions.Find(ev => ev.Id == id);
            if (item != null)
            {
                Contributions.Remove(item);
                return true;
            }
            return false;
        }
    }
}
