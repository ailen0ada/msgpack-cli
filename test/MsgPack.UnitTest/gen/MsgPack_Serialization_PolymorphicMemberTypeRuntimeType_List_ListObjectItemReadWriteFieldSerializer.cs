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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteFieldSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<object>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>> this_SetUnpackedValueOfListObjectItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>> _unpackOperationTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteFieldSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema itemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            itemsSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedCollection(typeof(System.Collections.Generic.IList<object>), itemsSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<object>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>(this.PackValueOfListObjectItem);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfListObjectItemAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>>(1);
            packOperationTable["ListObjectItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>(this.PackValueOfListObjectItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["ListObjectItem"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfListObjectItemAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, bool>>(1);
            nullCheckerTable["ListObjectItem"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, bool>(this.IsListObjectItemNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>(this.UnpackValueOfListObjectItem);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfListObjectItemAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>>(1);
            unpackOperationTable["ListObjectItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int>(this.UnpackValueOfListObjectItem);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["ListObjectItem"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfListObjectItemAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "ListObjectItem"};
            this.this_SetUnpackedValueOfListObjectItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>>(this.SetUnpackedValueOfListObjectItem);
        }
        
        private void PackValueOfListObjectItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListObjectItem);
        }
        
        private bool IsListObjectItemNull(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField objectTree) {
            return (objectTree.ListObjectItem == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTable;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(ref packHelperParameters);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(ref packHelperParameters0);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfListObjectItemAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.ListObjectItem, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTableAsync;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            packHelperParameters0.CancellationToken = cancellationToken;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(ref packHelperParameters);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(ref packHelperParameters0);
            }
        }
        
        private void SetUnpackedValueOfListObjectItem(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField unpackingContext, System.Collections.Generic.IList<object> unpackedValue) {
            unpackingContext.ListObjectItem = unpackedValue;
        }
        
        private void UnpackValueOfListObjectItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<object>);
            unpackHelperParameters.MemberName = "ListObjectItem";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListObjectItemDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfListObjectItemAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<object>);
            unpackHelperParameters.MemberName = "ListObjectItem";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListObjectItemDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListObjectItemReadWriteField>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
