using Attributes.Reflections;
using Odev2_2;
using System.Reflection;

//ATTRIBUTE-REFLECTION KULLANIMI

var data = new Data();
PrintTableInfo();
PrintColumnInfo();


void PrintTableInfo()
{
    Attribute[] attrs1 = Attribute.GetCustomAttributes(typeof(Data));
    foreach (System.Attribute attr in attrs1)
    {
        if (attr is MyTableAttribute)
        {
            MyTableAttribute a = (MyTableAttribute)attr;
            System.Console.WriteLine("Tablo Adı:{0}", a.GetName());
        }
    }
}

void PrintColumnInfo()
{
    var i = 1;
    PropertyInfo[] props = typeof(Data).GetProperties();
    foreach (PropertyInfo prop in props)
    {
        object[] attrs = prop.GetCustomAttributes(true);
        foreach (object attr in attrs)
        {
            MyColumnAttribute a = attr as MyColumnAttribute;
            Console.WriteLine($" {i}. Kolon Adı:{a.GetName()} - ID Tipi:{a.GetIdType()} - {a.GetRequired()}");
            i++;
        }
    }
}
Console.ReadKey();