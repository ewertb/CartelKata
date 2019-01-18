using System;
using System.Collections.Generic;
using TheCartelKata.Interface;
using TheCartelKata.Strategy.Storage;

namespace TheCartelKata.Factory
{
    public static class StorageFactory
    {
        public static Dictionary<Type, Func<IProperty, IStorage>> Storage = new Dictionary<Type, Func<IProperty, IStorage>>
        {
            { typeof(Marijuana), (property) => { return new MarijuanaStorage(property); } },
            { typeof(Cocaine), (property) => { return CocaineStorageFactory.Storage[property.Drug.State](property); } },
            { typeof(Mdma), (property) => { return new MdmaStorage(property); } },
        };
    }
}
