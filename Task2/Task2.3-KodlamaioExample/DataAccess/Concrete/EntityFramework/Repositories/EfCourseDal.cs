﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Repositories;

public class EfCourseDal : EfEntityRepositoryBase<Course, KodlamaioContext>, ICourseDal
{
}
