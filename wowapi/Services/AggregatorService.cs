using System.Linq;
using System.Threading.Tasks;
using wowapi.Contracts.Classic;
using wowapi.Contracts.Dbc;
using wowapi.Extensions;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Services
{
    public class AggregatorService : IAggregatorService
    {
        private ICRepositoryWrapper _cRepositoryWrapper;
        private IDbcRepositoryWrapper _dbcRepositoryWrapper;

        public AggregatorService(ICRepositoryWrapper cRepositoryWrapper, IDbcRepositoryWrapper dbcRepositoryWrapper)
        {
            _cRepositoryWrapper = cRepositoryWrapper;
            _dbcRepositoryWrapper = dbcRepositoryWrapper;
        }

        public async Task AggregateItemInfoAsync(CItemTemplate itemTemplate)
        {
            if (itemTemplate.Itemset != 0)
                itemTemplate.ItemSetObj =  await _dbcRepositoryWrapper.ItemSetRepo.GetItemSetAsync(itemTemplate.Itemset);

            if (itemTemplate.Displayid != 0)
            {
                var itemDisplayInfo = await _dbcRepositoryWrapper.ItemDisplayInfoRepo.GetItemDisplayInfoAsync(itemTemplate.Displayid);
                itemTemplate.Icon = !string.IsNullOrEmpty(itemDisplayInfo.Icon) ? itemDisplayInfo.Icon : itemDisplayInfo.Icon2;
            }

            var lootTemplates = await _cRepositoryWrapper.CreatureLootTemplatesRepo.GetCreatureLootTemplateByItemEntryAsync(itemTemplate.Entry);
            var lootIds = lootTemplates.Select(x => x.Entry);
            var referenceLootTemplates = await _cRepositoryWrapper.ReferenceLootTemplatesRepo.GetReferenceLootTemplatesByItemEntryAsync(itemTemplate.Entry);
            var lootTemplatesByReference = await _cRepositoryWrapper.CreatureLootTemplatesRepo.GetCreatureLootTemplatesByItemEntriesAsync(referenceLootTemplates.Select(x => x.Entry));
            lootIds = lootIds.Union(lootTemplatesByReference.Select(x => x.Entry));
            var creatureTemplates = await _cRepositoryWrapper.CreatureTemplatesRepo.GetAllCreatureTemplatesAsync(lootIds);
            
            if (creatureTemplates.Count() != 0)
                itemTemplate.DroppedBy = await PaginatedList<CCreatureTemplate>.CreateAsync(creatureTemplates, 1, 100);
        }
    }
}