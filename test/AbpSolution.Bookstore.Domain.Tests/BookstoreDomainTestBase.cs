﻿using Volo.Abp.Modularity;

namespace AbpSolution.Bookstore;

/* Inherit from this class for your domain layer tests. */
public abstract class BookstoreDomainTestBase<TStartupModule> : BookstoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
