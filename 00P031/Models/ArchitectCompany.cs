using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00P031.Models
{
    public class ArchitectCompany : Company
    {
        public List<string> ModelsBuilt { get; private set; }

        public ArchitectCompany(string name, string phoneNo, string address) : base(name, phoneNo, address)
        {
            ModelsBuilt = new List<string>();
        }

        public void AddModels(string model)
        {
            ModelsBuilt.Add(model);
        }

        public void RemoveModel(string model)
        {
            ModelsBuilt.Remove(model);
        }
    }
}
