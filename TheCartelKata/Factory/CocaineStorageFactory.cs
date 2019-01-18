using System;
using System.Collections.Generic;
using TheCartelKata.Interface;
using TheCartelKata.Strategy.Storage;

namespace TheCartelKata.Factory
{
    public static class CocaineStorageFactory
    {
        public static Dictionary<Enum.State, Func<IProperty, IStorage>> Storage = new Dictionary<Enum.State, Func<IProperty, IStorage>>
        {
            { Enum.State.Cut, (property) => { return new CocaineCutStorage(property); } },
            { Enum.State.Raw, (property) => { return new CocaineRawStorage(property); } },
        };
    }
}
