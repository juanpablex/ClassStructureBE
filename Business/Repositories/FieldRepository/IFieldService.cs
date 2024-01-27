using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.FieldRepository
{
    public interface IFieldService
    {
        Task<IResult> Add(Field field);
        Task<IResult> Update(Field field);
        Task<IResult> Delete(Field field);
        Task<IDataResult<List<Field>>> GetList();
        Task<IDataResult<Field>> GetById(int id);
        Task<Field> GetFirst();
    }
}
