using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class ThisKeyword
    {
        public string Name;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }        
    }
}

