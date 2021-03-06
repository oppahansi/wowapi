﻿using LazyCache;
using wowapi.Contexts;
using wowapi.Contracts;
using wowapi.Contracts.Classic;
using wowapi.Contracts.Dbc;
using wowapi.Repositories.Classic;

namespace wowapi.Repository.Classic
{
    public class CRepositoryWrapper : ICRepositoryWrapper
    {
        private CRepositoryContext _repoContext;
        private readonly IAppCache _cache;

        private ICCreatureTemplateRepo _creatureTemplatesRepo;
        public ICCreatureTemplateRepo CreatureTemplatesRepo
        {
            get
            {
                if (_creatureTemplatesRepo == null)
                    _creatureTemplatesRepo = new CCreatureTemplateRepo(_repoContext, _cache);

                return _creatureTemplatesRepo;
            }
        }

        private ICCreatureLootTemplateRepo _creatureLootTemplatesRepo;
        public ICCreatureLootTemplateRepo CreatureLootTemplatesRepo
        {
            get
            {
                if (_creatureLootTemplatesRepo == null)
                    _creatureLootTemplatesRepo = new CCreatureLootTemplateRepo(_repoContext, _cache);

                return _creatureLootTemplatesRepo;
            }
        }

        private ICReferenceLootTemplateRepo _referenceLootTemplatesRepo;
        public ICReferenceLootTemplateRepo ReferenceLootTemplatesRepo
        {
            get
            {
                if (_referenceLootTemplatesRepo == null)
                    _referenceLootTemplatesRepo = new CReferenceLootTemplateRepo(_repoContext, _cache);

                return _referenceLootTemplatesRepo;
            }
        }

        private ICCreatuteRepo _creaturesRepo;
        public ICCreatuteRepo CreaturesRepo
        {
            get
            {
                if (_creaturesRepo == null)
                    _creaturesRepo = new CCreatureRepo(_repoContext, _cache);

                return _creaturesRepo;
            }
        }

        private ICItemTemplateRepo _itemTemplateRepo;
        public ICItemTemplateRepo ItemTemplateRepo
        {
            get
            {
                if (_itemTemplateRepo == null)
                    _itemTemplateRepo = new CItemTemplateRepo(_repoContext, _cache);

                return _itemTemplateRepo;
            }
        }

        public CRepositoryWrapper(CRepositoryContext repositoryContext, IAppCache cache)
        {
            _repoContext = repositoryContext;
            _cache = cache;
        }
    }
}
