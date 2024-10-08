
//  .NET IL Disassembler.  Version 8.0.0



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 8:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 8:0:0:0
}
.assembly DemoApp
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 38 2E 30 01 00 54 0E 14   // ersion=v8.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 08 2E 4E 45 54 20 38 2E 30 )          // Name..NET 8.0
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module DemoApp.dll
// MVID: {b074261b-ba5f-480f-8617-8848089e0780}
.custom instance void [System.Runtime]System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0x7fddadfd4000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Interval
       extends [System.Runtime]System.Object
{
  .field private initonly int32 '<Minutes>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private initonly int32 '<Seconds>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 min,
                               int32 sec) cil managed
  {
    // Code size       30 (0x1e)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldc.i4.s   60
    IL_0005:  div
    IL_0006:  add
    IL_0007:  stfld      int32 Interval::'<Minutes>k__BackingField'
    IL_000c:  ldarg.0
    IL_000d:  ldarg.2
    IL_000e:  ldc.i4.s   60
    IL_0010:  rem
    IL_0011:  stfld      int32 Interval::'<Seconds>k__BackingField'
    IL_0016:  ldarg.0
    IL_0017:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_001c:  nop
    IL_001d:  ret
  } // end of method Interval::.ctor

  .method public hidebysig specialname instance int32 
          get_Minutes() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Interval::'<Minutes>k__BackingField'
    IL_0006:  ret
  } // end of method Interval::get_Minutes

  .method public hidebysig specialname instance int32 
          get_Seconds() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Interval::'<Seconds>k__BackingField'
    IL_0006:  ret
  } // end of method Interval::get_Seconds

  .method public hidebysig instance int32 
          Time() cil managed
  {
    // Code size       22 (0x16)
    .maxstack  2
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldc.i4.s   60
    IL_0003:  ldarg.0
    IL_0004:  call       instance int32 Interval::get_Minutes()
    IL_0009:  mul
    IL_000a:  ldarg.0
    IL_000b:  call       instance int32 Interval::get_Seconds()
    IL_0010:  add
    IL_0011:  stloc.0
    IL_0012:  br.s       IL_0014

    IL_0014:  ldloc.0
    IL_0015:  ret
  } // end of method Interval::Time

  .method public hidebysig virtual instance string 
          ToString() cil managed
  {
    // Code size       99 (0x63)
    .maxstack  3
    .locals init (bool V_0,
             int32 V_1,
             string V_2)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  call       instance int32 Interval::get_Seconds()
    IL_0007:  ldc.i4.s   10
    IL_0009:  clt
    IL_000b:  stloc.0
    IL_000c:  ldloc.0
    IL_000d:  brfalse.s  IL_0038

    IL_000f:  ldarg.0
    IL_0010:  call       instance int32 Interval::get_Minutes()
    IL_0015:  stloc.1
    IL_0016:  ldloca.s   V_1
    IL_0018:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_001d:  ldstr      ":0"
    IL_0022:  ldarg.0
    IL_0023:  call       instance int32 Interval::get_Seconds()
    IL_0028:  stloc.1
    IL_0029:  ldloca.s   V_1
    IL_002b:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0030:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string,
                                                                      string)
    IL_0035:  stloc.2
    IL_0036:  br.s       IL_0061

    IL_0038:  ldarg.0
    IL_0039:  call       instance int32 Interval::get_Minutes()
    IL_003e:  stloc.1
    IL_003f:  ldloca.s   V_1
    IL_0041:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0046:  ldstr      ":"
    IL_004b:  ldarg.0
    IL_004c:  call       instance int32 Interval::get_Seconds()
    IL_0051:  stloc.1
    IL_0052:  ldloca.s   V_1
    IL_0054:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0059:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string,
                                                                      string)
    IL_005e:  stloc.2
    IL_005f:  br.s       IL_0061

    IL_0061:  ldloc.2
    IL_0062:  ret
  } // end of method Interval::ToString

  .method public hidebysig virtual instance int32 
          GetHashCode() cil managed
  {
    // Code size       19 (0x13)
    .maxstack  2
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  call       instance int32 Interval::get_Minutes()
    IL_0007:  ldarg.0
    IL_0008:  call       instance int32 Interval::get_Seconds()
    IL_000d:  add
    IL_000e:  stloc.0
    IL_000f:  br.s       IL_0011

    IL_0011:  ldloc.0
    IL_0012:  ret
  } // end of method Interval::GetHashCode

  .method public hidebysig virtual instance bool 
          Equals(object other) cil managed
  {
    // Code size       57 (0x39)
    .maxstack  2
    .locals init (class Interval V_0,
             bool V_1,
             bool V_2)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  isinst     Interval
    IL_0007:  stloc.0
    IL_0008:  ldloc.0
    IL_0009:  ldnull
    IL_000a:  cgt.un
    IL_000c:  stloc.1
    IL_000d:  ldloc.1
    IL_000e:  brfalse.s  IL_0033

    IL_0010:  nop
    IL_0011:  ldarg.0
    IL_0012:  call       instance int32 Interval::get_Minutes()
    IL_0017:  ldloc.0
    IL_0018:  callvirt   instance int32 Interval::get_Minutes()
    IL_001d:  bne.un.s   IL_002f

    IL_001f:  ldarg.0
    IL_0020:  call       instance int32 Interval::get_Seconds()
    IL_0025:  ldloc.0
    IL_0026:  callvirt   instance int32 Interval::get_Seconds()
    IL_002b:  ceq
    IL_002d:  br.s       IL_0030

    IL_002f:  ldc.i4.0
    IL_0030:  stloc.2
    IL_0031:  br.s       IL_0037

    IL_0033:  ldc.i4.0
    IL_0034:  stloc.2
    IL_0035:  br.s       IL_0037

    IL_0037:  ldloc.2
    IL_0038:  ret
  } // end of method Interval::Equals

  .method public hidebysig specialname static 
          class Interval  op_Addition(class Interval lhs,
                                      class Interval rhs) cil managed
  {
    // Code size       37 (0x25)
    .maxstack  3
    .locals init (class Interval V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  callvirt   instance int32 Interval::get_Minutes()
    IL_0007:  ldarg.1
    IL_0008:  callvirt   instance int32 Interval::get_Minutes()
    IL_000d:  add
    IL_000e:  ldarg.0
    IL_000f:  callvirt   instance int32 Interval::get_Seconds()
    IL_0014:  ldarg.1
    IL_0015:  callvirt   instance int32 Interval::get_Seconds()
    IL_001a:  add
    IL_001b:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_0020:  stloc.0
    IL_0021:  br.s       IL_0023

    IL_0023:  ldloc.0
    IL_0024:  ret
  } // end of method Interval::op_Addition

  .property instance callconv(8) int32 Minutes()
  {
    .get instance int32 Interval::get_Minutes()
  } // end of property Interval::Minutes
  .property instance callconv(8) int32 Seconds()
  {
    .get instance int32 Interval::get_Seconds()
  } // end of property Interval::Seconds
} // end of class Interval

.class private sequential ansi sealed beforefieldinit Plot
       extends [System.Runtime]System.ValueType
{
  .field private initonly float64 '<Length>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private initonly float64 '<Breadth>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname instance float64 
          get_Length() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 ) 
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      float64 Plot::'<Length>k__BackingField'
    IL_0006:  ret
  } // end of method Plot::get_Length

  .method public hidebysig specialname instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) 
          set_Length(float64 'value') cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      float64 Plot::'<Length>k__BackingField'
    IL_0007:  ret
  } // end of method Plot::set_Length

  .method public hidebysig specialname instance float64 
          get_Breadth() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 ) 
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      float64 Plot::'<Breadth>k__BackingField'
    IL_0006:  ret
  } // end of method Plot::get_Breadth

  .method public hidebysig specialname instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) 
          set_Breadth(float64 'value') cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      float64 Plot::'<Breadth>k__BackingField'
    IL_0007:  ret
  } // end of method Plot::set_Breadth

  .method public hidebysig instance float64 
          Area() cil managed
  {
    // Code size       19 (0x13)
    .maxstack  2
    .locals init (float64 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  call       instance float64 Plot::get_Length()
    IL_0007:  ldarg.0
    IL_0008:  call       instance float64 Plot::get_Breadth()
    IL_000d:  mul
    IL_000e:  stloc.0
    IL_000f:  br.s       IL_0011

    IL_0011:  ldloc.0
    IL_0012:  ret
  } // end of method Plot::Area

  .method public hidebysig virtual instance string 
          ToString() cil managed
  {
    // Code size       63 (0x3f)
    .maxstack  3
    .locals init (valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler V_0,
             string V_1)
    IL_0000:  nop
    IL_0001:  ldloca.s   V_0
    IL_0003:  ldc.i4.3
    IL_0004:  ldc.i4.2
    IL_0005:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32,
                                                                                                                               int32)
    IL_000a:  ldloca.s   V_0
    IL_000c:  ldarg.0
    IL_000d:  call       instance float64 Plot::get_Length()
    IL_0012:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<float64>(!!0)
    IL_0017:  nop
    IL_0018:  ldloca.s   V_0
    IL_001a:  ldstr      " x "
    IL_001f:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
    IL_0024:  nop
    IL_0025:  ldloca.s   V_0
    IL_0027:  ldarg.0
    IL_0028:  call       instance float64 Plot::get_Breadth()
    IL_002d:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<float64>(!!0)
    IL_0032:  nop
    IL_0033:  ldloca.s   V_0
    IL_0035:  call       instance string [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
    IL_003a:  stloc.1
    IL_003b:  br.s       IL_003d

    IL_003d:  ldloc.1
    IL_003e:  ret
  } // end of method Plot::ToString

  .property instance callconv(8) float64 Length()
  {
    .get instance float64 Plot::get_Length()
    .set instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) Plot::set_Length(float64)
  } // end of property Plot::Length
  .property instance callconv(8) float64 Breadth()
  {
    .get instance float64 Plot::get_Breadth()
    .set instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) Plot::set_Breadth(float64)
  } // end of property Plot::Breadth
} // end of class Plot

.class private auto ansi beforefieldinit Program
       extends [System.Runtime]System.Object
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method private hidebysig static void  '<Main>$'(string[] args) cil managed
  {
    .entrypoint
    // Code size       322 (0x142)
    .maxstack  3
    .locals init (class Interval V_0,
             class Interval V_1,
             class Interval V_2,
             class Interval V_3,
             valuetype Plot V_4,
             valuetype Plot V_5)
    IL_0000:  ldc.i4.6
    IL_0001:  ldc.i4.s   65
    IL_0003:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_0008:  stloc.0
    IL_0009:  ldc.i4.4
    IL_000a:  ldc.i4.s   30
    IL_000c:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_0011:  stloc.1
    IL_0012:  ldstr      "Interval a"
    IL_0017:  ldloc.0
    IL_0018:  call       void Program::'<<Main>$>g__Print|0_0'(string,
                                                               object)
    IL_001d:  nop
    IL_001e:  ldstr      "Interval b"
    IL_0023:  ldloc.1
    IL_0024:  call       void Program::'<<Main>$>g__Print|0_0'(string,
                                                               object)
    IL_0029:  nop
    IL_002a:  ldstr      "Sum"
    IL_002f:  ldloc.0
    IL_0030:  ldloc.1
    IL_0031:  call       class Interval Interval::op_Addition(class Interval,
                                                              class Interval)
    IL_0036:  call       void Program::'<<Main>$>g__Print|0_0'(string,
                                                               object)
    IL_003b:  nop
    IL_003c:  ldc.i4.7
    IL_003d:  ldc.i4.5
    IL_003e:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_0043:  stloc.2
    IL_0044:  ldstr      "Interval c"
    IL_0049:  ldloc.2
    IL_004a:  call       void Program::'<<Main>$>g__Print|0_0'(string,
                                                               object)
    IL_004f:  nop
    IL_0050:  ldloc.1
    IL_0051:  stloc.3
    IL_0052:  ldstr      "Interval d"
    IL_0057:  ldloc.3
    IL_0058:  call       void Program::'<<Main>$>g__Print|0_0'(string,
                                                               object)
    IL_005d:  nop
    IL_005e:  ldstr      "------------------------------------"
    IL_0063:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0068:  nop
    IL_0069:  ldstr      "a is identical to b: {0}"
    IL_006e:  ldloc.0
    IL_006f:  ldloc.1
    IL_0070:  ceq
    IL_0072:  box        [System.Runtime]System.Boolean
    IL_0077:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_007c:  nop
    IL_007d:  ldstr      "a is identical to c: {0}"
    IL_0082:  ldloc.0
    IL_0083:  ldloc.2
    IL_0084:  ceq
    IL_0086:  box        [System.Runtime]System.Boolean
    IL_008b:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0090:  nop
    IL_0091:  ldstr      "d is identical to b: {0}"
    IL_0096:  ldloc.3
    IL_0097:  ldloc.1
    IL_0098:  ceq
    IL_009a:  box        [System.Runtime]System.Boolean
    IL_009f:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_00a4:  nop
    IL_00a5:  ldstr      "------------------------------------"
    IL_00aa:  call       void [System.Console]System.Console::WriteLine(string)
    IL_00af:  nop
    IL_00b0:  ldstr      "a is equal to b: {0}"
    IL_00b5:  ldloc.0
    IL_00b6:  ldloc.1
    IL_00b7:  call       bool [System.Runtime]System.Object::Equals(object,
                                                                    object)
    IL_00bc:  box        [System.Runtime]System.Boolean
    IL_00c1:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_00c6:  nop
    IL_00c7:  ldstr      "a is equal to c: {0}"
    IL_00cc:  ldloc.0
    IL_00cd:  ldloc.2
    IL_00ce:  call       bool [System.Runtime]System.Object::Equals(object,
                                                                    object)
    IL_00d3:  box        [System.Runtime]System.Boolean
    IL_00d8:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_00dd:  nop
    IL_00de:  ldstr      "d is equal to b: {0}"
    IL_00e3:  ldloc.3
    IL_00e4:  ldloc.1
    IL_00e5:  call       bool [System.Runtime]System.Object::Equals(object,
                                                                    object)
    IL_00ea:  box        [System.Runtime]System.Boolean
    IL_00ef:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_00f4:  nop
    IL_00f5:  ldstr      "------------------------------------"
    IL_00fa:  call       void [System.Console]System.Console::WriteLine(string)
    IL_00ff:  nop
    IL_0100:  ldloca.s   V_5
    IL_0102:  initobj    Plot
    IL_0108:  ldloca.s   V_5
    IL_010a:  ldc.r8     40.75
    IL_0113:  call       instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) Plot::set_Length(float64)
    IL_0118:  nop
    IL_0119:  ldloca.s   V_5
    IL_011b:  ldc.r8     36.25
    IL_0124:  call       instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) Plot::set_Breadth(float64)
    IL_0129:  nop
    IL_012a:  ldloc.s    V_5
    IL_012c:  stloc.s    V_4
    IL_012e:  ldstr      "Plot e"
    IL_0133:  ldloc.s    V_4
    IL_0135:  box        Plot
    IL_013a:  call       void Program::'<<Main>$>g__Print|0_0'(string,
                                                               object)
    IL_013f:  nop
    IL_0140:  nop
    IL_0141:  ret
  } // end of method Program::'<Main>$'

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

  .method assembly hidebysig static void 
          '<<Main>$>g__Print|0_0'(string label,
                                  object info) cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "{0} = {1}"
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object,
                                                                        object)
    IL_000d:  nop
    IL_000e:  ret
  } // end of method Program::'<<Main>$>g__Print|0_0'

} // end of class Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
