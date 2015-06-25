; 51   : 	for (int yCoordinate = 0; yCoordinate < imageHeight; yCoordinate++)

	and	DWORD PTR _yCoordinate$13[ebp], 0
	jmp	SHORT $LN9@main
$LN8@main:
	mov	eax, DWORD PTR _yCoordinate$13[ebp]
	inc	eax
	mov	DWORD PTR _yCoordinate$13[ebp], eax
$LN9@main:
	cmp	DWORD PTR _yCoordinate$13[ebp], 500	; 000001f4H
	jge	$LN7@main

; 52   : 	{
; 53   : 		complexY = CyMin + yCoordinate*PixelHeight;

	cvtsi2sd xmm0, DWORD PTR _yCoordinate$13[ebp]
	mulsd	xmm0, QWORD PTR _PixelHeight
	addsd	xmm0, QWORD PTR _CyMin
	movsd	QWORD PTR _complexY$[ebp], xmm0

; 54   : 
; 55   : 		for (int xCoordinate = 0; xCoordinate < imageWidth; xCoordinate++)		{

	and	DWORD PTR _xCoordinate$12[ebp], 0
	jmp	SHORT $LN6@main
$LN5@main:
	mov	eax, DWORD PTR _xCoordinate$12[ebp]
	inc	eax
	mov	DWORD PTR _xCoordinate$12[ebp], eax
$LN6@main:
	cmp	DWORD PTR _xCoordinate$12[ebp], 500	; 000001f4H
	jge	$LN4@main

; 56   : 			double Zx, Zy, Zx2, Zy2;
; 57   : 			double complexX = CxMin + xCoordinate * PixelWidth;

	cvtsi2sd xmm0, DWORD PTR _xCoordinate$12[ebp]
	mulsd	xmm0, QWORD PTR _PixelWidth
	addsd	xmm0, QWORD PTR _CxMin
	movsd	QWORD PTR _complexX$2[ebp], xmm0

; 58   : 			Zx = 0.0;

	movsd	xmm0, QWORD PTR __real@0000000000000000
	movsd	QWORD PTR _Zx$8[ebp], xmm0

; 59   : 			Zy = 0.0;

	movsd	xmm0, QWORD PTR __real@0000000000000000
	movsd	QWORD PTR _Zy$7[ebp], xmm0

; 60   : 			Zx2 = 0.0;

	movsd	xmm0, QWORD PTR __real@0000000000000000
	movsd	QWORD PTR _Zx2$4[ebp], xmm0

; 61   : 			Zy2 = 0.0;

	movsd	xmm0, QWORD PTR __real@0000000000000000
	movsd	QWORD PTR _Zy2$6[ebp], xmm0

; 62   : 
; 63   : 
; 64   : 			int Iteration;
; 65   : 			for (Iteration = 0; Iteration < IterationMax && ((Zx2 + Zy2) < ER2); Iteration++){

	and	DWORD PTR _Iteration$11[ebp], 0
	jmp	SHORT $LN3@main
$LN2@main:
	mov	eax, DWORD PTR _Iteration$11[ebp]
	inc	eax
	mov	DWORD PTR _Iteration$11[ebp], eax
$LN3@main:
	cmp	DWORD PTR _Iteration$11[ebp], 256	; 00000100H
	jge	SHORT $LN1@main
	movsd	xmm0, QWORD PTR _Zx2$4[ebp]
	addsd	xmm0, QWORD PTR _Zy2$6[ebp]
	movsd	xmm1, QWORD PTR _ER2
	comisd	xmm1, xmm0
	jbe	SHORT $LN1@main

; 66   : 				
; 67   : 				Zy = 2 * Zx*Zy + complexY;

	movsd	xmm0, QWORD PTR __real@4000000000000000
	mulsd	xmm0, QWORD PTR _Zx$8[ebp]
	mulsd	xmm0, QWORD PTR _Zy$7[ebp]
	addsd	xmm0, QWORD PTR _complexY$[ebp]
	movsd	QWORD PTR _Zy$7[ebp], xmm0

; 68   : 				Zx = Zx2 - Zy2 + complexX;

	movsd	xmm0, QWORD PTR _Zx2$4[ebp]
	subsd	xmm0, QWORD PTR _Zy2$6[ebp]
	addsd	xmm0, QWORD PTR _complexX$2[ebp]
	movsd	QWORD PTR _Zx$8[ebp], xmm0

; 69   : 				Zx2 = Zx * Zx;

	movsd	xmm0, QWORD PTR _Zx$8[ebp]
	mulsd	xmm0, QWORD PTR _Zx$8[ebp]
	movsd	QWORD PTR _Zx2$4[ebp], xmm0

; 70   : 				Zy2 = Zy * Zy;

	movsd	xmm0, QWORD PTR _Zy$7[ebp]
	mulsd	xmm0, QWORD PTR _Zy$7[ebp]
	movsd	QWORD PTR _Zy2$6[ebp], xmm0

; 71   : 				
; 72   : 			}

	jmp	SHORT $LN2@main
$LN1@main:

; 73   : 
; 74   : 			int mod8, mod4, mod2;
; 75   : 			mod2 = (mod4 = (mod8 = ((IterationMax - Iteration) % 8)) % 4) % 2;

	mov	eax, 256				; 00000100H
	sub	eax, DWORD PTR _Iteration$11[ebp]
	and	eax, -2147483641			; 80000007H
	jns	SHORT $LN14@main
	dec	eax
	or	eax, -8					; fffffff8H
	inc	eax
$LN14@main:
	mov	DWORD PTR _mod8$9[ebp], eax
	mov	eax, DWORD PTR _mod8$9[ebp]
	and	eax, -2147483645			; 80000003H
	jns	SHORT $LN15@main
	dec	eax
	or	eax, -4					; fffffffcH
	inc	eax
$LN15@main:
	mov	DWORD PTR _mod4$10[ebp], eax
	mov	eax, DWORD PTR _mod4$10[ebp]
	and	eax, -2147483647			; 80000001H
	jns	SHORT $LN16@main
	dec	eax
	or	eax, -2					; fffffffeH
	inc	eax
$LN16@main:
	mov	DWORD PTR _mod2$3[ebp], eax

; 76   : 			setColor(xCoordinate, yCoordinate, mod8 * 63, mod4 * 127, mod2 * 255);

	imul	eax, DWORD PTR _mod2$3[ebp], 255
	push	eax
	imul	eax, DWORD PTR _mod4$10[ebp], 127
	push	eax
	imul	eax, DWORD PTR _mod8$9[ebp], 63
	push	eax
	push	DWORD PTR _yCoordinate$13[ebp]
	push	DWORD PTR _xCoordinate$12[ebp]
	call	?setColor@@YAXHHDDD@Z			; setColor
	add	esp, 20					; 00000014H

; 77   : 		}

	jmp	$LN5@main
$LN4@main:

; 78   : 	}