using Business.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract;

public interface IInstructorService
{
    IDataResult<List<Instructor>> GetAll();
    IDataResult<Instructor> Get(int instructorId);
    IResult Add(Instructor instructor);
    IResult Update(Instructor instructor);
    IResult Delete(Instructor instructor);
}
