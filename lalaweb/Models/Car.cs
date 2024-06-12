using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lalaweb.Models
{
    public class Car
    {
        public int ID { get; set; }

        public String Maker { get; set; }

        public String Model { get; set; }

        public int Year { get; set; }

        public Type CType { get; set; }

        public String CImage { get; set; }

        public float Price { get; set; }

        public bool CAvailable { get; set; }
    }

    public enum Type
    {
        Normal,
        Family,
        Sport
    }
}