﻿namespace Business.Utilities.Results.Abstract;

public interface IDataResult<T> : IResult
{
    T Data { get; }
}
