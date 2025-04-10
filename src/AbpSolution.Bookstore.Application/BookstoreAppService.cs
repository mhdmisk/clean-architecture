using AbpSolution.Bookstore.Localization;
using Volo.Abp.Application.Services;

namespace AbpSolution.Bookstore;

/* Inherit your application services from this class.
 */
public abstract class BookstoreAppService : ApplicationService
{
    protected BookstoreAppService()
    {
        LocalizationResource = typeof(BookstoreResource);
    }
}
