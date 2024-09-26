	.include "console.i"

	.extern	gcd

	.start	main
main:
	GetInt	ask
	mov	rdi, rax
	GetInt	ask
	mov	rsi, rax

	call	gcd

	PutInt	tell

	ret

ask:	.string	"Positive Integer: "
tell:	.string	"G.C.D = "

	.end

