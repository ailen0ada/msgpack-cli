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
    public class MsgPack_Serialization_ComplexTypeWithDataContractSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithDataContract> {
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer3;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithDataContract, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithDataContract, byte[]> this_SetUnpackedValueOfDataDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, byte[]> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithDataContract, System.Collections.Generic.Dictionary<System.DateTime, string>> this_SetUnpackedValueOfHistoryDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithDataContract, System.Uri> this_SetUnpackedValueOfSourceDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithDataContract, System.DateTime> this_SetUnpackedValueOfTimeStampDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_ComplexTypeWithDataContractSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<byte[]>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<System.Uri>(schema2);
            this._serializer3 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>[4];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>(this.PackValueOfData);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>(this.PackValueOfHistory);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>(this.PackValueOfSource);
            packOperationList[3] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>(this.PackValueOfTimeStamp);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>>(4);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>(this.PackValueOfData);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>(this.PackValueOfHistory);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>(this.PackValueOfSource);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContract>(this.PackValueOfTimeStamp);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithDataContract, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithDataContract, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithDataContract, bool>>(3);
            nullCheckerTable["Data"] = new System.Func<MsgPack.Serialization.ComplexTypeWithDataContract, bool>(this.IsDataNull);
            nullCheckerTable["History"] = new System.Func<MsgPack.Serialization.ComplexTypeWithDataContract, bool>(this.IsHistoryNull);
            nullCheckerTable["Source"] = new System.Func<MsgPack.Serialization.ComplexTypeWithDataContract, bool>(this.IsSourceNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>[4];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>(this.UnpackValueOfData);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>(this.UnpackValueOfHistory);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>(this.UnpackValueOfSource);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>>(4);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>(this.UnpackValueOfData);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>(this.UnpackValueOfHistory);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>(this.UnpackValueOfSource);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContract, int, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Data",
                    "History",
                    "Source",
                    "TimeStamp"};
            this.this_SetUnpackedValueOfDataDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithDataContract, byte[]>(this.SetUnpackedValueOfData);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, byte[]>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue);
            this.this_SetUnpackedValueOfHistoryDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithDataContract, System.Collections.Generic.Dictionary<System.DateTime, string>>(this.SetUnpackedValueOfHistory);
            this.this_SetUnpackedValueOfSourceDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithDataContract, System.Uri>(this.SetUnpackedValueOfSource);
            this.this_SetUnpackedValueOfTimeStampDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithDataContract, System.DateTime>(this.SetUnpackedValueOfTimeStamp);
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContract objectTree) {
            this._serializer0.PackTo(packer, objectTree.Data);
        }
        
        private bool IsDataNull(MsgPack.Serialization.ComplexTypeWithDataContract objectTree) {
            return (objectTree.Data == null);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContract objectTree) {
            this._serializer1.PackTo(packer, objectTree.History);
        }
        
        private bool IsHistoryNull(MsgPack.Serialization.ComplexTypeWithDataContract objectTree) {
            return (objectTree.History == null);
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContract objectTree) {
            this._serializer2.PackTo(packer, objectTree.Source);
        }
        
        private bool IsSourceNull(MsgPack.Serialization.ComplexTypeWithDataContract objectTree) {
            return (objectTree.Source == null);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContract objectTree) {
            this._serializer3.PackTo(packer, objectTree.TimeStamp);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContract objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexTypeWithDataContract> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexTypeWithDataContract>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexTypeWithDataContract> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexTypeWithDataContract>);
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
        
        private void SetUnpackedValueOfData(MsgPack.Serialization.ComplexTypeWithDataContract unpackingContext, byte[] unpackedValue) {
            unpackingContext.Data = unpackedValue;
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContract unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithDataContract, byte[]> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithDataContract, byte[]>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(byte[]);
            unpackHelperParameters.MemberName = "Data";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfDataDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfHistory(MsgPack.Serialization.ComplexTypeWithDataContract unpackingContext, System.Collections.Generic.Dictionary<System.DateTime, string> unpackedValue) {
            System.Collections.Generic.Dictionary<System.DateTime, string> existent = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
            existent = unpackingContext.History;
            System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContract unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithDataContract, System.Collections.Generic.Dictionary<System.DateTime, string>> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithDataContract, System.Collections.Generic.Dictionary<System.DateTime, string>>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(System.Collections.Generic.Dictionary<System.DateTime, string>);
            unpackHelperParameters0.MemberName = "History";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = null;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfHistoryDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters0);
        }
        
        private void SetUnpackedValueOfSource(MsgPack.Serialization.ComplexTypeWithDataContract unpackingContext, System.Uri unpackedValue) {
            unpackingContext.Source = unpackedValue;
        }
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContract unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithDataContract, System.Uri> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithDataContract, System.Uri>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer2;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(System.Uri);
            unpackHelperParameters1.MemberName = "Source";
            unpackHelperParameters1.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters1.DirectRead = null;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfSourceDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters1);
        }
        
        private void SetUnpackedValueOfTimeStamp(MsgPack.Serialization.ComplexTypeWithDataContract unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.TimeStamp = unpackedValue;
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContract unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.ComplexTypeWithDataContract, System.DateTime> unpackHelperParameters2 = default(MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.ComplexTypeWithDataContract, System.DateTime>);
            unpackHelperParameters2.Unpacker = unpacker;
            unpackHelperParameters2.UnpackingContext = unpackingContext;
            unpackHelperParameters2.Serializer = this._serializer3;
            unpackHelperParameters2.ItemsCount = itemsCount;
            unpackHelperParameters2.Unpacked = indexOfItem;
            unpackHelperParameters2.TargetObjectType = typeof(System.DateTime);
            unpackHelperParameters2.MemberName = "TimeStamp";
            unpackHelperParameters2.DirectRead = null;
            unpackHelperParameters2.Setter = this.this_SetUnpackedValueOfTimeStampDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(ref unpackHelperParameters2);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithDataContract UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithDataContract result = default(MsgPack.Serialization.ComplexTypeWithDataContract);
            result = new MsgPack.Serialization.ComplexTypeWithDataContract();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithDataContract>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithDataContract>(), this._unpackOperationTable);
            }
        }
    }
}
