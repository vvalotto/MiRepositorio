using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploFactoria1
{
    public class Namer
    {
        //parts stored here
        protected string frName, lName;
        //return first name
        public string getFrname()
        {
            return frName;
        }
        //return last name
        public string getLname()
        {
            return lName;
        }
    }

    public class FirstFirst : Namer
    {
        public FirstFirst(string name)
        {
            int i = name.Trim().IndexOf(" ");
            if (i > 0)
            {
                frName = name.Substring(0, i).Trim();
                lName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                frName = "";
            }
        }
    }

    public class LastFirst : Namer
    {
        public LastFirst(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
            {
                lName = name.Substring(0, i);
                frName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                frName = "";
            }
        }
    }

    public class NameFactory 
    {
        public NameFactory() {}
        public Namer getName(string name) 
        {
            int i = name.IndexOf (",");
            if(i > 0)
            return new LastFirst (name);
            else
            return new FirstFirst(name);
        }
    }
}
