﻿using System.Collections.Generic;
using System.Linq;
using Tp7.Entities;

namespace Tp7.Logic
{
    public class RegionLogic : BaseLogic , IABMLogic<Region>
    {
        
        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }

        public void Add(Region newregion )
        {
            context.Region.Add(newregion);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            //var regionAEliminar = context.Region.Single(r => r.RegionID == id);
            var regionAEliminar = context.Region.Find(id);
            context.Region.Remove(regionAEliminar);
            context.SaveChanges();

        }

        public void Update(Region region)
        {
            var regionUpdate = context.Region.Find(region.RegionID);

            regionUpdate.RegionDescription = region.RegionDescription;

            context.SaveChanges();
        
        }

        public int MaxID()
        {
            int maxId = 0;
            foreach (Region region in this.GetAll())
            {
                if (maxId < region.RegionID)
                {
                    maxId = region.RegionID;
                }

            }
            return maxId;

        }
    }
}
