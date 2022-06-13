
using Odev2_2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Reflections
{
    [MyTable("Students")]
    public class Data
    {
        [MyColumn("StudentID","int",true)]
        public int StudentID { get; set; }

        [MyColumn("StudentName","string",false)]
        public string StudentName { get; set; }

    }
}
