#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010-2012 FUJIWARA, Yusuke
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

using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle( "MessagePack for Windows Phone 7.1" )]
[assembly: AssemblyDescription( "MessagePack for Windows Phone 7.1 packing/unpacking serialization library." )]
[assembly: AssemblyConfiguration( "Experimental" )]
[assembly: AssemblyCopyright( "Copyright © FUJIWARA, Yusuke 2010-2012" )]


[assembly: AssemblyFileVersion( "0.4.1297.568" )]

#if DEBUG || PERFORMANCE_TEST
[assembly: InternalsVisibleTo( "MsgPack.WindowsPhone.UnitTest" )]
#endif


