﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.9.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_SimpleCollection_1_MsgPack_MessagePackObjectArray_Serializer : MsgPack.Serialization.CollectionSerializers.CollectionMessagePackSerializer<MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject[]>, MsgPack.MessagePackObject[]> {
        
        public MsgPack_Serialization_SimpleCollection_1_MsgPack_MessagePackObjectArray_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack_Serialization_SimpleCollection_1_MsgPack_MessagePackObjectArray_Serializer.RestoreSchema(), ((MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom) 
                                | MsgPack.Serialization.SerializerCapabilities.UnpackTo)) {
        }
        
        protected override MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject[]> CreateInstance(int initialCapacity) {
            MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject[]> collection = default(MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject[]>);
            collection = new MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject[]>();
            return collection;
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
