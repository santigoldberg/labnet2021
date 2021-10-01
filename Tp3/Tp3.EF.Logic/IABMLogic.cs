using System.Collections.Generic;

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
