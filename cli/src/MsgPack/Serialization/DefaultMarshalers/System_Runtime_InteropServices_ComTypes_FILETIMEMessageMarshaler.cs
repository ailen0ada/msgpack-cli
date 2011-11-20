﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.Runtime.InteropServices.ComTypes;

namespace MsgPack.Serialization.DefaultMarshalers
{
	internal sealed class System_Runtime_InteropServices_ComTypes_FILETIMEMessageMarshaler : MessageMarshaler<FILETIME>
	{
		protected sealed override void MarshalToCore( Packer packer, FILETIME value )
		{
			packer.Pack( MessagePackConvert.FromDateTime( DateTime.FromFileTimeUtc( unchecked( ( ( long )value.dwHighDateTime << 32 ) | ( value.dwLowDateTime & 0xffffffff ) ) ) ) );
		}

		protected sealed override FILETIME UnmarshalFromCore( Unpacker unpacker )
		{
			var value = MessagePackConvert.ToDateTime( unpacker.Data.Value.AsInt64() ).ToFileTimeUtc();
			return new FILETIME() { dwHighDateTime = unchecked( ( int )( value >> 32 ) ), dwLowDateTime = unchecked( ( int )( value & 0xffffffff ) ) };
		}
	}
}