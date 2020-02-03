using CRUD.data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.data
{
    public abstract class BaseRepository
    {
        protected ModelCRUD DataContext;
            public BaseRepository()
        {
            DataContext = new ModelCRUD();
        }
    }
}
