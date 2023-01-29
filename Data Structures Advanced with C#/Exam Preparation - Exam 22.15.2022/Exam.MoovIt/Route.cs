using System.Collections.Generic;

namespace Exam.MoovIt
{
    public class Route
    {
        public Route(string id, double distance, int popularity, bool isFavorite, List<string> locationPoints)
        {
            this.Id = id;
            this.Distance = distance;
            this.Popularity = popularity;
            this.IsFavorite = isFavorite;
            this.LocationPoints = locationPoints;
        }
        public string Id { get; set; }

        public double Distance { get; }

        public int Popularity { get; set; }

        public bool IsFavorite { get; set; }

        public List<string> LocationPoints { get; } = new List<string>();

        public override bool Equals(object obj)
        {
            var route = obj as Route;
            if (route == null) return false;
            return route.Distance == this.Distance &&
                   route.LocationPoints[0] == this.LocationPoints[0] &&
                   route.LocationPoints[this.LocationPoints.Count - 1] == this.LocationPoints[this.LocationPoints.Count - 1];
        }

        public override int GetHashCode()
        {
            return this.Distance.GetHashCode() 
                   * this.LocationPoints.GetHashCode() 
                   * this.LocationPoints[this.LocationPoints.Count - 1].GetHashCode();
        }
    }
}
