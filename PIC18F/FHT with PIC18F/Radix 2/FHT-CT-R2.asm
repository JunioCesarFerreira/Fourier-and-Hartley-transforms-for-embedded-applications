
_Modulo:

;FHT-CT-R2.c,13 :: 		double Modulo(double Val){
;FHT-CT-R2.c,14 :: 		if (Val<0) return Val*-1;
	CLRF        R4 
	CLRF        R5 
	CLRF        R6 
	CLRF        R7 
	MOVF        FARG_Modulo_Val+0, 0 
	MOVWF       R0 
	MOVF        FARG_Modulo_Val+1, 0 
	MOVWF       R1 
	MOVF        FARG_Modulo_Val+2, 0 
	MOVWF       R2 
	MOVF        FARG_Modulo_Val+3, 0 
	MOVWF       R3 
	CALL        _Compare_Double+0, 0
	MOVLW       1
	BTFSC       STATUS+0, 0 
	MOVLW       0
	MOVWF       R0 
	MOVF        R0, 1 
	BTFSC       STATUS+0, 2 
	GOTO        L_Modulo0
	MOVF        FARG_Modulo_Val+0, 0 
	MOVWF       R0 
	MOVF        FARG_Modulo_Val+1, 0 
	MOVWF       R1 
	MOVF        FARG_Modulo_Val+2, 0 
	MOVWF       R2 
	MOVF        FARG_Modulo_Val+3, 0 
	MOVWF       R3 
	MOVLW       0
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVLW       128
	MOVWF       R6 
	MOVLW       127
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	RETURN      0
L_Modulo0:
;FHT-CT-R2.c,15 :: 		else return Val;
	MOVF        FARG_Modulo_Val+0, 0 
	MOVWF       R0 
	MOVF        FARG_Modulo_Val+1, 0 
	MOVWF       R1 
	MOVF        FARG_Modulo_Val+2, 0 
	MOVWF       R2 
	MOVF        FARG_Modulo_Val+3, 0 
	MOVWF       R3 
;FHT-CT-R2.c,16 :: 		}
	RETURN      0
; end of _Modulo

_Table_Reverse:

;FHT-CT-R2.c,17 :: 		unsigned int Table_Reverse(unsigned int index, unsigned int Lenght){
;FHT-CT-R2.c,19 :: 		switch (Lenght){
	GOTO        L_Table_Reverse2
;FHT-CT-R2.c,20 :: 		case 8:
L_Table_Reverse4:
;FHT-CT-R2.c,21 :: 		Lim=3;
	MOVLW       3
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;FHT-CT-R2.c,22 :: 		break;
	GOTO        L_Table_Reverse3
;FHT-CT-R2.c,23 :: 		case 16:
L_Table_Reverse5:
;FHT-CT-R2.c,24 :: 		Lim=4;
	MOVLW       4
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;FHT-CT-R2.c,25 :: 		break;
	GOTO        L_Table_Reverse3
;FHT-CT-R2.c,26 :: 		case 32:
L_Table_Reverse6:
;FHT-CT-R2.c,27 :: 		Lim=5;
	MOVLW       5
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;FHT-CT-R2.c,28 :: 		break;
	GOTO        L_Table_Reverse3
;FHT-CT-R2.c,29 :: 		case 64:
L_Table_Reverse7:
;FHT-CT-R2.c,30 :: 		Lim=6;
	MOVLW       6
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;FHT-CT-R2.c,31 :: 		break;
	GOTO        L_Table_Reverse3
;FHT-CT-R2.c,32 :: 		case 128:
L_Table_Reverse8:
;FHT-CT-R2.c,33 :: 		Lim=7;
	MOVLW       7
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;FHT-CT-R2.c,34 :: 		break;
	GOTO        L_Table_Reverse3
;FHT-CT-R2.c,35 :: 		case 256:
L_Table_Reverse9:
;FHT-CT-R2.c,36 :: 		Lim=8;
	MOVLW       8
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;FHT-CT-R2.c,37 :: 		break;
	GOTO        L_Table_Reverse3
;FHT-CT-R2.c,38 :: 		case 512:
L_Table_Reverse10:
;FHT-CT-R2.c,39 :: 		Lim=9;
	MOVLW       9
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;FHT-CT-R2.c,40 :: 		break;
	GOTO        L_Table_Reverse3
;FHT-CT-R2.c,41 :: 		}
L_Table_Reverse2:
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse47
	MOVLW       8
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse47:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse4
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse48
	MOVLW       16
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse48:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse5
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse49
	MOVLW       32
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse49:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse6
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse50
	MOVLW       64
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse50:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse7
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse51
	MOVLW       128
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse51:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse8
	MOVF        FARG_Table_Reverse_Lenght+1, 0 
	XORLW       1
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse52
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse52:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse9
	MOVF        FARG_Table_Reverse_Lenght+1, 0 
	XORLW       2
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse53
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse53:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse10
L_Table_Reverse3:
;FHT-CT-R2.c,42 :: 		mirror = 0;
	CLRF        R2 
	CLRF        R3 
;FHT-CT-R2.c,43 :: 		for (exp=0;exp<Lim;exp++){
	CLRF        R4 
	CLRF        R5 
L_Table_Reverse11:
	MOVF        R7, 0 
	SUBWF       R5, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse54
	MOVF        R6, 0 
	SUBWF       R4, 0 
L__Table_Reverse54:
	BTFSC       STATUS+0, 0 
	GOTO        L_Table_Reverse12
;FHT-CT-R2.c,44 :: 		mirror=mirror<<1;
	RLCF        R2, 1 
	BCF         R2, 0 
	RLCF        R3, 1 
;FHT-CT-R2.c,45 :: 		mirror+=(0x01&index);
	MOVLW       1
	ANDWF       FARG_Table_Reverse_index+0, 0 
	MOVWF       R0 
	MOVF        FARG_Table_Reverse_index+1, 0 
	MOVWF       R1 
	MOVLW       0
	ANDWF       R1, 1 
	MOVF        R0, 0 
	ADDWF       R2, 1 
	MOVF        R1, 0 
	ADDWFC      R3, 1 
;FHT-CT-R2.c,46 :: 		index=index>>1;
	RRCF        FARG_Table_Reverse_index+1, 1 
	RRCF        FARG_Table_Reverse_index+0, 1 
	BCF         FARG_Table_Reverse_index+1, 7 
;FHT-CT-R2.c,43 :: 		for (exp=0;exp<Lim;exp++){
	INFSNZ      R4, 1 
	INCF        R5, 1 
;FHT-CT-R2.c,47 :: 		}
	GOTO        L_Table_Reverse11
L_Table_Reverse12:
;FHT-CT-R2.c,48 :: 		return mirror;
	MOVF        R2, 0 
	MOVWF       R0 
	MOVF        R3, 0 
	MOVWF       R1 
;FHT-CT-R2.c,49 :: 		}
	RETURN      0
; end of _Table_Reverse

_Complemento:

;FHT-CT-R2.c,51 :: 		unsigned int Complemento(unsigned int K, unsigned int L){
;FHT-CT-R2.c,52 :: 		if (K==0) return 0;
	MOVLW       0
	XORWF       FARG_Complemento_K+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Complemento55
	MOVLW       0
	XORWF       FARG_Complemento_K+0, 0 
L__Complemento55:
	BTFSS       STATUS+0, 2 
	GOTO        L_Complemento14
	CLRF        R0 
	CLRF        R1 
	RETURN      0
L_Complemento14:
;FHT-CT-R2.c,53 :: 		else return (L-K);
	MOVF        FARG_Complemento_K+0, 0 
	SUBWF       FARG_Complemento_L+0, 0 
	MOVWF       R0 
	MOVF        FARG_Complemento_K+1, 0 
	SUBWFB      FARG_Complemento_L+1, 0 
	MOVWF       R1 
;FHT-CT-R2.c,54 :: 		}
	RETURN      0
; end of _Complemento

_main:

;FHT-CT-R2.c,56 :: 		main(){
;FHT-CT-R2.c,60 :: 		double pi_N=2*pi/N;      // Auxiliar Pi*n
	MOVLW       219
	MOVWF       main_pi_N_L0+0 
	MOVLW       15
	MOVWF       main_pi_N_L0+1 
	MOVLW       73
	MOVWF       main_pi_N_L0+2 
	MOVLW       122
	MOVWF       main_pi_N_L0+3 
;FHT-CT-R2.c,64 :: 		ADCON1 = 14;
	MOVLW       14
	MOVWF       ADCON1+0 
;FHT-CT-R2.c,65 :: 		TRISA = 1;
	MOVLW       1
	MOVWF       TRISA+0 
;FHT-CT-R2.c,66 :: 		TRISB = 0;
	CLRF        TRISB+0 
;FHT-CT-R2.c,67 :: 		PORTA = 0;
	CLRF        PORTA+0 
;FHT-CT-R2.c,68 :: 		PORTB = 0;
	CLRF        PORTB+0 
;FHT-CT-R2.c,70 :: 		do{
L_main16:
;FHT-CT-R2.c,71 :: 		PORTB=255;
	MOVLW       255
	MOVWF       PORTB+0 
;FHT-CT-R2.c,72 :: 		for (i=0;i<N;i++){  // ~ 7.48 ms
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main19:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main56
	MOVLW       128
	SUBWF       main_i_L0+0, 0 
L__main56:
	BTFSC       STATUS+0, 0 
	GOTO        L_main20
;FHT-CT-R2.c,73 :: 		v[i]=(5/1023)*ADC_Read(0);
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_v_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_v_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	CLRF        FARG_ADC_Read_channel+0 
	CALL        _ADC_Read+0, 0
	CLRF        R0 
	CLRF        R1 
	CALL        _Word2Double+0, 0
	MOVFF       FLOC__main+0, FSR1L
	MOVFF       FLOC__main+1, FSR1H
	MOVF        R0, 0 
	MOVWF       POSTINC1+0 
	MOVF        R1, 0 
	MOVWF       POSTINC1+0 
	MOVF        R2, 0 
	MOVWF       POSTINC1+0 
	MOVF        R3, 0 
	MOVWF       POSTINC1+0 
;FHT-CT-R2.c,74 :: 		Delay_us(50);
	MOVLW       83
	MOVWF       R13, 0
L_main22:
	DECFSZ      R13, 1, 0
	BRA         L_main22
;FHT-CT-R2.c,72 :: 		for (i=0;i<N;i++){  // ~ 7.48 ms
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
;FHT-CT-R2.c,75 :: 		}
	GOTO        L_main19
L_main20:
;FHT-CT-R2.c,76 :: 		PORTB=0;
	CLRF        PORTB+0 
;FHT-CT-R2.c,80 :: 		for (i=0;i<N;i++) X[Table_Reverse(i,N)]=v[i];
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main23:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main57
	MOVLW       128
	SUBWF       main_i_L0+0, 0 
L__main57:
	BTFSC       STATUS+0, 0 
	GOTO        L_main24
	MOVF        main_i_L0+0, 0 
	MOVWF       FARG_Table_Reverse_index+0 
	MOVF        main_i_L0+1, 0 
	MOVWF       FARG_Table_Reverse_index+1 
	MOVLW       128
	MOVWF       FARG_Table_Reverse_Lenght+0 
	MOVLW       0
	MOVWF       FARG_Table_Reverse_Lenght+1 
	CALL        _Table_Reverse+0, 0
	MOVF        R0, 0 
	MOVWF       R2 
	MOVF        R1, 0 
	MOVWF       R3 
	RLCF        R2, 1 
	BCF         R2, 0 
	RLCF        R3, 1 
	RLCF        R2, 1 
	BCF         R2, 0 
	RLCF        R3, 1 
	MOVLW       main_X_L0+0
	ADDWF       R2, 0 
	MOVWF       FSR1L 
	MOVLW       hi_addr(main_X_L0+0)
	ADDWFC      R3, 0 
	MOVWF       FSR1H 
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_v_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_v_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       POSTINC1+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       POSTINC1+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       POSTINC1+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       POSTINC1+0 
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
	GOTO        L_main23
L_main24:
;FHT-CT-R2.c,83 :: 		for (i=0;i<N/2;i++){
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main26:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main58
	MOVLW       64
	SUBWF       main_i_L0+0, 0 
L__main58:
	BTFSC       STATUS+0, 0 
	GOTO        L_main27
;FHT-CT-R2.c,84 :: 		C[i]=cos(i*2*pi/N);
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_C_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_C_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	CALL        _Word2Double+0, 0
	MOVLW       219
	MOVWF       R4 
	MOVLW       15
	MOVWF       R5 
	MOVLW       73
	MOVWF       R6 
	MOVLW       128
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVLW       0
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVLW       0
	MOVWF       R6 
	MOVLW       134
	MOVWF       R7 
	CALL        _Div_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       FARG_cos_f+0 
	MOVF        R1, 0 
	MOVWF       FARG_cos_f+1 
	MOVF        R2, 0 
	MOVWF       FARG_cos_f+2 
	MOVF        R3, 0 
	MOVWF       FARG_cos_f+3 
	CALL        _cos+0, 0
	MOVFF       FLOC__main+0, FSR1L
	MOVFF       FLOC__main+1, FSR1H
	MOVF        R0, 0 
	MOVWF       POSTINC1+0 
	MOVF        R1, 0 
	MOVWF       POSTINC1+0 
	MOVF        R2, 0 
	MOVWF       POSTINC1+0 
	MOVF        R3, 0 
	MOVWF       POSTINC1+0 
;FHT-CT-R2.c,85 :: 		S[i]=sin(i*2*pi/N);
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_S_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_S_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	CALL        _Word2Double+0, 0
	MOVLW       219
	MOVWF       R4 
	MOVLW       15
	MOVWF       R5 
	MOVLW       73
	MOVWF       R6 
	MOVLW       128
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVLW       0
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVLW       0
	MOVWF       R6 
	MOVLW       134
	MOVWF       R7 
	CALL        _Div_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       FARG_sin_f+0 
	MOVF        R1, 0 
	MOVWF       FARG_sin_f+1 
	MOVF        R2, 0 
	MOVWF       FARG_sin_f+2 
	MOVF        R3, 0 
	MOVWF       FARG_sin_f+3 
	CALL        _sin+0, 0
	MOVFF       FLOC__main+0, FSR1L
	MOVFF       FLOC__main+1, FSR1H
	MOVF        R0, 0 
	MOVWF       POSTINC1+0 
	MOVF        R1, 0 
	MOVWF       POSTINC1+0 
	MOVF        R2, 0 
	MOVWF       POSTINC1+0 
	MOVF        R3, 0 
	MOVWF       POSTINC1+0 
;FHT-CT-R2.c,83 :: 		for (i=0;i<N/2;i++){
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
;FHT-CT-R2.c,86 :: 		}
	GOTO        L_main26
L_main27:
;FHT-CT-R2.c,89 :: 		for (P=N;P>=2;P=P/2){
	MOVLW       128
	MOVWF       main_P_L0+0 
	MOVLW       0
	MOVWF       main_P_L0+1 
L_main29:
	MOVLW       0
	SUBWF       main_P_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main59
	MOVLW       2
	SUBWF       main_P_L0+0, 0 
L__main59:
	BTFSS       STATUS+0, 0 
	GOTO        L_main30
;FHT-CT-R2.c,90 :: 		NP = (N/P);  // Comprimento da DFT decomposta
	MOVF        main_P_L0+0, 0 
	MOVWF       R4 
	MOVF        main_P_L0+1, 0 
	MOVWF       R5 
	MOVLW       128
	MOVWF       R0 
	MOVLW       0
	MOVWF       R1 
	CALL        _Div_16x16_U+0, 0
	MOVF        R0, 0 
	MOVWF       main_NP_L0+0 
	MOVF        R1, 0 
	MOVWF       main_NP_L0+1 
;FHT-CT-R2.c,91 :: 		L=P/2;          // Limite para deslocamentos da Butterfly do nível atual
	MOVF        main_P_L0+0, 0 
	MOVWF       main_L_L0+0 
	MOVF        main_P_L0+1, 0 
	MOVWF       main_L_L0+1 
	RRCF        main_L_L0+1, 1 
	RRCF        main_L_L0+0, 1 
	BCF         main_L_L0+1, 7 
;FHT-CT-R2.c,92 :: 		desl = 2*NP;    // Fator de deslocamento interno do nível
	MOVF        R0, 0 
	MOVWF       main_desl_L0+0 
	MOVF        R1, 0 
	MOVWF       main_desl_L0+1 
	RLCF        main_desl_L0+0, 1 
	BCF         main_desl_L0+0, 0 
	RLCF        main_desl_L0+1, 1 
;FHT-CT-R2.c,94 :: 		for (k=0;k<NP;k++){ // Desloca grupo de butterflys
	CLRF        main_k_L0+0 
	CLRF        main_k_L0+1 
L_main32:
	MOVF        main_NP_L0+1, 0 
	SUBWF       main_k_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main60
	MOVF        main_NP_L0+0, 0 
	SUBWF       main_k_L0+0, 0 
L__main60:
	BTFSC       STATUS+0, 0 
	GOTO        L_main33
;FHT-CT-R2.c,95 :: 		for (i=0;i<L;i++){ // Desloca Butterfly
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main35:
	MOVF        main_L_L0+1, 0 
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main61
	MOVF        main_L_L0+0, 0 
	SUBWF       main_i_L0+0, 0 
L__main61:
	BTFSC       STATUS+0, 0 
	GOTO        L_main36
;FHT-CT-R2.c,97 :: 		_a=X[k+i*desl];
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	MOVF        main_desl_L0+0, 0 
	MOVWF       R4 
	MOVF        main_desl_L0+1, 0 
	MOVWF       R5 
	CALL        _Mul_16x16_U+0, 0
	MOVF        R0, 0 
	ADDWF       main_k_L0+0, 0 
	MOVWF       R5 
	MOVF        R1, 0 
	ADDWFC      main_k_L0+1, 0 
	MOVWF       R6 
	MOVF        R5, 0 
	MOVWF       R2 
	MOVF        R6, 0 
	MOVWF       R3 
	RLCF        R2, 1 
	BCF         R2, 0 
	RLCF        R3, 1 
	RLCF        R2, 1 
	BCF         R2, 0 
	RLCF        R3, 1 
	MOVLW       main_X_L0+0
	ADDWF       R2, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_X_L0+0)
	ADDWFC      R3, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       main__a_L0+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       main__a_L0+1 
	MOVF        POSTINC0+0, 0 
	MOVWF       main__a_L0+2 
	MOVF        POSTINC0+0, 0 
	MOVWF       main__a_L0+3 
;FHT-CT-R2.c,98 :: 		_b=X[k+NP+i*desl]*C[k*P/2];
	MOVF        main_NP_L0+0, 0 
	ADDWF       main_k_L0+0, 0 
	MOVWF       R2 
	MOVF        main_NP_L0+1, 0 
	ADDWFC      main_k_L0+1, 0 
	MOVWF       R3 
	MOVF        R0, 0 
	ADDWF       R2, 0 
	MOVWF       R4 
	MOVF        R1, 0 
	ADDWFC      R3, 0 
	MOVWF       R5 
	MOVF        R4, 0 
	MOVWF       R0 
	MOVF        R5, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_X_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_X_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       FLOC__main+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       FLOC__main+1 
	MOVF        POSTINC0+0, 0 
	MOVWF       FLOC__main+2 
	MOVF        POSTINC0+0, 0 
	MOVWF       FLOC__main+3 
	MOVF        main_k_L0+0, 0 
	MOVWF       R0 
	MOVF        main_k_L0+1, 0 
	MOVWF       R1 
	MOVF        main_P_L0+0, 0 
	MOVWF       R4 
	MOVF        main_P_L0+1, 0 
	MOVWF       R5 
	CALL        _Mul_16x16_U+0, 0
	MOVF        R0, 0 
	MOVWF       R3 
	MOVF        R1, 0 
	MOVWF       R4 
	RRCF        R4, 1 
	RRCF        R3, 1 
	BCF         R4, 7 
	MOVF        R3, 0 
	MOVWF       R0 
	MOVF        R4, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_C_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR2L 
	MOVLW       hi_addr(main_C_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR2H 
	MOVFF       FSR2L, FSR0L
	MOVFF       FSR2H, FSR0H
	MOVF        POSTINC0+0, 0 
	MOVWF       R0 
	MOVF        POSTINC0+0, 0 
	MOVWF       R1 
	MOVF        POSTINC0+0, 0 
	MOVWF       R2 
	MOVF        POSTINC0+0, 0 
	MOVWF       R3 
	MOVF        FLOC__main+0, 0 
	MOVWF       R4 
	MOVF        FLOC__main+1, 0 
	MOVWF       R5 
	MOVF        FLOC__main+2, 0 
	MOVWF       R6 
	MOVF        FLOC__main+3, 0 
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       main__b_L0+0 
	MOVF        R1, 0 
	MOVWF       main__b_L0+1 
	MOVF        R2, 0 
	MOVWF       main__b_L0+2 
	MOVF        R3, 0 
	MOVWF       main__b_L0+3 
;FHT-CT-R2.c,99 :: 		_c=X[Complemento(k,NP)+NP+i*desl]*S[k*P/2];
	MOVF        main_k_L0+0, 0 
	MOVWF       FARG_Complemento_K+0 
	MOVF        main_k_L0+1, 0 
	MOVWF       FARG_Complemento_K+1 
	MOVF        main_NP_L0+0, 0 
	MOVWF       FARG_Complemento_L+0 
	MOVF        main_NP_L0+1, 0 
	MOVWF       FARG_Complemento_L+1 
	CALL        _Complemento+0, 0
	MOVF        main_NP_L0+0, 0 
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVF        main_NP_L0+1, 0 
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	MOVF        main_desl_L0+0, 0 
	MOVWF       R4 
	MOVF        main_desl_L0+1, 0 
	MOVWF       R5 
	CALL        _Mul_16x16_U+0, 0
	MOVF        R0, 0 
	MOVWF       FLOC__main+8 
	MOVF        R1, 0 
	MOVWF       FLOC__main+9 
	MOVF        FLOC__main+8, 0 
	ADDWF       FLOC__main+0, 0 
	MOVWF       R3 
	MOVF        FLOC__main+9, 0 
	ADDWFC      FLOC__main+1, 0 
	MOVWF       R4 
	MOVF        R3, 0 
	MOVWF       R0 
	MOVF        R4, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_X_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_X_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       FLOC__main+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       FLOC__main+1 
	MOVF        POSTINC0+0, 0 
	MOVWF       FLOC__main+2 
	MOVF        POSTINC0+0, 0 
	MOVWF       FLOC__main+3 
	MOVF        main_k_L0+0, 0 
	MOVWF       R0 
	MOVF        main_k_L0+1, 0 
	MOVWF       R1 
	MOVF        main_P_L0+0, 0 
	MOVWF       R4 
	MOVF        main_P_L0+1, 0 
	MOVWF       R5 
	CALL        _Mul_16x16_U+0, 0
	MOVF        R0, 0 
	MOVWF       R3 
	MOVF        R1, 0 
	MOVWF       R4 
	RRCF        R4, 1 
	RRCF        R3, 1 
	BCF         R4, 7 
	MOVF        R3, 0 
	MOVWF       R0 
	MOVF        R4, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_S_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR2L 
	MOVLW       hi_addr(main_S_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR2H 
	MOVFF       FSR2L, FSR0L
	MOVFF       FSR2H, FSR0H
	MOVF        POSTINC0+0, 0 
	MOVWF       R0 
	MOVF        POSTINC0+0, 0 
	MOVWF       R1 
	MOVF        POSTINC0+0, 0 
	MOVWF       R2 
	MOVF        POSTINC0+0, 0 
	MOVWF       R3 
	MOVF        FLOC__main+0, 0 
	MOVWF       R4 
	MOVF        FLOC__main+1, 0 
	MOVWF       R5 
	MOVF        FLOC__main+2, 0 
	MOVWF       R6 
	MOVF        FLOC__main+3, 0 
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       FLOC__main+4 
	MOVF        R1, 0 
	MOVWF       FLOC__main+5 
	MOVF        R2, 0 
	MOVWF       FLOC__main+6 
	MOVF        R3, 0 
	MOVWF       FLOC__main+7 
	MOVF        FLOC__main+4, 0 
	MOVWF       main__c_L0+0 
	MOVF        FLOC__main+5, 0 
	MOVWF       main__c_L0+1 
	MOVF        FLOC__main+6, 0 
	MOVWF       main__c_L0+2 
	MOVF        FLOC__main+7, 0 
	MOVWF       main__c_L0+3 
;FHT-CT-R2.c,101 :: 		v[k+i*desl]=_a+_b+_c;
	MOVF        FLOC__main+8, 0 
	ADDWF       main_k_L0+0, 0 
	MOVWF       R3 
	MOVF        FLOC__main+9, 0 
	ADDWFC      main_k_L0+1, 0 
	MOVWF       R4 
	MOVF        R3, 0 
	MOVWF       R0 
	MOVF        R4, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_v_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_v_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main__a_L0+0, 0 
	MOVWF       R0 
	MOVF        main__a_L0+1, 0 
	MOVWF       R1 
	MOVF        main__a_L0+2, 0 
	MOVWF       R2 
	MOVF        main__a_L0+3, 0 
	MOVWF       R3 
	MOVF        main__b_L0+0, 0 
	MOVWF       R4 
	MOVF        main__b_L0+1, 0 
	MOVWF       R5 
	MOVF        main__b_L0+2, 0 
	MOVWF       R6 
	MOVF        main__b_L0+3, 0 
	MOVWF       R7 
	CALL        _Add_32x32_FP+0, 0
	MOVF        FLOC__main+4, 0 
	MOVWF       R4 
	MOVF        FLOC__main+5, 0 
	MOVWF       R5 
	MOVF        FLOC__main+6, 0 
	MOVWF       R6 
	MOVF        FLOC__main+7, 0 
	MOVWF       R7 
	CALL        _Add_32x32_FP+0, 0
	MOVFF       FLOC__main+0, FSR1L
	MOVFF       FLOC__main+1, FSR1H
	MOVF        R0, 0 
	MOVWF       POSTINC1+0 
	MOVF        R1, 0 
	MOVWF       POSTINC1+0 
	MOVF        R2, 0 
	MOVWF       POSTINC1+0 
	MOVF        R3, 0 
	MOVWF       POSTINC1+0 
;FHT-CT-R2.c,102 :: 		v[k+NP+i*desl]=_a-_b-_c;
	MOVF        main_NP_L0+0, 0 
	ADDWF       main_k_L0+0, 0 
	MOVWF       FLOC__main+0 
	MOVF        main_NP_L0+1, 0 
	ADDWFC      main_k_L0+1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	MOVF        main_desl_L0+0, 0 
	MOVWF       R4 
	MOVF        main_desl_L0+1, 0 
	MOVWF       R5 
	CALL        _Mul_16x16_U+0, 0
	MOVF        R0, 0 
	ADDWF       FLOC__main+0, 0 
	MOVWF       R3 
	MOVF        R1, 0 
	ADDWFC      FLOC__main+1, 0 
	MOVWF       R4 
	MOVF        R3, 0 
	MOVWF       R0 
	MOVF        R4, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_v_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_v_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main__b_L0+0, 0 
	MOVWF       R4 
	MOVF        main__b_L0+1, 0 
	MOVWF       R5 
	MOVF        main__b_L0+2, 0 
	MOVWF       R6 
	MOVF        main__b_L0+3, 0 
	MOVWF       R7 
	MOVF        main__a_L0+0, 0 
	MOVWF       R0 
	MOVF        main__a_L0+1, 0 
	MOVWF       R1 
	MOVF        main__a_L0+2, 0 
	MOVWF       R2 
	MOVF        main__a_L0+3, 0 
	MOVWF       R3 
	CALL        _Sub_32x32_FP+0, 0
	MOVF        main__c_L0+0, 0 
	MOVWF       R4 
	MOVF        main__c_L0+1, 0 
	MOVWF       R5 
	MOVF        main__c_L0+2, 0 
	MOVWF       R6 
	MOVF        main__c_L0+3, 0 
	MOVWF       R7 
	CALL        _Sub_32x32_FP+0, 0
	MOVFF       FLOC__main+0, FSR1L
	MOVFF       FLOC__main+1, FSR1H
	MOVF        R0, 0 
	MOVWF       POSTINC1+0 
	MOVF        R1, 0 
	MOVWF       POSTINC1+0 
	MOVF        R2, 0 
	MOVWF       POSTINC1+0 
	MOVF        R3, 0 
	MOVWF       POSTINC1+0 
;FHT-CT-R2.c,95 :: 		for (i=0;i<L;i++){ // Desloca Butterfly
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
;FHT-CT-R2.c,103 :: 		}
	GOTO        L_main35
L_main36:
;FHT-CT-R2.c,94 :: 		for (k=0;k<NP;k++){ // Desloca grupo de butterflys
	INFSNZ      main_k_L0+0, 1 
	INCF        main_k_L0+1, 1 
;FHT-CT-R2.c,104 :: 		}
	GOTO        L_main32
L_main33:
;FHT-CT-R2.c,105 :: 		for (i=0;i<N;i++) X[i]=v[i];
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main38:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main62
	MOVLW       128
	SUBWF       main_i_L0+0, 0 
L__main62:
	BTFSC       STATUS+0, 0 
	GOTO        L_main39
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_X_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR1L 
	MOVLW       hi_addr(main_X_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR1H 
	MOVLW       main_v_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_v_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       POSTINC1+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       POSTINC1+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       POSTINC1+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       POSTINC1+0 
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
	GOTO        L_main38
L_main39:
;FHT-CT-R2.c,89 :: 		for (P=N;P>=2;P=P/2){
	RRCF        main_P_L0+1, 1 
	RRCF        main_P_L0+0, 1 
	BCF         main_P_L0+1, 7 
;FHT-CT-R2.c,106 :: 		}
	GOTO        L_main29
L_main30:
;FHT-CT-R2.c,108 :: 		for (i=0;i<N;i++) X[i]=2*X[i]/N;
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main41:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main63
	MOVLW       128
	SUBWF       main_i_L0+0, 0 
L__main63:
	BTFSC       STATUS+0, 0 
	GOTO        L_main42
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_X_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_X_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVFF       FLOC__main+0, FSR0L
	MOVFF       FLOC__main+1, FSR0H
	MOVF        POSTINC0+0, 0 
	MOVWF       R0 
	MOVF        POSTINC0+0, 0 
	MOVWF       R1 
	MOVF        POSTINC0+0, 0 
	MOVWF       R2 
	MOVF        POSTINC0+0, 0 
	MOVWF       R3 
	MOVLW       0
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVLW       0
	MOVWF       R6 
	MOVLW       128
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVLW       0
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVLW       0
	MOVWF       R6 
	MOVLW       134
	MOVWF       R7 
	CALL        _Div_32x32_FP+0, 0
	MOVFF       FLOC__main+0, FSR1L
	MOVFF       FLOC__main+1, FSR1H
	MOVF        R0, 0 
	MOVWF       POSTINC1+0 
	MOVF        R1, 0 
	MOVWF       POSTINC1+0 
	MOVF        R2, 0 
	MOVWF       POSTINC1+0 
	MOVF        R3, 0 
	MOVWF       POSTINC1+0 
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
	GOTO        L_main41
L_main42:
;FHT-CT-R2.c,110 :: 		for (i=1;i<N/2;i++){
	MOVLW       1
	MOVWF       main_i_L0+0 
	MOVLW       0
	MOVWF       main_i_L0+1 
L_main44:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main64
	MOVLW       64
	SUBWF       main_i_L0+0, 0 
L__main64:
	BTFSC       STATUS+0, 0 
	GOTO        L_main45
;FHT-CT-R2.c,111 :: 		X[i]=(sqrt(2)/2)*sqrt(X[i]*X[i]+X[N-i]*X[N-i]);
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_X_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+8 
	MOVLW       hi_addr(main_X_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+9 
	MOVLW       0
	MOVWF       FARG_sqrt_x+0 
	MOVLW       0
	MOVWF       FARG_sqrt_x+1 
	MOVLW       0
	MOVWF       FARG_sqrt_x+2 
	MOVLW       128
	MOVWF       FARG_sqrt_x+3 
	CALL        _sqrt+0, 0
	MOVLW       0
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVLW       0
	MOVWF       R6 
	MOVLW       128
	MOVWF       R7 
	CALL        _Div_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       FLOC__main+4 
	MOVF        R1, 0 
	MOVWF       FLOC__main+5 
	MOVF        R2, 0 
	MOVWF       FLOC__main+6 
	MOVF        R3, 0 
	MOVWF       FLOC__main+7 
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_X_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR2L 
	MOVLW       hi_addr(main_X_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR2H 
	MOVFF       FSR2L, FSR0L
	MOVFF       FSR2H, FSR0H
	MOVF        POSTINC0+0, 0 
	MOVWF       R0 
	MOVF        POSTINC0+0, 0 
	MOVWF       R1 
	MOVF        POSTINC0+0, 0 
	MOVWF       R2 
	MOVF        POSTINC0+0, 0 
	MOVWF       R3 
	MOVF        R0, 0 
	MOVWF       R4 
	MOVF        R1, 0 
	MOVWF       R5 
	MOVF        R2, 0 
	MOVWF       R6 
	MOVF        R3, 0 
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       FLOC__main+0 
	MOVF        R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        R2, 0 
	MOVWF       FLOC__main+2 
	MOVF        R3, 0 
	MOVWF       FLOC__main+3 
	MOVF        main_i_L0+0, 0 
	SUBLW       128
	MOVWF       R3 
	MOVF        main_i_L0+1, 0 
	MOVWF       R4 
	MOVLW       0
	SUBFWB      R4, 1 
	MOVF        R3, 0 
	MOVWF       R0 
	MOVF        R4, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_X_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR2L 
	MOVLW       hi_addr(main_X_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR2H 
	MOVFF       FSR2L, FSR0L
	MOVFF       FSR2H, FSR0H
	MOVF        POSTINC0+0, 0 
	MOVWF       R0 
	MOVF        POSTINC0+0, 0 
	MOVWF       R1 
	MOVF        POSTINC0+0, 0 
	MOVWF       R2 
	MOVF        POSTINC0+0, 0 
	MOVWF       R3 
	MOVF        R0, 0 
	MOVWF       R4 
	MOVF        R1, 0 
	MOVWF       R5 
	MOVF        R2, 0 
	MOVWF       R6 
	MOVF        R3, 0 
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVF        FLOC__main+0, 0 
	MOVWF       R4 
	MOVF        FLOC__main+1, 0 
	MOVWF       R5 
	MOVF        FLOC__main+2, 0 
	MOVWF       R6 
	MOVF        FLOC__main+3, 0 
	MOVWF       R7 
	CALL        _Add_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       FARG_sqrt_x+0 
	MOVF        R1, 0 
	MOVWF       FARG_sqrt_x+1 
	MOVF        R2, 0 
	MOVWF       FARG_sqrt_x+2 
	MOVF        R3, 0 
	MOVWF       FARG_sqrt_x+3 
	CALL        _sqrt+0, 0
	MOVF        FLOC__main+4, 0 
	MOVWF       R4 
	MOVF        FLOC__main+5, 0 
	MOVWF       R5 
	MOVF        FLOC__main+6, 0 
	MOVWF       R6 
	MOVF        FLOC__main+7, 0 
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVFF       FLOC__main+8, FSR1L
	MOVFF       FLOC__main+9, FSR1H
	MOVF        R0, 0 
	MOVWF       POSTINC1+0 
	MOVF        R1, 0 
	MOVWF       POSTINC1+0 
	MOVF        R2, 0 
	MOVWF       POSTINC1+0 
	MOVF        R3, 0 
	MOVWF       POSTINC1+0 
;FHT-CT-R2.c,110 :: 		for (i=1;i<N/2;i++){
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
;FHT-CT-R2.c,113 :: 		}
	GOTO        L_main44
L_main45:
;FHT-CT-R2.c,114 :: 		}while(1);
	GOTO        L_main16
;FHT-CT-R2.c,116 :: 		}
	GOTO        $+0
; end of _main
