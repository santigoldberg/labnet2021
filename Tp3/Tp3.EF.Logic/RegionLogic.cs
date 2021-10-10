using System;
using System.Collections.Generic;
using System.Linq;
using Tp7.Entities;

namespace Tp7.Logic
{
    public class RegionLogic : BaseLogic , IABMLogic<Region>
    {
        
        public List<Region> GetAll()
        {
            try
            {
                return context.Region.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Add(Region newregion )
        {
            try
            {
                context.Region.Add(newregion);

                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                //var regionAEliminar = context.Region.Single(r => r.RegionID == id);
                var regionAEliminar = context.Region.Find(id);
                context.Region.Remove(regionAEliminar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }

        public void Update(Region region)
        {
            try
            {
                var regionUpdate = context.Region.Find(region.RegionID);

                regionUpdate.RegionDescription = region.RegionDescription;

                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        
        }

        public int MaxID()
        {
            try
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
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
