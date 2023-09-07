using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pruebaruta;
public class Route {

    public static void MostEfficientRoute(List<(float, float)> destinations, (float, float) origin, ref List<(float, float)> storage) {
        if (destinations.Count == 0) return;
        float? minDistance = null;
        (float, float) result = origin;
        foreach (var dest in destinations) {
            var sideX = (float) Math.Abs(dest.Item1 - origin.Item1);
            var sideY = (float) Math.Abs(dest.Item2 - origin.Item2);
            var distance = (float) Math.Sqrt(Math.Pow(sideX,2) + Math.Pow(sideY,2));
            if (distance < minDistance || minDistance == null) {
                minDistance = distance;
                result = dest;
            }
        }
        storage.Add(result);
        destinations.Remove(result);
        MostEfficientRoute(destinations, result, ref storage);
    }

}