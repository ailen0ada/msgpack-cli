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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWritePropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Collections.Generic.IList<string>> this_SetUnpackedValueOfListPolymorphicItselfDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>> _unpackOperationTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWritePropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicCollection(typeof(System.Collections.Generic.IList<string>), null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>(this.PackValueOfListPolymorphicItself);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfListPolymorphicItselfAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>>(1);
            packOperationTable["ListPolymorphicItself"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>(this.PackValueOfListPolymorphicItself);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["ListPolymorphicItself"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfListPolymorphicItselfAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, bool>>(1);
            nullCheckerTable["ListPolymorphicItself"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, bool>(this.IsListPolymorphicItselfNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>(this.UnpackValueOfListPolymorphicItself);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfListPolymorphicItselfAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>>(1);
            unpackOperationTable["ListPolymorphicItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int>(this.UnpackValueOfListPolymorphicItself);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["ListPolymorphicItself"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfListPolymorphicItselfAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "ListPolymorphicItself"};
            this.this_SetUnpackedValueOfListPolymorphicItselfDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Collections.Generic.IList<string>>(this.SetUnpackedValueOfListPolymorphicItself);
        }
        
        private void PackValueOfListPolymorphicItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListPolymorphicItself);
        }
        
        private bool IsListPolymorphicItselfNull(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty objectTree) {
            return (objectTree.ListPolymorphicItself == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>);
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
        
        private System.Threading.Tasks.Task PackValueOfListPolymorphicItselfAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.ListPolymorphicItself, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>);
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
        
        private void SetUnpackedValueOfListPolymorphicItself(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty unpackingContext, System.Collections.Generic.IList<string> unpackedValue) {
            unpackingContext.ListPolymorphicItself = unpackedValue;
        }
        
        private void UnpackValueOfListPolymorphicItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Collections.Generic.IList<string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Collections.Generic.IList<string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<string>);
            unpackHelperParameters.MemberName = "ListPolymorphicItself";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListPolymorphicItselfDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfListPolymorphicItselfAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Collections.Generic.IList<string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty, System.Collections.Generic.IList<string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<string>);
            unpackHelperParameters.MemberName = "ListPolymorphicItself";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListPolymorphicItselfDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_List_ListPolymorphicItselfReadWriteProperty>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
