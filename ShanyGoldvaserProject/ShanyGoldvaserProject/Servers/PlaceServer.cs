using ShanyGoldvaserProject.Entities;

namespace ShanyGoldvaserProject.Servers
{
    public class PlaceServer
    {
        public List<Place> Place { get; set; } = new List<Place>();
        public List<Place> GetPlace() => Place;
        public Place GetPlaceId(int id)
        {
            return Place.Find(e => e.Id == id);

        }
        public bool PostPlace(Place e)
        {
            Place.Add(e);
            return true;
        }
        public bool PutPlace(int id, Place e)
        {
            var index = Place.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                Place[index] = e;
                return true;
            }
            return false;
        }
        public bool DeletePlace(int id)
        {
            var item = Place.Find(ev => ev.Id == id);
            if (item != null)
            {
                Place.Remove(item);
                return true;
            }
            return false;
        }
    }
}

