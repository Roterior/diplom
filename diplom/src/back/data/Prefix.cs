using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.data
{
    public enum Prefix
    {
        [Description("ИНН: ")]
        INN,
        [Description("Телефон: ")]
        PHONE,
        [Description("Адрес: ")]
        ADDRESS,
        [Description("Имя: ")]
        FNAME,
        [Description("Отчество: ")]
        MNAME,
        [Description("Фамилия: ")]
        LNAME
    }

    public static class PrefixValue
    {
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
    }
}
