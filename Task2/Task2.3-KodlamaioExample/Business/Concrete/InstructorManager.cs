using Business.Abstract;
using Business.Utilities.Consts;
using Business.Utilities.Results;
using Business.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;
    private readonly IValidator<Instructor> _validator;

    public InstructorManager(IInstructorDal instructorDal, IValidator<Instructor> validator)
    {
        _instructorDal = instructorDal;
        _validator = validator;
    }

    public IResult Add(Instructor instructor)
    {
        try
        {
            var validationResult = _validator.Validate(instructor);
            if (!validationResult.IsValid)
            {
                var messages = string.Join(", ", validationResult.Errors.Select(error => error.ErrorMessage));
                return new ErrorResult(messages);
            }
            _instructorDal.Add(instructor);
            return new SuccessResult(ResultMessages.Success.InstructorAdd);

        }
        catch (Exception ex)
        {
            return new ErrorResult($"{ResultMessages.Error.InstructorAddServer} ({ex.Message})");
        }
    }

    public IResult Delete(Instructor instructor)
    {
        try
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult(ResultMessages.Success.InstructorDelete);
        }
        catch (Exception ex)
        {
            return new ErrorResult($"{ResultMessages.Error.InstructorDeleteServer} ({ex.Message})");
        }
    }

    public IDataResult<Instructor> Get(int instructorId)
    {
        try
        {
            var category = _instructorDal.Get(c => c.Id == instructorId);
            if (category == null)
            {
                return new ErrorDataResult<Instructor>(ResultMessages.Error.InstructorNotFound);
            }
            return new SuccessDataResult<Instructor>(_instructorDal.Get(i => i.Id == instructorId), ResultMessages.Success.InstructorInfoReceive);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<Instructor>($"{ResultMessages.Error.InstructorGetServer} ({ex.Message})");
        }
    }

    public IDataResult<List<Instructor>> GetAll()
    {
        try
        {
            var categories = _instructorDal.GetAll();
            if (categories == null || !categories.Any())
            {
                return new ErrorDataResult<List<Instructor>>(ResultMessages.Error.InstructorsNotFound);
            }
            return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll(), ResultMessages.Success.InstructorsInfoReceive);

        }
        catch (Exception ex)
        {
            return new ErrorDataResult<List<Instructor>>($"{ResultMessages.Error.InstructorGetAllServer} ({ex.Message})");
        }
    }

    public IResult Update(Instructor instructor)
    {
        try
        {
            var validationResult = _validator.Validate(instructor);
            if (!validationResult.IsValid)
            {
                var messages = string.Join(", ", validationResult.Errors.Select(error => error.ErrorMessage));
                return new ErrorResult(messages);
            }

            _instructorDal.Update(instructor);
            return new SuccessResult(ResultMessages.Success.InstructorUpdate);
        }
        catch (Exception ex)
        {
            return new ErrorResult($"{ResultMessages.Error.InstructorUpdateServer} ({ex.Message})");
        }
    }
}
