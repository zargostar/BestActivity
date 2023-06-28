using Domain.Commen;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category:EntityBase
    {
      
        public string  Name { get; set; }
        public Collection<Product> Products { get; set; }
    }
}
