using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.OOPSample.GenericSample
{
    public class GenericSample<T> where T : BaseModel
    {

        public void Start(T entity)
        {
            Console.WriteLine(entity.Id);
        }
    }
}
