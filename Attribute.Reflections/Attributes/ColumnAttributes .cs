using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_2
{
    [AttributeUsage(AttributeTargets.Property)] //Column Attribute
    public class MyColumnAttribute : Attribute
    {
        public string Name { get; set; }

        public string IdType { get; set; }

        public bool Required { get; set; }

        public MyColumnAttribute(string Name, string IdType, bool Required)
        {
            this.Name = Name;
            this.IdType = IdType;
            this.Required = Required;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetIdType()
        {
            return IdType;
        }

        public string GetRequired()
        {
            var result = "Not Required";
            if (Required == true)
            {
                result = "Required";
            }
            return result;
        }
    }


}
