using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protype_Pattern
{
    public class CostlyOperationClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; } 
        
        public CostlyOperationClass ShallowCopy()
        {
            return (CostlyOperationClass) this.MemberwiseClone();
        }
        public CostlyOperationClass DeepCopy() 
        {
            var obj = this.MemberwiseClone() as CostlyOperationClass;
            obj.Address = new Address();
            return obj;
        }
        public override string ToString()
        {
            return $"id: {Id}\t name: {Name}\nOperation: {Address?.Street}/{Address?.City}/{Address?.Country}\n=======================================";
        }
    }
}
