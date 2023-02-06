using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Dados
{
    public class Dbinitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();
        }
    }
}
