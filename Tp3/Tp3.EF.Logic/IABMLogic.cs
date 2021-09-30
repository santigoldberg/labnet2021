using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp7.Entities;

namespace Tp7.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newT);
        void Delete(int id);
        void Update(T t);

        int MaxID();

    }
}
