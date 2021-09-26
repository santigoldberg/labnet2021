using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Linq.Data;
using Tp5.Linq.Entities;

namespace Tp5.Linq.Logic
{
    public class RegionLogic : BaseLogic , IABMLogic<Region>
    {        
        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }

        public void Add(Region newRegion)
        {
            context.Region.Add(newRegion);
            context.SaveChanges();            
        }

        public void Delete(int id)
        {
            var regionAEliminar = context.Region.First(r => r.RegionID == id);
        }

        public void Update(Region region)
        {
            var regionUpdate = context.Region.First(r => r.RegionID == region.RegionID);

            regionUpdate.RegionDescription = region.RegionDescription;

            context.SaveChanges();
        }
    }
}
