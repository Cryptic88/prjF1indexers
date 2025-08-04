using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjF1indexers
{
    public class cats
    {
        int id;
        string Name, type;

        public cats(int id, string name, string type)
        {
            this.id = id;
            this.Name = Name;
            this.type = type;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.id;
                else if (index == 1)
                    return this.Name;
                else if (index == 2)
                    return this.type;
                return null;
            }

            set
            {
                if (index == 0)
                    this.id = (int)value;
                else if (index == 1)
                    this.Name = (string)value;
                else if (index == 2)
                    this.type = (string)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName == "ID Number")
                    return this.id;
                else if (attrName == "Cat Name")
                    return this.Name;
                else if (attrName == "Type of cat")
                    return this.type;
                return null;
            }

            set
            {
                if (attrName.ToLower().Equals("ID Number"))
                    this.id = (int)value;
                else if (attrName.ToLower().Equals("Cat Name"))
                    this.Name = (string)value;
                else if (attrName.ToLower().Equals("name"))
                    this.type = (string)value;
            }
        }
    }
}
