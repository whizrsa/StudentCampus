using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCampus
{
    class Campus
    {
        public string Name { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Surbub { get; set; }

        public Campus(string name,string province,string city, string surbub)
        {
            Name = name;
            Province = province;
            City = city;
            Surbub = surbub;
        }

        public override string ToString()
        {
             return $"Name: {Name}\tProvince: {Province}\tCity: {City}\tSurbub: {Surbub}";
        }
    
    }
}
