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
    public class MsgPack_Serialization_VersioningTestTargetSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.VersioningTestTarget> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer1;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.VersioningTestTarget, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.VersioningTestTarget, int> this_SetUnpackedValueOfField1Delegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, int> MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
        
        private System.Action<MsgPack.Serialization.VersioningTestTarget, int> this_SetUnpackedValueOfField2Delegate;
        
        private System.Action<MsgPack.Serialization.VersioningTestTarget, string> this_SetUnpackedValueOfField3Delegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, string> MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_VersioningTestTargetSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<int>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<string>(schema1);
            System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField1);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField2);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField3);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>>(3);
            packOperationTable["Field1"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField1);
            packOperationTable["Field2"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField2);
            packOperationTable["Field3"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField3);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.VersioningTestTarget, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.VersioningTestTarget, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.VersioningTestTarget, bool>>(1);
            nullCheckerTable["Field3"] = new System.Func<MsgPack.Serialization.VersioningTestTarget, bool>(this.IsField3Null);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField1);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField2);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField3);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>>(3);
            unpackOperationTable["Field1"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField1);
            unpackOperationTable["Field2"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField2);
            unpackOperationTable["Field3"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField3);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Field1",
                    "Field2",
                    "Field3"};
            this.this_SetUnpackedValueOfField1Delegate = new System.Action<MsgPack.Serialization.VersioningTestTarget, int>(this.SetUnpackedValueOfField1);
            this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, int>(MsgPack.Serialization.UnpackHelpers.UnpackInt32Value);
            this.this_SetUnpackedValueOfField2Delegate = new System.Action<MsgPack.Serialization.VersioningTestTarget, int>(this.SetUnpackedValueOfField2);
            this.this_SetUnpackedValueOfField3Delegate = new System.Action<MsgPack.Serialization.VersioningTestTarget, string>(this.SetUnpackedValueOfField3);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, string>(MsgPack.Serialization.UnpackHelpers.UnpackStringValue);
        }
        
        private void PackValueOfField1(MsgPack.Packer packer, MsgPack.Serialization.VersioningTestTarget objectTree) {
            this._serializer0.PackTo(packer, objectTree.Field1);
        }
        
        private void PackValueOfField2(MsgPack.Packer packer, MsgPack.Serialization.VersioningTestTarget objectTree) {
            this._serializer0.PackTo(packer, objectTree.Field2);
        }
        
        private void PackValueOfField3(MsgPack.Packer packer, MsgPack.Serialization.VersioningTestTarget objectTree) {
            this._serializer1.PackTo(packer, objectTree.Field3);
        }
        
        private bool IsField3Null(MsgPack.Serialization.VersioningTestTarget objectTree) {
            return (objectTree.Field3 == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.VersioningTestTarget objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.VersioningTestTarget> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.VersioningTestTarget>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.VersioningTestTarget> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.VersioningTestTarget>);
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
        
        private void SetUnpackedValueOfField1(MsgPack.Serialization.VersioningTestTarget unpackingContext, int unpackedValue) {
            unpackingContext.Field1 = unpackedValue;
        }
        
        private void UnpackValueOfField1(MsgPack.Unpacker unpacker, MsgPack.Serialization.VersioningTestTarget unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.VersioningTestTarget, int> unpackHelperParameters = default(MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.VersioningTestTarget, int>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(int);
            unpackHelperParameters.MemberName = "Field1";
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfField1Delegate;
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfField2(MsgPack.Serialization.VersioningTestTarget unpackingContext, int unpackedValue) {
            unpackingContext.Field2 = unpackedValue;
        }
        
        private void UnpackValueOfField2(MsgPack.Unpacker unpacker, MsgPack.Serialization.VersioningTestTarget unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.VersioningTestTarget, int> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.VersioningTestTarget, int>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer0;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(int);
            unpackHelperParameters0.MemberName = "Field2";
            unpackHelperParameters0.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfField2Delegate;
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(ref unpackHelperParameters0);
        }
        
        private void SetUnpackedValueOfField3(MsgPack.Serialization.VersioningTestTarget unpackingContext, string unpackedValue) {
            unpackingContext.Field3 = unpackedValue;
        }
        
        private void UnpackValueOfField3(MsgPack.Unpacker unpacker, MsgPack.Serialization.VersioningTestTarget unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.VersioningTestTarget, string> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.VersioningTestTarget, string>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer1;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(string);
            unpackHelperParameters1.MemberName = "Field3";
            unpackHelperParameters1.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters1.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfField3Delegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters1);
        }
        
        protected internal override MsgPack.Serialization.VersioningTestTarget UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.VersioningTestTarget result = default(MsgPack.Serialization.VersioningTestTarget);
            result = new MsgPack.Serialization.VersioningTestTarget();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.VersioningTestTarget>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.VersioningTestTarget>(), this._unpackOperationTable);
            }
        }
    }
}
