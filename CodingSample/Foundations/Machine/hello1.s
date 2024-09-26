	.include "console.i"

	.start	entry

entry:
	PutMsg	greet	#output message at memory location identified by greet label
	ret

greet:	.string	"Hello World!\n"

	.end

