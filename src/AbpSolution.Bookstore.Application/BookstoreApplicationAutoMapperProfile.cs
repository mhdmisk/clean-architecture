using AutoMapper;
using AbpSolution.Bookstore.Books;
using AbpSolution.Bookstore.SaleItems;

namespace AbpSolution.Bookstore;

public class BookstoreApplicationAutoMapperProfile : Profile
{
    public BookstoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<SaleItem, SaleItemDto>();
        CreateMap<CreateUpdateSaleItemDto, SaleItem>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

    }
}
