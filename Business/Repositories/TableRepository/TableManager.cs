using Business.Aspects.Secured;
using Business.Repositories.TableRepository.Constants;
using Business.Repositories.TableRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.TableRepository;
using Entities.Concrete;

namespace Business.Repositories.TableRepository
{
    public class TableManager : ITableService
    {
        private readonly ITableDal _tableDal;
        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(TableValidator))]
        [RemoveCacheAspect("ITableService.Get")]
        public async Task<IResult> Add(Table table)
        {
            await _tableDal.Add(table);
            return new SuccessResult(TableMessages.AddedTable);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("ITableService.Get")]
        public async Task<IResult> Delete(Table table)
        {
            await _tableDal.Delete(table);
            return new SuccessResult(TableMessages.DeletedTable);
        }

        public async Task<IDataResult<Table>> GetById(int id)
        {
            return new SuccessDataResult<Table>(await _tableDal.Get(p => p.Id == id));
        }

        public async Task<Table> GetFirst()
        {
            return await _tableDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Table>>> GetList()
        {
            return new SuccessDataResult<List<Table>>(await _tableDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(TableValidator))]
        [RemoveCacheAspect("ITableService.Get")]
        public async Task<IResult> Update(Table table)
        {
            await _tableDal.Update(table);
            return new SuccessResult(TableMessages.UpdatedTable);
        }
    }
}
