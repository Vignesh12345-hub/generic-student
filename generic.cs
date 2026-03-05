using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_stu
{
    using System;
    using System.Collections.Generic;

    class Repository<TKey, TValue>
    {
        Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();

        public void Add(TKey key, TValue value)
        {
            if (data.ContainsKey(key))
                throw new InvalidNameException("name already exists");

            data.Add(key, value);
        }

        public IEnumerable<TValue> GetAll()
        {
            return data.Values;
        }

        public TValue GetById(TKey key)
        {
            if (!data.ContainsKey(key))
                throw new Exception("Id not found");

            return data[key];
        }

        public void Delete(TKey key)
        {
            if (!data.ContainsKey(key))
                throw new Exception("Id not found");

            data.Remove(key);
            Console.WriteLine("Record Deleted");
        }
    }
}
