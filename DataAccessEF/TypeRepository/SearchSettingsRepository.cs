using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class SearchSettingsRepository : GenericRepository<SearchSetting>, ISearchSettingsRepository
    {
        public SearchSettingsRepository(DataContext dataContext) : base(dataContext) { }
    }
}
