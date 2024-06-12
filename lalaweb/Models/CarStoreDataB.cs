using System;
using System.Data.Entity;
using System.Linq;

namespace lalaweb.Models
{
    public class CarStoreDataB : DbContext
    {
       
        public CarStoreDataB()
            : base("CarStoreDataB")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
   
    }

}