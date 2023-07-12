using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fooli.Models
{
  public class List
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public List<ListItem> Items { get; set; }
  }

}