using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleMaps;


namespace Fooli.Models
{
  public class ListItem
  {
    public string LocationName { get; set; }
    public double? LocationStarRating { get; set; }
    public int? LocationPriceLevel { get; set; }
    public string LocationAddress { get; set; }
    public LatLng LocationLatLng { get; set; }
    public string LocationImage { get; set; }
    public string Notes { get; set; }
    public DateTime DateAdded { get; set; }
  }
}