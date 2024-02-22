using Business.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICourseService
{
    IDataResult<List<Course>> GetAll();
    IDataResult<Course> Get(int courseId);
    IResult Add(Course course);
    IResult Update(Course course);
    IResult Delete(Course course);
}
