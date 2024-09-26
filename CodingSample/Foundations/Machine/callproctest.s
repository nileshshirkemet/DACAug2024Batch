	.include "console.i"

	.start	main

compute:
	mov	rcx, rax
	add	rcx, 1
	mul	rcx
	shr	rax, 1
	
	ret
main:
	GetInt	askm
	mov	rdi, rax	#rdi=M
	GetInt	askn
	mov	rsi, rax	#rsi=N

	cmp	rdi, rsi
	jg	idiot
	mov	rax, rdi
	sub	rax, 1
	call	compute
	mov	rbx, rax
	mov	rax, rsi
	call	compute
	sub	rax, rbx

	PutInt	tell
	
idiot:	ret

askm:	.string	"Lower Limit: "
askn:	.string	"Upper Limit: "
tell:	.string	"Sum of Integers = " 

	.end

