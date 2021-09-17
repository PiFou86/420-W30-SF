using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace POOII_Module11_Paint
{
    public class CreateurTraitement
    {
        public Type Type { get; set; }
        public ITraitementImage Creer()
        {
            return (ITraitementImage)Activator.CreateInstance(this.Type);
        }

        public override string ToString()
        {
            string res = this.Type.Name;
            DescriptionAttribute da = this.Type.GetCustomAttribute<DescriptionAttribute>();

            if (da != null)
            {
                res = da.Description;
            }

            return res;
        }
    }
}
