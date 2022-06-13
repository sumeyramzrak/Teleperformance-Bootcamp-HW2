using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_2
{
    [AttributeUsage(AttributeTargets.Class)] // Table Attribute
   public class MyTableAttribute : Attribute
    {
        public string Name { get; set; }

        public MyTableAttribute(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
