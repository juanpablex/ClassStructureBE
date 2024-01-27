using Business.Aspects.Secured;
using Business.Repositories.FieldRepository.Constants;
using Business.Repositories.FieldRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.FieldRepository;
using Entities.Concrete;

namespace Business.Repositories.FieldRepository
{
    public class FieldManager : IFieldService
    {
        private readonly IFieldDal _fieldDal;
        public FieldManager(IFieldDal fieldDal)
        {
            _fieldDal = fieldDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(FieldValidator))]
        [RemoveCacheAspect("IFieldService.Get")]
        public async Task<IResult> Add(Field field)
        {
            await _fieldDal.Add(field);
            return new SuccessResult(FieldMessages.AddedField);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IFieldService.Get")]
        public async Task<IResult> Delete(Field field)
        {
            await _fieldDal.Delete(field);
            return new SuccessResult(FieldMessages.DeletedField);
        }

        public async Task<IDataResult<Field>> GetById(int id)
        {
            return new SuccessDataResult<Field>(await _fieldDal.Get(p => p.Id == id));
        }

        public async Task<Field> GetFirst()
        {
            return await _fieldDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Field>>> GetList()
        {
            return new SuccessDataResult<List<Field>>(await _fieldDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(FieldValidator))]
        [RemoveCacheAspect("IFieldService.Get")]
        public async Task<IResult> Update(Field field)
        {
            await _fieldDal.Update(field);
            return new SuccessResult(FieldMessages.UpdatedField);
        }
    }
}
