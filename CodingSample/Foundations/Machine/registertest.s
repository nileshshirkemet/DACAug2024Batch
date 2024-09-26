	.include "console.i"

	.start main

main:
	GetInt	askn		#rax=N

	mov	rcx, rax	#rcx=N
	add	rcx, 1		#rcx=N+1
	mul	rcx		#rax=N*(N+1)
	mov	rcx, 2		#rcx=2
	div	rcx		#rax=N*(N+1)/2

	PutInt	tell

	ret

askn:	.string	"Upper Limit: "
tell:	.string	"Sum of Integers = "

	.end
