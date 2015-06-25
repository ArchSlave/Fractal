; 51   : 	for (int yCoordinate = 0; yCoordinate < imageHeight; yCoordinate++)

	xor	ecx, ecx
	movsd	xmm6, QWORD PTR _ER2
	add	esi, 2
	movsd	xmm1, QWORD PTR __real@4004000000000000
	mov	DWORD PTR _yCoordinate$1$[esp+204], ecx
$LL9@main:

; 52   : 	{
; 53   : 		complexY = CyMin + yCoordinate*PixelHeight;
; 54   : 
; 55   : 		for (int xCoordinate = 0; xCoordinate < imageWidth; xCoordinate++)		{

	movd	xmm7, ecx
	xor	edi, edi
	cvtdq2pd xmm7, xmm7
	mulsd	xmm7, QWORD PTR _PixelHeight
	subsd	xmm7, xmm1
	npad	6
$LL6@main:

; 56   : 			double Zx, Zy, Zx2, Zy2;
; 57   : 			double complexX = CxMin + xCoordinate * PixelWidth;

	movd	xmm5, edi
	xorps	xmm4, xmm4
	cvtdq2pd xmm5, xmm5

; 58   : 			Zx = 0.0;
; 59   : 			Zy = 0.0;
; 60   : 			Zx2 = 0.0;
; 61   : 			Zy2 = 0.0;
; 62   : 
; 63   : 
; 64   : 			int Iteration;
; 65   : 			for (Iteration = 0; Iteration < IterationMax && ((Zx2 + Zy2) < ER2); Iteration++){

	xor	eax, eax
	xorps	xmm2, xmm2
	xorps	xmm3, xmm3
	mulsd	xmm5, QWORD PTR _PixelWidth
	subsd	xmm5, xmm1
	xorps	xmm1, xmm1
$LL3@main:
	movapd	xmm0, xmm3
	addsd	xmm0, xmm2
	comisd	xmm6, xmm0
	jbe	SHORT $LN1@main

; 66   : 				
; 67   : 				Zy = 2 * Zx*Zy + complexY;

	mulsd	xmm1, QWORD PTR __real@4000000000000000
	inc	eax
	mulsd	xmm4, xmm1

; 68   : 				Zx = Zx2 - Zy2 + complexX;

	movapd	xmm1, xmm2
	subsd	xmm1, xmm3
	addsd	xmm4, xmm7
	addsd	xmm1, xmm5

; 69   : 				Zx2 = Zx * Zx;
; 70   : 				Zy2 = Zy * Zy;

	movapd	xmm3, xmm4
	mulsd	xmm3, xmm4
	movapd	xmm2, xmm1
	mulsd	xmm2, xmm1
	cmp	eax, 256				; 00000100H
	jl	SHORT $LL3@main
$LN1@main:

; 71   : 				
; 72   : 			}
; 73   : 
; 74   : 			int mod8, mod4, mod2;
; 75   : 			mod2 = (mod4 = (mod8 = ((IterationMax - Iteration) % 8)) % 4) % 2;

	mov	edx, 256				; 00000100H
	sub	edx, eax
	and	edx, -2147483641			; 80000007H
	jns	SHORT $LN68@main
	dec	edx
	or	edx, -8					; fffffff8H
	inc	edx
$LN68@main:
	mov	eax, edx
	and	eax, -2147483645			; 80000003H
	jns	SHORT $LN69@main
	dec	eax
	or	eax, -4					; fffffffcH
	inc	eax
$LN69@main:
	mov	ebx, eax
	and	ebx, -2147483647			; 80000001H
	jns	SHORT $LN70@main
	dec	ebx
	or	ebx, -2					; fffffffeH
	inc	ebx
$LN70@main:

; 76   : 			setColor(xCoordinate, yCoordinate, mod8 * 63, mod4 * 127, mod2 * 255);

	movsd	xmm1, QWORD PTR __real@4004000000000000
	mov	cl, dl
	shl	cl, 6

; 30   : 	colorArray[offset + 2] = b;

	neg	bl

; 76   : 			setColor(xCoordinate, yCoordinate, mod8 * 63, mod4 * 127, mod2 * 255);

	sub	cl, dl

; 30   : 	colorArray[offset + 2] = b;

	mov	BYTE PTR [esi], bl
	mov	BYTE PTR [esi-2], cl

; 52   : 	{
; 53   : 		complexY = CyMin + yCoordinate*PixelHeight;
; 54   : 
; 55   : 		for (int xCoordinate = 0; xCoordinate < imageWidth; xCoordinate++)		{

	inc	edi

; 76   : 			setColor(xCoordinate, yCoordinate, mod8 * 63, mod4 * 127, mod2 * 255);

	mov	cl, 127					; 0000007fH
	imul	cl

; 29   : 	colorArray[offset + 1] = g;

	mov	BYTE PTR [esi-1], al

; 52   : 	{
; 53   : 		complexY = CyMin + yCoordinate*PixelHeight;
; 54   : 
; 55   : 		for (int xCoordinate = 0; xCoordinate < imageWidth; xCoordinate++)		{

	add	esi, 3
	cmp	edi, 500				; 000001f4H
	jl	$LL6@main

; 45   : 	}
; 46   : 
; 47   : 	double complexY = 0;
; 48   : 	double complexX = 0;
; 49   : 	double two = 2;
; 50   : 
; 51   : 	for (int yCoordinate = 0; yCoordinate < imageHeight; yCoordinate++)

	mov	ecx, DWORD PTR _yCoordinate$1$[esp+204]
	inc	ecx
	mov	DWORD PTR _yCoordinate$1$[esp+204], ecx
	cmp	ecx, 500				; 000001f4H
	jl	$LL9@main

; 81   : 	std::ofstream fileStream;