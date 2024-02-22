using Business.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICategoryService
{
    IDataResult<List<Category>> GetAll();
    IDataResult<Category> Get(int categoryId);
    IResult Add(Category category);
    IResult Update(Category category);
    IResult Delete(Category category);
}
