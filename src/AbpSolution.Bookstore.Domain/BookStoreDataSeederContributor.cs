using System;
using System.Threading.Tasks;
using AbpSolution.Bookstore.Books;
using AbpSolution.Bookstore.SaleItems;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AbpSolution.Bookstore;

public class BookstoreDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Book, Guid> _bookRepository;
    private readonly IRepository<SaleItem, Guid> _itemRepository;

    public BookstoreDataSeederContributor(
        IRepository<Book, Guid> bookRepository, 
        IRepository<SaleItem, Guid> itemRepository)
    {
        _bookRepository = bookRepository;
        _itemRepository = itemRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _bookRepository.GetCountAsync() <= 0)
        {
            await _bookRepository.InsertAsync(
                new Book
                {
                    Name = "1984",
                    Type = BookType.Dystopia,
                    PublishDate = new DateTime(1949, 6, 8),
                    Price = 19.84f
                },
                autoSave: true
            );

            await _bookRepository.InsertAsync(
                new Book
                {
                    Name = "The Hitchhiker's Guide to the Galaxy",
                    Type = BookType.ScienceFiction,
                    PublishDate = new DateTime(1995, 9, 27),
                    Price = 42.0f
                },
                autoSave: true
            );
        }

        if (await _itemRepository.GetCountAsync() <= 0)
        {
            await _itemRepository.InsertAsync(
                new SaleItem
                {
                    Name = "Item 1999",
                    Type = SaleItemType.New,
                    PublishDate = new DateTime(1999, 9, 9),
                    Price = 19.84f
                },
                autoSave: true
            );

        }
    }
}