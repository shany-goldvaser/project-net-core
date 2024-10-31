using ShanyGoldvaserProject.Entities;

namespace ShanyGoldvaserProject.Servers
{
    public class ErovServer
    {
        public List<Erov> Erov { get; set; } = new List<Erov>();
        public List<Erov> GetErov() => Erov;
        public Erov GetErovId(int id)
        {
            return Erov.Find(e => e.Id == id);

        }
        public bool PostErov(Erov e)
        {
            Erov.Add(e);
            return true;
        }
        public bool PutErov(int id, Erov e)
        {
            var index = Erov.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                Erov[index] = e;
                return true;
            }
            return false;
        }
        public bool DeleteErov(int id)
        {
            var item = Erov.Find(ev => ev.Id == id);
            if (item != null)
            {
                Erov.Remove(item);
                return true;
            }
            return false;
        }
    }
}

