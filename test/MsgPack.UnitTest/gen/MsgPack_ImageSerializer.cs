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
    public class MsgPack_ImageSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Image> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer1;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Image, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Image, int> this_SetUnpackedValueOfheightDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<int>> MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
        
        private System.Action<MsgPack.Image, int> this_SetUnpackedValueOfsizeDelegate;
        
        private System.Action<MsgPack.Image, string> this_SetUnpackedValueOftitleDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<string>> MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate;
        
        private System.Action<MsgPack.Image, string> this_SetUnpackedValueOfuriDelegate;
        
        private System.Action<MsgPack.Image, int> this_SetUnpackedValueOfwidthDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_ImageSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<int>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<string>(schema1);
            System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>[5];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfheightAsync);
            packOperationListAsync[1] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfsizeAsync);
            packOperationListAsync[2] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOftitleAsync);
            packOperationListAsync[3] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfuriAsync);
            packOperationListAsync[4] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfwidthAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(5);
            packOperationTableAsync["height"] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfheightAsync);
            packOperationTableAsync["size"] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfsizeAsync);
            packOperationTableAsync["title"] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOftitleAsync);
            packOperationTableAsync["uri"] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfuriAsync);
            packOperationTableAsync["width"] = new System.Func<MsgPack.Packer, MsgPack.Image, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfwidthAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Image, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Image, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Image, bool>>(2);
            nullCheckerTable["title"] = new System.Func<MsgPack.Image, bool>(this.IstitleNull);
            nullCheckerTable["uri"] = new System.Func<MsgPack.Image, bool>(this.IsuriNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[5];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfheightAsync);
            unpackOperationListAsync[1] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfsizeAsync);
            unpackOperationListAsync[2] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOftitleAsync);
            unpackOperationListAsync[3] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfuriAsync);
            unpackOperationListAsync[4] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfwidthAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(5);
            unpackOperationTableAsync["height"] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfheightAsync);
            unpackOperationTableAsync["size"] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfsizeAsync);
            unpackOperationTableAsync["title"] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOftitleAsync);
            unpackOperationTableAsync["uri"] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfuriAsync);
            unpackOperationTableAsync["width"] = new System.Func<MsgPack.Unpacker, MsgPack.Image, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfwidthAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "height",
                    "size",
                    "title",
                    "uri",
                    "width"};
            this.this_SetUnpackedValueOfheightDelegate = new System.Action<MsgPack.Image, int>(this.SetUnpackedValueOfheight);
            this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<int>>(MsgPack.Serialization.UnpackHelpers.UnpackInt32ValueAsync);
            this.this_SetUnpackedValueOfsizeDelegate = new System.Action<MsgPack.Image, int>(this.SetUnpackedValueOfsize);
            this.this_SetUnpackedValueOftitleDelegate = new System.Action<MsgPack.Image, string>(this.SetUnpackedValueOftitle);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<string>>(MsgPack.Serialization.UnpackHelpers.UnpackStringValueAsync);
            this.this_SetUnpackedValueOfuriDelegate = new System.Action<MsgPack.Image, string>(this.SetUnpackedValueOfuri);
            this.this_SetUnpackedValueOfwidthDelegate = new System.Action<MsgPack.Image, int>(this.SetUnpackedValueOfwidth);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Image objectTree) {
            objectTree.PackToMessage(packer, null);
        }
        
        private System.Threading.Tasks.Task PackValueOfheightAsync(MsgPack.Packer packer, MsgPack.Image objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.height, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfsizeAsync(MsgPack.Packer packer, MsgPack.Image objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.size, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOftitleAsync(MsgPack.Packer packer, MsgPack.Image objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer1.PackToAsync(packer, objectTree.title, cancellationToken);
        }
        
        private bool IstitleNull(MsgPack.Image objectTree) {
            return (objectTree.title == null);
        }
        
        private System.Threading.Tasks.Task PackValueOfuriAsync(MsgPack.Packer packer, MsgPack.Image objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer1.PackToAsync(packer, objectTree.uri, cancellationToken);
        }
        
        private bool IsuriNull(MsgPack.Image objectTree) {
            return (objectTree.uri == null);
        }
        
        private System.Threading.Tasks.Task PackValueOfwidthAsync(MsgPack.Packer packer, MsgPack.Image objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.width, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Image objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Image> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Image>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Image> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Image>);
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
        
        protected internal override MsgPack.Image UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Image result = default(MsgPack.Image);
            result = new MsgPack.Image();
            result.UnpackFromMessage(unpacker);
            return result;
        }
        
        private void SetUnpackedValueOfheight(MsgPack.Image unpackingContext, int unpackedValue) {
            unpackingContext.height = unpackedValue;
        }
        
        private System.Threading.Tasks.Task UnpackValueOfheightAsync(MsgPack.Unpacker unpacker, MsgPack.Image unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Image, int> unpackHelperParameters = default(MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Image, int>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(int);
            unpackHelperParameters.MemberName = "height";
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfheightDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfsize(MsgPack.Image unpackingContext, int unpackedValue) {
            unpackingContext.size = unpackedValue;
        }
        
        private System.Threading.Tasks.Task UnpackValueOfsizeAsync(MsgPack.Unpacker unpacker, MsgPack.Image unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Image, int> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Image, int>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer0;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(int);
            unpackHelperParameters0.MemberName = "size";
            unpackHelperParameters0.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfsizeDelegate;
            unpackHelperParameters0.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(ref unpackHelperParameters0);
        }
        
        private void SetUnpackedValueOftitle(MsgPack.Image unpackingContext, string unpackedValue) {
            unpackingContext.title = unpackedValue;
        }
        
        private System.Threading.Tasks.Task UnpackValueOftitleAsync(MsgPack.Unpacker unpacker, MsgPack.Image unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Image, string> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Image, string>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer1;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(string);
            unpackHelperParameters1.MemberName = "title";
            unpackHelperParameters1.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters1.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOftitleDelegate;
            unpackHelperParameters1.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters1);
        }
        
        private void SetUnpackedValueOfuri(MsgPack.Image unpackingContext, string unpackedValue) {
            unpackingContext.uri = unpackedValue;
        }
        
        private System.Threading.Tasks.Task UnpackValueOfuriAsync(MsgPack.Unpacker unpacker, MsgPack.Image unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Image, string> unpackHelperParameters2 = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Image, string>);
            unpackHelperParameters2.Unpacker = unpacker;
            unpackHelperParameters2.UnpackingContext = unpackingContext;
            unpackHelperParameters2.Serializer = this._serializer1;
            unpackHelperParameters2.ItemsCount = itemsCount;
            unpackHelperParameters2.Unpacked = indexOfItem;
            unpackHelperParameters2.TargetObjectType = typeof(string);
            unpackHelperParameters2.MemberName = "uri";
            unpackHelperParameters2.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters2.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate;
            unpackHelperParameters2.Setter = this.this_SetUnpackedValueOfuriDelegate;
            unpackHelperParameters2.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters2);
        }
        
        private void SetUnpackedValueOfwidth(MsgPack.Image unpackingContext, int unpackedValue) {
            unpackingContext.width = unpackedValue;
        }
        
        private System.Threading.Tasks.Task UnpackValueOfwidthAsync(MsgPack.Unpacker unpacker, MsgPack.Image unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Image, int> unpackHelperParameters3 = default(MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Image, int>);
            unpackHelperParameters3.Unpacker = unpacker;
            unpackHelperParameters3.UnpackingContext = unpackingContext;
            unpackHelperParameters3.Serializer = this._serializer0;
            unpackHelperParameters3.ItemsCount = itemsCount;
            unpackHelperParameters3.Unpacked = indexOfItem;
            unpackHelperParameters3.TargetObjectType = typeof(int);
            unpackHelperParameters3.MemberName = "width";
            unpackHelperParameters3.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
            unpackHelperParameters3.Setter = this.this_SetUnpackedValueOfwidthDelegate;
            unpackHelperParameters3.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(ref unpackHelperParameters3);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Image> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Image result = default(MsgPack.Image);
            result = new MsgPack.Image();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Image>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Image>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
