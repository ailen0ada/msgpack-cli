﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8745
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.9.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_AddOnlyCollection_1_System_Int32_Serializer : MsgPack.Serialization.CollectionSerializers.EnumerableMessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<int>, int> {
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<int>, int> _unpackTo;
        
        public MsgPack_Serialization_AddOnlyCollection_1_System_Int32_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack_Serialization_AddOnlyCollection_1_System_Int32_Serializer.RestoreSchema(), ((MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom) 
                                | MsgPack.Serialization.SerializerCapabilities.UnpackTo)) {
            this._unpackTo = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<int>, int>(this.UnpackToCore);
        }
        
        protected override MsgPack.Serialization.AddOnlyCollection<int> CreateInstance(int initialCapacity) {
            MsgPack.Serialization.AddOnlyCollection<int> collection = default(MsgPack.Serialization.AddOnlyCollection<int>);
            collection = new MsgPack.Serialization.AddOnlyCollection<int>();
            return collection;
        }
        
        protected override void AddItem(MsgPack.Serialization.AddOnlyCollection<int> collection, int item) {
            collection.Add(item);
        }
        
        protected internal override MsgPack.Serialization.AddOnlyCollection<int> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowIsNotArrayHeader(unpacker);
            }
            int itemsCount = default(int);
            itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            MsgPack.Serialization.UnpackCollectionParameters<MsgPack.Serialization.AddOnlyCollection<int>> unpackHelperParameters = default(MsgPack.Serialization.UnpackCollectionParameters<MsgPack.Serialization.AddOnlyCollection<int>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Collection = this.CreateInstance(itemsCount);
            unpackHelperParameters.BulkOperation = this._unpackTo;
            unpackHelperParameters.EachOperation = null;
            return MsgPack.Serialization.UnpackHelpers.UnpackCollection<MsgPack.Serialization.AddOnlyCollection<int>>(ref unpackHelperParameters);
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
