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
    public class MsgPack_Serialization_TestValueTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.TestValueType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<int, int>> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<int[]> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer2;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.TestValueType, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.TestValueType> this_CreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, System.Collections.Generic.Dictionary<int, int>> this_SetUnpackedValueOfDictionaryFieldDelegate;
        
        private System.Action<UnpackingContext, int[]> this_SetUnpackedValueOfInt32ArrayFieldDelegate;
        
        private System.Action<UnpackingContext, string> this_SetUnpackedValueOfStringFieldDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, string> MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<string>> MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_TestValueTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.Dictionary<int, int>>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<int[]>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<string>(schema2);
            System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfDictionaryField);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfInt32ArrayField);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfStringField);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>[3];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictionaryFieldAsync);
            packOperationListAsync[1] = new System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfInt32ArrayFieldAsync);
            packOperationListAsync[2] = new System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfStringFieldAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>>(3);
            packOperationTable["DictionaryField"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfDictionaryField);
            packOperationTable["Int32ArrayField"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfInt32ArrayField);
            packOperationTable["StringField"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfStringField);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(3);
            packOperationTableAsync["DictionaryField"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictionaryFieldAsync);
            packOperationTableAsync["Int32ArrayField"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfInt32ArrayFieldAsync);
            packOperationTableAsync["StringField"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.TestValueType, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfStringFieldAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.TestValueType, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.TestValueType, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.TestValueType, bool>>(3);
            nullCheckerTable["DictionaryField"] = new System.Func<MsgPack.Serialization.TestValueType, bool>(this.IsDictionaryFieldNull);
            nullCheckerTable["Int32ArrayField"] = new System.Func<MsgPack.Serialization.TestValueType, bool>(this.IsInt32ArrayFieldNull);
            nullCheckerTable["StringField"] = new System.Func<MsgPack.Serialization.TestValueType, bool>(this.IsStringFieldNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfDictionaryField);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfInt32ArrayField);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfStringField);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[3];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictionaryFieldAsync);
            unpackOperationListAsync[1] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfInt32ArrayFieldAsync);
            unpackOperationListAsync[2] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfStringFieldAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>(3);
            unpackOperationTable["DictionaryField"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfDictionaryField);
            unpackOperationTable["Int32ArrayField"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfInt32ArrayField);
            unpackOperationTable["StringField"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfStringField);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(3);
            unpackOperationTableAsync["DictionaryField"] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictionaryFieldAsync);
            unpackOperationTableAsync["Int32ArrayField"] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfInt32ArrayFieldAsync);
            unpackOperationTableAsync["StringField"] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfStringFieldAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "DictionaryField",
                    "Int32ArrayField",
                    "StringField"};
            this.this_CreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.TestValueType>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfDictionaryFieldDelegate = new System.Action<UnpackingContext, System.Collections.Generic.Dictionary<int, int>>(this.SetUnpackedValueOfDictionaryField);
            this.this_SetUnpackedValueOfInt32ArrayFieldDelegate = new System.Action<UnpackingContext, int[]>(this.SetUnpackedValueOfInt32ArrayField);
            this.this_SetUnpackedValueOfStringFieldDelegate = new System.Action<UnpackingContext, string>(this.SetUnpackedValueOfStringField);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, string>(MsgPack.Serialization.UnpackHelpers.UnpackStringValue);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<string>>(MsgPack.Serialization.UnpackHelpers.UnpackStringValueAsync);
        }
        
        private void PackValueOfDictionaryField(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictionaryField);
        }
        
        private bool IsDictionaryFieldNull(MsgPack.Serialization.TestValueType objectTree) {
            return (objectTree.DictionaryField == null);
        }
        
        private void PackValueOfInt32ArrayField(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            this._serializer1.PackTo(packer, objectTree.Int32ArrayField);
        }
        
        private bool IsInt32ArrayFieldNull(MsgPack.Serialization.TestValueType objectTree) {
            return (objectTree.Int32ArrayField == null);
        }
        
        private void PackValueOfStringField(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            this._serializer2.PackTo(packer, objectTree.StringField);
        }
        
        private bool IsStringFieldNull(MsgPack.Serialization.TestValueType objectTree) {
            return (objectTree.StringField == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.TestValueType> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.TestValueType>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.TestValueType> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.TestValueType>);
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
        
        private System.Threading.Tasks.Task PackValueOfDictionaryFieldAsync(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.DictionaryField, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfInt32ArrayFieldAsync(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer1.PackToAsync(packer, objectTree.Int32ArrayField, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfStringFieldAsync(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer2.PackToAsync(packer, objectTree.StringField, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.TestValueType> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.TestValueType>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.TestValueType> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.TestValueType>);
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
        
        private MsgPack.Serialization.TestValueType CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.TestValueType result = default(MsgPack.Serialization.TestValueType);
            result.DictionaryField = unpackingContext.DictionaryField;
            result.Int32ArrayField = unpackingContext.Int32ArrayField;
            result.StringField = unpackingContext.StringField;
            return result;
        }
        
        private void SetUnpackedValueOfDictionaryField(UnpackingContext unpackingContext, System.Collections.Generic.Dictionary<int, int> unpackedValue) {
            unpackingContext.DictionaryField = unpackedValue;
        }
        
        private void UnpackValueOfDictionaryField(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, System.Collections.Generic.Dictionary<int, int>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, System.Collections.Generic.Dictionary<int, int>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.Dictionary<int, int>);
            unpackHelperParameters.MemberName = "DictionaryField";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfDictionaryFieldDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfInt32ArrayField(UnpackingContext unpackingContext, int[] unpackedValue) {
            unpackingContext.Int32ArrayField = unpackedValue;
        }
        
        private void UnpackValueOfInt32ArrayField(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, int[]> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, int[]>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(int[]);
            unpackHelperParameters0.MemberName = "Int32ArrayField";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = null;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfInt32ArrayFieldDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters0);
        }
        
        private void SetUnpackedValueOfStringField(UnpackingContext unpackingContext, string unpackedValue) {
            unpackingContext.StringField = unpackedValue;
        }
        
        private void UnpackValueOfStringField(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, string> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, string>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer2;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(string);
            unpackHelperParameters1.MemberName = "StringField";
            unpackHelperParameters1.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters1.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfStringFieldDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters1);
        }
        
        protected internal override MsgPack.Serialization.TestValueType UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Collections.Generic.Dictionary<int, int> ctorArg0 = default(System.Collections.Generic.Dictionary<int, int>);
            ctorArg0 = default(System.Collections.Generic.Dictionary<int, int>);
            int[] ctorArg1 = default(int[]);
            ctorArg1 = default(int[]);
            string ctorArg2 = default(string);
            ctorArg2 = default(string);
            unpackingContext = new UnpackingContext(ctorArg0, ctorArg1, ctorArg2);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfDictionaryFieldAsync(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, System.Collections.Generic.Dictionary<int, int>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, System.Collections.Generic.Dictionary<int, int>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.Dictionary<int, int>);
            unpackHelperParameters.MemberName = "DictionaryField";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfDictionaryFieldDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfInt32ArrayFieldAsync(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, int[]> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, int[]>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(int[]);
            unpackHelperParameters0.MemberName = "Int32ArrayField";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = null;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfInt32ArrayFieldDelegate;
            unpackHelperParameters0.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters0);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfStringFieldAsync(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, string> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, string>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer2;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(string);
            unpackHelperParameters1.MemberName = "StringField";
            unpackHelperParameters1.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters1.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfStringFieldDelegate;
            unpackHelperParameters1.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters1);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.TestValueType> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Collections.Generic.Dictionary<int, int> ctorArg0 = default(System.Collections.Generic.Dictionary<int, int>);
            ctorArg0 = default(System.Collections.Generic.Dictionary<int, int>);
            int[] ctorArg1 = default(int[]);
            ctorArg1 = default(int[]);
            string ctorArg2 = default(string);
            ctorArg2 = default(string);
            unpackingContext = new UnpackingContext(ctorArg0, ctorArg1, ctorArg2);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTableAsync, cancellationToken);
            }
        }
        
        public class UnpackingContext {
            
            public System.Collections.Generic.Dictionary<int, int> DictionaryField;
            
            public int[] Int32ArrayField;
            
            public string StringField;
            
            public UnpackingContext(System.Collections.Generic.Dictionary<int, int> DictionaryField, int[] Int32ArrayField, string StringField) {
                this.DictionaryField = DictionaryField;
                this.Int32ArrayField = Int32ArrayField;
                this.StringField = StringField;
            }
        }
    }
}
