using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сourse.BD;

namespace Сourse.Classes
{
    internal class ProductClass
    {
        public static IEnumerable<Product> product { get; set; }
        public static decimal? busket { get; set; } = 0;
    }
}
