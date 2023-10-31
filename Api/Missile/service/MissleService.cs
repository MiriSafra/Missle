using Missile.model;
namespace Missile.service
{
    public class MissleService
    {
        public MissleService()
        {

        }
        //מחזיר את מערך הטילים
        public IEnumerable<Missle> GetData()
        {
            return Data.data;
        }
        public bool add(Missle m)
        {
            Data.data.Add(m);
            return true;
        }
        //החזרת טילים לפי מיקום
        public IEnumerable<Missle> GetDataByCity(string city)
        {
            return Data.data.Where(t => t.Location.City == city).ToList();
        }
        //כל הערים שנפלו בהם טילים
        public IEnumerable<string> GetCities()
        {
            return Data.data.Select(x => x.Location.City).ToList();

        }

    }
}
