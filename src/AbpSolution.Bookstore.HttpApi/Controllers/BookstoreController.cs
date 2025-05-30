﻿using AbpSolution.Bookstore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpSolution.Bookstore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookstoreController : AbpControllerBase
{
    protected BookstoreController()
    {
        LocalizationResource = typeof(BookstoreResource);
    }
}
