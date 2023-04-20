using System;
using System.Collections.Generic;

namespace EjemploApiRest.Abtractions
{
    public interface ICrud<T> 
    {
    
        T Save (T entity);
        IList<T> GetAll ();
        T GetById (int id);
        void DeleteById (int id);
    
    }
    
}
