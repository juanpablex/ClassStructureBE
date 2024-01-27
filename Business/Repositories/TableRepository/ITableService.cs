using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.TableRepository
{
    public interface ITableService
    {
        Task<IResult> Add(Table table);
        Task<IResult> Update(Table table);
        Task<IResult> Delete(Table table);
        Task<IDataResult<List<Table>>> GetList();
        Task<IDataResult<Table>> GetById(int id);
        Task<Table> GetFirst();
    }
}
