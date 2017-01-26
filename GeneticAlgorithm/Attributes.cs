using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class DDLAttribute : Attribute
    {
        public string key;
        public string value;
        public DDLAttribute(string key, string value)
        {
            this.value = value;
            this.key = key;
        }
    }
    class StatusAttribute : Attribute
    {
        public Utilities.DevelopementStatus current;
        public StatusAttribute(Utilities.DevelopementStatus cur)
        {
            this.current = cur;
        }
    }
}
