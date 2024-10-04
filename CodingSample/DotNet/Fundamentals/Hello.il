.assembly Hello {}
.assembly extern System.Console {} //available in Microsoft.NETCore.App

.method public static void Run()
{
	.entrypoint

	ldstr	"Hello World!"
	call	void [System.Console]System.Console::WriteLine(string)
	ret
}



