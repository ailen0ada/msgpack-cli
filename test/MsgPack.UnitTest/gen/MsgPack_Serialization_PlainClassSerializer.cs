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
    public class MsgPack_Serialization_PlainClassSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PlainClass> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<int>> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer1;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PlainClass, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PlainClass, System.Collections.Generic.List<int>> this_SetUnpackedValueOfCollectionReadOnlyPropertyDelegate;
        
        private System.Action<MsgPack.Serialization.PlainClass, int> this_SetUnpackedValueOfPublicFieldDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, int> MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
        
        private System.Action<MsgPack.Serialization.PlainClass, int> this_SetUnpackedValueOfPublicPropertyDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<int>> MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PlainClassSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.List<int>>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<int>(schema1);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>(this.PackValueOfCollectionReadOnlyProperty);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>(this.PackValueOfPublicField);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>(this.PackValueOfPublicProperty);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>[3];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfCollectionReadOnlyPropertyAsync);
            packOperationListAsync[1] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfPublicFieldAsync);
            packOperationListAsync[2] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfPublicPropertyAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>>(3);
            packOperationTable["CollectionReadOnlyProperty"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>(this.PackValueOfCollectionReadOnlyProperty);
            packOperationTable["PublicField"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>(this.PackValueOfPublicField);
            packOperationTable["PublicProperty"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>(this.PackValueOfPublicProperty);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(3);
            packOperationTableAsync["CollectionReadOnlyProperty"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfCollectionReadOnlyPropertyAsync);
            packOperationTableAsync["PublicField"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfPublicFieldAsync);
            packOperationTableAsync["PublicProperty"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PlainClass, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfPublicPropertyAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PlainClass, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PlainClass, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PlainClass, bool>>(1);
            nullCheckerTable["CollectionReadOnlyProperty"] = new System.Func<MsgPack.Serialization.PlainClass, bool>(this.IsCollectionReadOnlyPropertyNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>(this.UnpackValueOfCollectionReadOnlyProperty);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>(this.UnpackValueOfPublicField);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>(this.UnpackValueOfPublicProperty);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[3];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfCollectionReadOnlyPropertyAsync);
            unpackOperationListAsync[1] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfPublicFieldAsync);
            unpackOperationListAsync[2] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfPublicPropertyAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>>(3);
            unpackOperationTable["CollectionReadOnlyProperty"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>(this.UnpackValueOfCollectionReadOnlyProperty);
            unpackOperationTable["PublicField"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>(this.UnpackValueOfPublicField);
            unpackOperationTable["PublicProperty"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int>(this.UnpackValueOfPublicProperty);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(3);
            unpackOperationTableAsync["CollectionReadOnlyProperty"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfCollectionReadOnlyPropertyAsync);
            unpackOperationTableAsync["PublicField"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfPublicFieldAsync);
            unpackOperationTableAsync["PublicProperty"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfPublicPropertyAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "CollectionReadOnlyProperty",
                    "PublicField",
                    "PublicProperty"};
            this.this_SetUnpackedValueOfCollectionReadOnlyPropertyDelegate = new System.Action<MsgPack.Serialization.PlainClass, System.Collections.Generic.List<int>>(this.SetUnpackedValueOfCollectionReadOnlyProperty);
            this.this_SetUnpackedValueOfPublicFieldDelegate = new System.Action<MsgPack.Serialization.PlainClass, int>(this.SetUnpackedValueOfPublicField);
            this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, int>(MsgPack.Serialization.UnpackHelpers.UnpackInt32Value);
            this.this_SetUnpackedValueOfPublicPropertyDelegate = new System.Action<MsgPack.Serialization.PlainClass, int>(this.SetUnpackedValueOfPublicProperty);
            this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<int>>(MsgPack.Serialization.UnpackHelpers.UnpackInt32ValueAsync);
        }
        
        private void PackValueOfCollectionReadOnlyProperty(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree) {
            this._serializer0.PackTo(packer, objectTree.CollectionReadOnlyProperty);
        }
        
        private bool IsCollectionReadOnlyPropertyNull(MsgPack.Serialization.PlainClass objectTree) {
            return (objectTree.CollectionReadOnlyProperty == null);
        }
        
        private void PackValueOfPublicField(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree) {
            this._serializer1.PackTo(packer, objectTree.PublicField);
        }
        
        private void PackValueOfPublicProperty(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree) {
            this._serializer1.PackTo(packer, objectTree.PublicProperty);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PlainClass> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PlainClass>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PlainClass> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PlainClass>);
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
        
        private System.Threading.Tasks.Task PackValueOfCollectionReadOnlyPropertyAsync(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.CollectionReadOnlyProperty, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfPublicFieldAsync(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer1.PackToAsync(packer, objectTree.PublicField, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfPublicPropertyAsync(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer1.PackToAsync(packer, objectTree.PublicProperty, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PlainClass> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PlainClass>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PlainClass> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PlainClass>);
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
        
        private void SetUnpackedValueOfCollectionReadOnlyProperty(MsgPack.Serialization.PlainClass unpackingContext, System.Collections.Generic.List<int> unpackedValue) {
            System.Collections.Generic.List<int> existent = default(System.Collections.Generic.List<int>);
            existent = unpackingContext.CollectionReadOnlyProperty;
            System.Collections.Generic.List<int>.Enumerator enumerator = unpackedValue.GetEnumerator();
            int current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfCollectionReadOnlyProperty(MsgPack.Unpacker unpacker, MsgPack.Serialization.PlainClass unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PlainClass, System.Collections.Generic.List<int>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PlainClass, System.Collections.Generic.List<int>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.List<int>);
            unpackHelperParameters.MemberName = "CollectionReadOnlyProperty";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfCollectionReadOnlyPropertyDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfPublicField(MsgPack.Serialization.PlainClass unpackingContext, int unpackedValue) {
            unpackingContext.PublicField = unpackedValue;
        }
        
        private void UnpackValueOfPublicField(MsgPack.Unpacker unpacker, MsgPack.Serialization.PlainClass unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.PlainClass, int> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.PlainClass, int>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(int);
            unpackHelperParameters0.MemberName = "PublicField";
            unpackHelperParameters0.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfPublicFieldDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(ref unpackHelperParameters0);
        }
        
        private void SetUnpackedValueOfPublicProperty(MsgPack.Serialization.PlainClass unpackingContext, int unpackedValue) {
            unpackingContext.PublicProperty = unpackedValue;
        }
        
        private void UnpackValueOfPublicProperty(MsgPack.Unpacker unpacker, MsgPack.Serialization.PlainClass unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.PlainClass, int> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.PlainClass, int>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer1;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(int);
            unpackHelperParameters1.MemberName = "PublicProperty";
            unpackHelperParameters1.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfPublicPropertyDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(ref unpackHelperParameters1);
        }
        
        protected internal override MsgPack.Serialization.PlainClass UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PlainClass result = default(MsgPack.Serialization.PlainClass);
            result = new MsgPack.Serialization.PlainClass();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PlainClass>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PlainClass>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfCollectionReadOnlyPropertyAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PlainClass unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PlainClass, System.Collections.Generic.List<int>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PlainClass, System.Collections.Generic.List<int>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.List<int>);
            unpackHelperParameters.MemberName = "CollectionReadOnlyProperty";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfCollectionReadOnlyPropertyDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfPublicFieldAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PlainClass unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Serialization.PlainClass, int> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Serialization.PlainClass, int>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(int);
            unpackHelperParameters0.MemberName = "PublicField";
            unpackHelperParameters0.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfPublicFieldDelegate;
            unpackHelperParameters0.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(ref unpackHelperParameters0);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfPublicPropertyAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PlainClass unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Serialization.PlainClass, int> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Serialization.PlainClass, int>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer1;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(int);
            unpackHelperParameters1.MemberName = "PublicProperty";
            unpackHelperParameters1.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfPublicPropertyDelegate;
            unpackHelperParameters1.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(ref unpackHelperParameters1);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PlainClass> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PlainClass result = default(MsgPack.Serialization.PlainClass);
            result = new MsgPack.Serialization.PlainClass();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PlainClass>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PlainClass>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
