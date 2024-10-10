
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
// MVID: {eb8c3e34-5d1d-41d3-8a23-aceb523c7fda}
.custom instance void [System.Runtime]System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0x7f3dcaac4000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  '<Main>$'(string[] args) cil managed
  {
    .entrypoint
    // Code size       91 (0x5b)
    .maxstack  4
    .locals init (int32 V_0,
             bool V_1)
    IL_0000:  ldarg.0
    IL_0001:  ldlen
    IL_0002:  brfalse.s  IL_0010

    IL_0004:  ldarg.0
    IL_0005:  ldc.i4.0
    IL_0006:  ldelem.ref
    IL_0007:  ldloca.s   V_0
    IL_0009:  call       bool [System.Runtime]System.Int32::TryParse(string,
                                                                     int32&)
    IL_000e:  br.s       IL_0011

    IL_0010:  ldc.i4.0
    IL_0011:  stloc.1
    IL_0012:  ldloc.1
    IL_0013:  brfalse.s  IL_005a

    IL_0015:  nop
    IL_0016:  ldstr      "Selected double value   = {0}"
    IL_001b:  ldloc.0
    IL_001c:  ldc.r8     43.100000000000001
    IL_0025:  ldc.r8     34.200000000000003
    IL_002e:  call       !!0 Program::Select<float64>(int32,
                                                      !!0,
                                                      !!0)
    IL_0033:  box        [System.Runtime]System.Double
    IL_0038:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_003d:  nop
    IL_003e:  ldstr      "Selected string value   = {0}"
    IL_0043:  ldloc.0
    IL_0044:  ldstr      "Monday"
    IL_0049:  ldstr      "Tuesday"
    IL_004e:  call       !!0 Program::Select<string>(int32,
                                                     !!0,
                                                     !!0)
    IL_0053:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0058:  nop
    IL_0059:  nop
    IL_005a:  ret
  } // end of method Program::'<Main>$'

  .method private hidebysig static !!T  Select<T>(int32 index,
                                                  !!T first,
                                                  !!T second) cil managed
  {
    // Code size       21 (0x15)
    .maxstack  2
    .locals init (bool V_0,
             !!T V_1)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldc.i4.2
    IL_0003:  rem
    IL_0004:  ldc.i4.1
    IL_0005:  ceq
    IL_0007:  stloc.0
    IL_0008:  ldloc.0
    IL_0009:  brfalse.s  IL_000f

    IL_000b:  ldarg.1
    IL_000c:  stloc.1
    IL_000d:  br.s       IL_0013

    IL_000f:  ldarg.2
    IL_0010:  stloc.1
    IL_0011:  br.s       IL_0013

    IL_0013:  ldloc.1
    IL_0014:  ret
  } // end of method Program::Select

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

} // end of class Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
