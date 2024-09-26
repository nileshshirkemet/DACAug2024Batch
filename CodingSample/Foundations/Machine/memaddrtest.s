	.include "console.i"

	.start	main

compute:
	mov	rcx, rax
	add	rcx, 1
	mul	rcx
	shr	rax, 1
	
	ret

main:
	GetInt	askm			#direct addressing
	
	mov	rdi, rax
	dec	rdi			#sub	rdi, 1
	mov	rbx, offset year	#immediate addressing
	mov	rax, [rbx+8*rdi]	#indirect addressing (indirection)
	call	compute

	PutInt	tell

	ret

askm:	.string	"Month [1-12]: "
tell:	.string	"Total Amount = " 
year:	.quad	31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
	.end

