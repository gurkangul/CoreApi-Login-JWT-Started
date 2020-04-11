﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {

        IDataResult<Category> GetById(int productId);
        IDataResult<List<Category>> GetList();
    }
}
