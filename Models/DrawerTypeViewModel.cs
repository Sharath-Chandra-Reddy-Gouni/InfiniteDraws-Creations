using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace InfiniteDraws_Creations.Models
{
    public class DrawerTypeViewModel
    {
        public List<Drawer>? Drawers { get; set; }
        public SelectList? Types { get; set; }
        public string? DrawerType { get; set; }
        public string? SearchString { get; set; }
    }
}
