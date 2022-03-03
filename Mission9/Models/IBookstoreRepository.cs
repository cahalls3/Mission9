using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
