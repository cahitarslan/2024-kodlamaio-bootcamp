using Business.Abstract;
using Business.Utilities.Consts;
using Business.Utilities.Results;
using Business.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;
    private readonly IValidator<Course> _validator;

    public CourseManager(ICourseDal courseDal, IValidator<Course> validator)
    {
        _courseDal = courseDal;
        _validator = validator;
    }

    public IResult Add(Course course)
    {
        try
        {
            var validationResult = _validator.Validate(course);
            if (!validationResult.IsValid)
            {
                var messages = string.Join(", ", validationResult.Errors.Select(error => error.ErrorMessage));
                return new ErrorResult(messages);
            }
            _courseDal.Add(course);
            return new SuccessResult(ResultMessages.Success.CourseAdd);

        }
        catch (Exception ex)
        {
            return new ErrorResult($"{ResultMessages.Error.CourseAddServer} ({ex.Message})");
        }
    }

    public IResult Delete(Course course)
    {
        try
        {
            _courseDal.Delete(course);
            return new SuccessResult(ResultMessages.Success.CourseDelete);
        }
        catch (Exception ex)
        {
            return new ErrorResult($"{ResultMessages.Error.CourseDeleteServer} ({ex.Message})");
        }
    }

    public IDataResult<Course> Get(int courseId)
    {
        try
        {
            var course = _courseDal.Get(c => c.Id == courseId);
            if (course == null)
            {
                return new ErrorDataResult<Course>(ResultMessages.Error.CourseNotFound);
            }
            return new SuccessDataResult<Course>(_courseDal.Get(i => i.Id == courseId), ResultMessages.Success.CourseInfoReceive);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<Course>($"{ResultMessages.Error.CourseGetServer} ({ex.Message})");
        }
    }

    public IDataResult<List<Course>> GetAll()
    {
        try
        {
            var courses = _courseDal.GetAll();
            if (courses == null || !courses.Any())
            {
                return new ErrorDataResult<List<Course>>(ResultMessages.Error.CoursesNotFound);
            }
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), ResultMessages.Success.CoursesInfoReceive);

        }
        catch (Exception ex)
        {
            return new ErrorDataResult<List<Course>>($"{ResultMessages.Error.CourseGetAllServer} ({ex.Message})");
        }
    }

    public IResult Update(Course course)
    {
        try
        {
            var validationResult = _validator.Validate(course);
            if (!validationResult.IsValid)
            {
                var messages = string.Join(", ", validationResult.Errors.Select(error => error.ErrorMessage));
                return new ErrorResult(messages);
            }

            _courseDal.Update(course);
            return new SuccessResult(ResultMessages.Success.CourseUpdate);
        }
        catch (Exception ex)
        {
            return new ErrorResult($"{ResultMessages.Error.CourseUpdateServer} ({ex.Message})");
        }
    }
}
