﻿using MyHorizons.Data.Save;

namespace MyHorizons.Data
{
    public sealed class Item
    {
        public static readonly Item NO_ITEM = new Item(0xFFFE, 0, 0, 0);

        public ushort ItemId;
        public ushort Flags;
        public ushort Count;
        public ushort UseCount;

        public Item(ushort itemId, ushort flags, ushort count, ushort useCount)
        {
            ItemId = itemId;
            Flags = flags;
            Count = count;
            UseCount = useCount;
        }

        public Item(int offset)
            : this(MainSaveFile.Singleton().ReadU16(offset + 0), MainSaveFile.Singleton().ReadU16(offset + 2),
                   MainSaveFile.Singleton().ReadU16(offset + 4), MainSaveFile.Singleton().ReadU16(offset + 6)) { }
    }
}
