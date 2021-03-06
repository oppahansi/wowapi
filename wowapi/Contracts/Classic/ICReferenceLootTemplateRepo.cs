﻿using System.Collections.Generic;
using System.Threading.Tasks;
using wowapi.Models.Db.Classic;
using wowapi.Models.Search;

namespace wowapi.Contracts.Classic
{
    public interface ICReferenceLootTemplateRepo
    {
        Task<IEnumerable<CReferenceLootTemplate>> GetReferenceLootTemplatesByEntryAsync(uint entry);
        Task<IEnumerable<CReferenceLootTemplate>> GetReferenceLootTemplatesByItemEntryAsync(uint itemEntry);
        Task<CReferenceLootTemplate> GetReferenceLootTemplateByItemEntryAsync(uint itemEntry);
    }
}
