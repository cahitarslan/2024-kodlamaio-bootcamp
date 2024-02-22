using Business.Abstract;
using Business.Utilities.Consts;
using Business.Utilities.Results;
using Business.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    private readonly IValidator<Category> _validator;

    public CategoryManager(ICategoryDal categoryDal, IValidator<Category> validator)
    {
        _categoryDal = categoryDal;
        _validator = validator;
    }


    public IResult Add(Category category)
    {
        try
        {
            if (!(Validate(category).Item1).IsValid)
            {
                return new ErrorResult(Validate(category).Item2);
            }
            _categoryDal.Add(category);

            return new SuccessResult(ResultMessages.Success.CategoryAdd);

        }
        catch (Exception ex)
        {
            return new ErrorResult($"{ResultMessages.Error.CategoryAddServer} ({ex.Message})");
        }
    }

    public IResult Delete(Category category)
    {
        try
        {
            _categoryDal.Delete(category);
            return new SuccessResult(ResultMessages.Success.CategoryDelete);
        }
        catch (Exception ex)
        {
            return new ErrorResult($"{ResultMessages.Error.CategoryDeleteServer} ({ex.Message})");
        }
    }

    public IDataResult<Category> Get(int categoryId)
    {
        try
        {
            var category = _categoryDal.Get(c => c.Id == categoryId);
            if (category == null)
            {
                return new ErrorDataResult<Category>(ResultMessages.Error.CategoryNotFound);
            }
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == categoryId), ResultMessages.Success.CategoryInfoReceive);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<Category>($"{ResultMessages.Error.CategoryGetServer} ({ex.Message})");
        }
    }

    public IDataResult<List<Category>> GetAll()
    {
        try
        {
            var categories = _categoryDal.GetAll();
            if (categories == null || !categories.Any())
            {
                return new ErrorDataResult<List<Category>>(ResultMessages.Error.CategoriesNotFound);
            }
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), ResultMessages.Success.CategoriesInfoReceive);

        }
        catch (Exception ex)
        {
            return new ErrorDataResult<List<Category>>($"{ResultMessages.Error.CategoryGetAllServer} ({ex.Message})");
        }
    }

    public IResult Update(Category category)
    {
        try
        {
            var validationResult = _validator.Validate(category);
            if (!validationResult.IsValid)
            {
                var messages = string.Join(", ", validationResult.Errors.Select(error => error.ErrorMessage));
                return new ErrorResult(messages);
            }

            _categoryDal.Update(category);
            return new SuccessResult(ResultMessages.Success.CategoryUpdate);
        }
        catch (Exception ex)
        {
            return new ErrorResult($"{ResultMessages.Error.CategoryUpdateServer} ({ex.Message})");
        }
    }

    private (ValidationResult, string) Validate(Category category)
    {
        var validationResult = _validator.Validate(category);
        var messages = string.Join(", ", validationResult.Errors.Select(error => error.ErrorMessage));
        return (validationResult, messages);
    }
}
