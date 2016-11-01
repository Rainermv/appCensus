using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCensus
{
    class Response<T>
    {
        private T _obj;
        public T obj
        {
            get { return _obj; }
        }

        public Response(T response)
        {
            this._obj = response;
        }

        public void print()
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
