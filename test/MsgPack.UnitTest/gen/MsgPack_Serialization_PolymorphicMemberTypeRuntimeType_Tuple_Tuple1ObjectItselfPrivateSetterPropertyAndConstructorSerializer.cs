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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor_set_Tuple1ObjectItself0;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, object> this_SetUnpackedValueOfTuple1ObjectItselfDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>> _unpackOperationTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object));
            this._serializer0 = context.GetSerializer<object>(schema0);
            this._methodBasePolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor_set_Tuple1ObjectItself0 = MsgPack.Serialization.ReflectionHelpers.GetMethod(typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor), "set_Tuple1ObjectItself", new System.Type[] {
                        typeof(object)});
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>(this.PackValueOfTuple1ObjectItself);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTuple1ObjectItselfAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>>(1);
            packOperationTable["Tuple1ObjectItself"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>(this.PackValueOfTuple1ObjectItself);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["Tuple1ObjectItself"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTuple1ObjectItselfAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, bool>>(1);
            nullCheckerTable["Tuple1ObjectItself"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, bool>(this.IsTuple1ObjectItselfNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfTuple1ObjectItself);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTuple1ObjectItselfAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>>(1);
            unpackOperationTable["Tuple1ObjectItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfTuple1ObjectItself);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["Tuple1ObjectItself"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTuple1ObjectItselfAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Tuple1ObjectItself"};
            this.this_SetUnpackedValueOfTuple1ObjectItselfDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, object>(this.SetUnpackedValueOfTuple1ObjectItself);
        }
        
        private void PackValueOfTuple1ObjectItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple1ObjectItself);
        }
        
        private bool IsTuple1ObjectItselfNull(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor objectTree) {
            return (objectTree.Tuple1ObjectItself == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>);
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
        
        private System.Threading.Tasks.Task PackValueOfTuple1ObjectItselfAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Tuple1ObjectItself, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>);
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
        
        private void SetUnpackedValueOfTuple1ObjectItself(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor unpackingContext, object unpackedValue) {
            this._methodBasePolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor_set_Tuple1ObjectItself0.Invoke(unpackingContext, new object[] {
                        unpackedValue});
        }
        
        private void UnpackValueOfTuple1ObjectItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, object> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, object>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(object);
            unpackHelperParameters.MemberName = "Tuple1ObjectItself";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfTuple1ObjectItselfDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfTuple1ObjectItselfAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, object> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor, object>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(object);
            unpackHelperParameters.MemberName = "Tuple1ObjectItself";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfTuple1ObjectItselfDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1ObjectItselfPrivateSetterPropertyAndConstructor>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
