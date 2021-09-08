
_Table_Reverse:

;Cooley-Tukey-R2.c,25 :: 		unsigned int Table_Reverse(unsigned int index, unsigned int Lenght){
;Cooley-Tukey-R2.c,27 :: 		switch (Lenght){
	GOTO        L_Table_Reverse0
;Cooley-Tukey-R2.c,28 :: 		case 8:
L_Table_Reverse2:
;Cooley-Tukey-R2.c,29 :: 		Lim=3;
	MOVLW       3
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;Cooley-Tukey-R2.c,30 :: 		break;
	GOTO        L_Table_Reverse1
;Cooley-Tukey-R2.c,31 :: 		case 16:
L_Table_Reverse3:
;Cooley-Tukey-R2.c,32 :: 		Lim=4;
	MOVLW       4
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;Cooley-Tukey-R2.c,33 :: 		break;
	GOTO        L_Table_Reverse1
;Cooley-Tukey-R2.c,34 :: 		case 32:
L_Table_Reverse4:
;Cooley-Tukey-R2.c,35 :: 		Lim=5;
	MOVLW       5
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;Cooley-Tukey-R2.c,36 :: 		break;
	GOTO        L_Table_Reverse1
;Cooley-Tukey-R2.c,37 :: 		case 64:
L_Table_Reverse5:
;Cooley-Tukey-R2.c,38 :: 		Lim=6;
	MOVLW       6
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;Cooley-Tukey-R2.c,39 :: 		break;
	GOTO        L_Table_Reverse1
;Cooley-Tukey-R2.c,40 :: 		case 128:
L_Table_Reverse6:
;Cooley-Tukey-R2.c,41 :: 		Lim=7;
	MOVLW       7
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;Cooley-Tukey-R2.c,42 :: 		break;
	GOTO        L_Table_Reverse1
;Cooley-Tukey-R2.c,43 :: 		case 256:
L_Table_Reverse7:
;Cooley-Tukey-R2.c,44 :: 		Lim=8;
	MOVLW       8
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;Cooley-Tukey-R2.c,45 :: 		break;
	GOTO        L_Table_Reverse1
;Cooley-Tukey-R2.c,46 :: 		case 512:
L_Table_Reverse8:
;Cooley-Tukey-R2.c,47 :: 		Lim=9;
	MOVLW       9
	MOVWF       R6 
	MOVLW       0
	MOVWF       R7 
;Cooley-Tukey-R2.c,48 :: 		break;
	GOTO        L_Table_Reverse1
;Cooley-Tukey-R2.c,49 :: 		}
L_Table_Reverse0:
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse37
	MOVLW       8
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse37:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse2
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse38
	MOVLW       16
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse38:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse3
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse39
	MOVLW       32
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse39:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse4
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse40
	MOVLW       64
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse40:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse5
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse41
	MOVLW       128
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse41:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse6
	MOVF        FARG_Table_Reverse_Lenght+1, 0 
	XORLW       1
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse42
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse42:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse7
	MOVF        FARG_Table_Reverse_Lenght+1, 0 
	XORLW       2
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse43
	MOVLW       0
	XORWF       FARG_Table_Reverse_Lenght+0, 0 
L__Table_Reverse43:
	BTFSC       STATUS+0, 2 
	GOTO        L_Table_Reverse8
L_Table_Reverse1:
;Cooley-Tukey-R2.c,50 :: 		mirror = 0;
	CLRF        R2 
	CLRF        R3 
;Cooley-Tukey-R2.c,51 :: 		for (exp=0;exp<Lim;exp++){
	CLRF        R4 
	CLRF        R5 
L_Table_Reverse9:
	MOVF        R7, 0 
	SUBWF       R5, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__Table_Reverse44
	MOVF        R6, 0 
	SUBWF       R4, 0 
L__Table_Reverse44:
	BTFSC       STATUS+0, 0 
	GOTO        L_Table_Reverse10
;Cooley-Tukey-R2.c,52 :: 		mirror=mirror<<1;
	RLCF        R2, 1 
	BCF         R2, 0 
	RLCF        R3, 1 
;Cooley-Tukey-R2.c,53 :: 		mirror+=(0x01&index);
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
;Cooley-Tukey-R2.c,54 :: 		index=index>>1;
	RRCF        FARG_Table_Reverse_index+1, 1 
	RRCF        FARG_Table_Reverse_index+0, 1 
	BCF         FARG_Table_Reverse_index+1, 7 
;Cooley-Tukey-R2.c,51 :: 		for (exp=0;exp<Lim;exp++){
	INFSNZ      R4, 1 
	INCF        R5, 1 
;Cooley-Tukey-R2.c,55 :: 		}
	GOTO        L_Table_Reverse9
L_Table_Reverse10:
;Cooley-Tukey-R2.c,56 :: 		return mirror;
	MOVF        R2, 0 
	MOVWF       R0 
	MOVF        R3, 0 
	MOVWF       R1 
;Cooley-Tukey-R2.c,57 :: 		}
	RETURN      0
; end of _Table_Reverse

_main:

;Cooley-Tukey-R2.c,59 :: 		main(){
;Cooley-Tukey-R2.c,63 :: 		double pi_N=2*pi/N;       // Auxiliar Pi*n
	MOVLW       219
	MOVWF       main_pi_N_L0+0 
	MOVLW       15
	MOVWF       main_pi_N_L0+1 
	MOVLW       73
	MOVWF       main_pi_N_L0+2 
	MOVLW       122
	MOVWF       main_pi_N_L0+3 
;Cooley-Tukey-R2.c,68 :: 		ADCON1 = 14;
	MOVLW       14
	MOVWF       ADCON1+0 
;Cooley-Tukey-R2.c,69 :: 		TRISA = 1;
	MOVLW       1
	MOVWF       TRISA+0 
;Cooley-Tukey-R2.c,70 :: 		TRISB = 0;
	CLRF        TRISB+0 
;Cooley-Tukey-R2.c,71 :: 		PORTA = 0;
	CLRF        PORTA+0 
;Cooley-Tukey-R2.c,72 :: 		PORTB = 0;
	CLRF        PORTB+0 
;Cooley-Tukey-R2.c,74 :: 		do{
L_main12:
;Cooley-Tukey-R2.c,75 :: 		PORTB=255;
	MOVLW       255
	MOVWF       PORTB+0 
;Cooley-Tukey-R2.c,77 :: 		for (i=0;i<N;i++){  // ~ 7.2 ms
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main15:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main45
	MOVLW       128
	SUBWF       main_i_L0+0, 0 
L__main45:
	BTFSC       STATUS+0, 0 
	GOTO        L_main16
;Cooley-Tukey-R2.c,78 :: 		Ximag[i]=(5/1023)*ADC_Read(0);
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
	MOVLW       main_Ximag_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_Ximag_L0+0)
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
;Cooley-Tukey-R2.c,79 :: 		Delay_us(50);
	MOVLW       83
	MOVWF       R13, 0
L_main18:
	DECFSZ      R13, 1, 0
	BRA         L_main18
;Cooley-Tukey-R2.c,77 :: 		for (i=0;i<N;i++){  // ~ 7.2 ms
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
;Cooley-Tukey-R2.c,80 :: 		}
	GOTO        L_main15
L_main16:
;Cooley-Tukey-R2.c,81 :: 		PORTB=0;
	CLRF        PORTB+0 
;Cooley-Tukey-R2.c,83 :: 		for (i=0;i<N;i++){
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main19:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main46
	MOVLW       128
	SUBWF       main_i_L0+0, 0 
L__main46:
	BTFSC       STATUS+0, 0 
	GOTO        L_main20
;Cooley-Tukey-R2.c,84 :: 		Xreal[Table_Reverse(i,N)]=Ximag[i];
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
	MOVLW       main_Xreal_L0+0
	ADDWF       R2, 0 
	MOVWF       FSR1L 
	MOVLW       hi_addr(main_Xreal_L0+0)
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
	MOVLW       main_Ximag_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_Ximag_L0+0)
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
;Cooley-Tukey-R2.c,85 :: 		Ximag[i]=0;
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
	MOVLW       main_Ximag_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR1L 
	MOVLW       hi_addr(main_Ximag_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR1H 
	CLRF        POSTINC1+0 
	CLRF        POSTINC1+0 
	CLRF        POSTINC1+0 
	CLRF        POSTINC1+0 
;Cooley-Tukey-R2.c,83 :: 		for (i=0;i<N;i++){
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
;Cooley-Tukey-R2.c,86 :: 		}
	GOTO        L_main19
L_main20:
;Cooley-Tukey-R2.c,88 :: 		for (i=0;i<N/2;i++){
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main22:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main47
	MOVLW       64
	SUBWF       main_i_L0+0, 0 
L__main47:
	BTFSC       STATUS+0, 0 
	GOTO        L_main23
;Cooley-Tukey-R2.c,89 :: 		Wr[i] = cos(pi_N*i);
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
	MOVLW       main_Wr_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_Wr_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	CALL        _Word2Double+0, 0
	MOVF        main_pi_N_L0+0, 0 
	MOVWF       R4 
	MOVF        main_pi_N_L0+1, 0 
	MOVWF       R5 
	MOVF        main_pi_N_L0+2, 0 
	MOVWF       R6 
	MOVF        main_pi_N_L0+3, 0 
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
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
;Cooley-Tukey-R2.c,90 :: 		Wi[i] = -sin(pi_N*i);
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
	MOVLW       main_Wi_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_Wi_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_i_L0+0, 0 
	MOVWF       R0 
	MOVF        main_i_L0+1, 0 
	MOVWF       R1 
	CALL        _Word2Double+0, 0
	MOVF        main_pi_N_L0+0, 0 
	MOVWF       R4 
	MOVF        main_pi_N_L0+1, 0 
	MOVWF       R5 
	MOVF        main_pi_N_L0+2, 0 
	MOVWF       R6 
	MOVF        main_pi_N_L0+3, 0 
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       FARG_sin_f+0 
	MOVF        R1, 0 
	MOVWF       FARG_sin_f+1 
	MOVF        R2, 0 
	MOVWF       FARG_sin_f+2 
	MOVF        R3, 0 
	MOVWF       FARG_sin_f+3 
	CALL        _sin+0, 0
	BTG         R2, 7 
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
;Cooley-Tukey-R2.c,88 :: 		for (i=0;i<N/2;i++){
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
;Cooley-Tukey-R2.c,91 :: 		}
	GOTO        L_main22
L_main23:
;Cooley-Tukey-R2.c,93 :: 		for (P=N;P>=2;P=P/2){
	MOVLW       128
	MOVWF       main_P_L0+0 
	MOVLW       0
	MOVWF       main_P_L0+1 
L_main25:
	MOVLW       0
	SUBWF       main_P_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main48
	MOVLW       2
	SUBWF       main_P_L0+0, 0 
L__main48:
	BTFSS       STATUS+0, 0 
	GOTO        L_main26
;Cooley-Tukey-R2.c,94 :: 		NP = (N/P);                // Comprimento da DFT decomposta
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
;Cooley-Tukey-R2.c,96 :: 		for (k=0;k<NP;k++){
	CLRF        main_k_L0+0 
	CLRF        main_k_L0+1 
L_main28:
	MOVF        main_NP_L0+1, 0 
	SUBWF       main_k_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main49
	MOVF        main_NP_L0+0, 0 
	SUBWF       main_k_L0+0, 0 
L__main49:
	BTFSC       STATUS+0, 0 
	GOTO        L_main29
;Cooley-Tukey-R2.c,97 :: 		L=(P/2)-1;             // Limite para deslocamentos da Butterfly do nível atual
	MOVF        main_P_L0+0, 0 
	MOVWF       main_L_L0+0 
	MOVF        main_P_L0+1, 0 
	MOVWF       main_L_L0+1 
	RRCF        main_L_L0+1, 1 
	RRCF        main_L_L0+0, 1 
	BCF         main_L_L0+1, 7 
	MOVLW       1
	SUBWF       main_L_L0+0, 1 
	MOVLW       0
	SUBWFB      main_L_L0+1, 1 
;Cooley-Tukey-R2.c,98 :: 		desl = 2*NP;           // Fator de deslocamento interno do nível
	MOVF        main_NP_L0+0, 0 
	MOVWF       main_desl_L0+0 
	MOVF        main_NP_L0+1, 0 
	MOVWF       main_desl_L0+1 
	RLCF        main_desl_L0+0, 1 
	BCF         main_desl_L0+0, 0 
	RLCF        main_desl_L0+1, 1 
;Cooley-Tukey-R2.c,99 :: 		Aux1=k*P/2;
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
	MOVWF       main_Aux1_L0+0 
	MOVF        R1, 0 
	MOVWF       main_Aux1_L0+1 
	RRCF        main_Aux1_L0+1, 1 
	RRCF        main_Aux1_L0+0, 1 
	BCF         main_Aux1_L0+1, 7 
;Cooley-Tukey-R2.c,100 :: 		for (i=0;i<=L;i++){
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main31:
	MOVF        main_i_L0+1, 0 
	SUBWF       main_L_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main50
	MOVF        main_i_L0+0, 0 
	SUBWF       main_L_L0+0, 0 
L__main50:
	BTFSS       STATUS+0, 0 
	GOTO        L_main32
;Cooley-Tukey-R2.c,102 :: 		Aux2=k+i*desl;
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
	MOVWF       R3 
	MOVF        R1, 0 
	ADDWFC      main_k_L0+1, 0 
	MOVWF       R4 
	MOVF        R3, 0 
	MOVWF       main_Aux2_L0+0 
	MOVF        R4, 0 
	MOVWF       main_Aux2_L0+1 
;Cooley-Tukey-R2.c,103 :: 		aar=Xreal[Aux2];
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
	MOVLW       main_Xreal_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_Xreal_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_aar_L0+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_aar_L0+1 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_aar_L0+2 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_aar_L0+3 
;Cooley-Tukey-R2.c,104 :: 		aai=Ximag[Aux2];
	MOVLW       main_Ximag_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_Ximag_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_aai_L0+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_aai_L0+1 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_aai_L0+2 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_aai_L0+3 
;Cooley-Tukey-R2.c,105 :: 		bbr=Xreal[NP+Aux2];
	MOVF        main_NP_L0+0, 0 
	ADDWF       R3, 1 
	MOVF        main_NP_L0+1, 0 
	ADDWFC      R4, 1 
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
	MOVLW       main_Xreal_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_Xreal_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       R4 
	MOVF        POSTINC0+0, 0 
	MOVWF       R5 
	MOVF        POSTINC0+0, 0 
	MOVWF       R6 
	MOVF        POSTINC0+0, 0 
	MOVWF       R7 
	MOVF        R4, 0 
	MOVWF       main_bbr_L0+0 
	MOVF        R5, 0 
	MOVWF       main_bbr_L0+1 
	MOVF        R6, 0 
	MOVWF       main_bbr_L0+2 
	MOVF        R7, 0 
	MOVWF       main_bbr_L0+3 
;Cooley-Tukey-R2.c,106 :: 		bbi=Ximag[NP+Aux2];
	MOVLW       main_Ximag_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_Ximag_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_bbi_L0+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_bbi_L0+1 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_bbi_L0+2 
	MOVF        POSTINC0+0, 0 
	MOVWF       main_bbi_L0+3 
;Cooley-Tukey-R2.c,108 :: 		Br=bbr*Wr[Aux1]-bbi*Wi[Aux1];
	MOVF        main_Aux1_L0+0, 0 
	MOVWF       FLOC__main+0 
	MOVF        main_Aux1_L0+1, 0 
	MOVWF       FLOC__main+1 
	RLCF        FLOC__main+0, 1 
	BCF         FLOC__main+0, 0 
	RLCF        FLOC__main+1, 1 
	RLCF        FLOC__main+0, 1 
	BCF         FLOC__main+0, 0 
	RLCF        FLOC__main+1, 1 
	MOVLW       main_Wr_L0+0
	ADDWF       FLOC__main+0, 0 
	MOVWF       FLOC__main+8 
	MOVLW       hi_addr(main_Wr_L0+0)
	ADDWFC      FLOC__main+1, 0 
	MOVWF       FLOC__main+9 
	MOVFF       FLOC__main+8, FSR0L
	MOVFF       FLOC__main+9, FSR0H
	MOVF        POSTINC0+0, 0 
	MOVWF       R0 
	MOVF        POSTINC0+0, 0 
	MOVWF       R1 
	MOVF        POSTINC0+0, 0 
	MOVWF       R2 
	MOVF        POSTINC0+0, 0 
	MOVWF       R3 
	CALL        _Mul_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       FLOC__main+4 
	MOVF        R1, 0 
	MOVWF       FLOC__main+5 
	MOVF        R2, 0 
	MOVWF       FLOC__main+6 
	MOVF        R3, 0 
	MOVWF       FLOC__main+7 
	MOVLW       main_Wi_L0+0
	ADDWF       FLOC__main+0, 1 
	MOVLW       hi_addr(main_Wi_L0+0)
	ADDWFC      FLOC__main+1, 1 
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
	MOVF        main_bbi_L0+0, 0 
	MOVWF       R4 
	MOVF        main_bbi_L0+1, 0 
	MOVWF       R5 
	MOVF        main_bbi_L0+2, 0 
	MOVWF       R6 
	MOVF        main_bbi_L0+3, 0 
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       R4 
	MOVF        R1, 0 
	MOVWF       R5 
	MOVF        R2, 0 
	MOVWF       R6 
	MOVF        R3, 0 
	MOVWF       R7 
	MOVF        FLOC__main+4, 0 
	MOVWF       R0 
	MOVF        FLOC__main+5, 0 
	MOVWF       R1 
	MOVF        FLOC__main+6, 0 
	MOVWF       R2 
	MOVF        FLOC__main+7, 0 
	MOVWF       R3 
	CALL        _Sub_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       main_Br_L0+0 
	MOVF        R1, 0 
	MOVWF       main_Br_L0+1 
	MOVF        R2, 0 
	MOVWF       main_Br_L0+2 
	MOVF        R3, 0 
	MOVWF       main_Br_L0+3 
;Cooley-Tukey-R2.c,109 :: 		Bi=bbr*Wi[Aux1]+bbi*Wr[Aux1];
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
	MOVF        main_bbr_L0+0, 0 
	MOVWF       R4 
	MOVF        main_bbr_L0+1, 0 
	MOVWF       R5 
	MOVF        main_bbr_L0+2, 0 
	MOVWF       R6 
	MOVF        main_bbr_L0+3, 0 
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
	MOVFF       FLOC__main+8, FSR0L
	MOVFF       FLOC__main+9, FSR0H
	MOVF        POSTINC0+0, 0 
	MOVWF       R0 
	MOVF        POSTINC0+0, 0 
	MOVWF       R1 
	MOVF        POSTINC0+0, 0 
	MOVWF       R2 
	MOVF        POSTINC0+0, 0 
	MOVWF       R3 
	MOVF        main_bbi_L0+0, 0 
	MOVWF       R4 
	MOVF        main_bbi_L0+1, 0 
	MOVWF       R5 
	MOVF        main_bbi_L0+2, 0 
	MOVWF       R6 
	MOVF        main_bbi_L0+3, 0 
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
	MOVWF       main_Bi_L0+0 
	MOVF        R1, 0 
	MOVWF       main_Bi_L0+1 
	MOVF        R2, 0 
	MOVWF       main_Bi_L0+2 
	MOVF        R3, 0 
	MOVWF       main_Bi_L0+3 
;Cooley-Tukey-R2.c,110 :: 		Xreal[Aux2]=aar+Br;
	MOVF        main_Aux2_L0+0, 0 
	MOVWF       R0 
	MOVF        main_Aux2_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_Xreal_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_Xreal_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_aar_L0+0, 0 
	MOVWF       R0 
	MOVF        main_aar_L0+1, 0 
	MOVWF       R1 
	MOVF        main_aar_L0+2, 0 
	MOVWF       R2 
	MOVF        main_aar_L0+3, 0 
	MOVWF       R3 
	MOVF        main_Br_L0+0, 0 
	MOVWF       R4 
	MOVF        main_Br_L0+1, 0 
	MOVWF       R5 
	MOVF        main_Br_L0+2, 0 
	MOVWF       R6 
	MOVF        main_Br_L0+3, 0 
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
;Cooley-Tukey-R2.c,111 :: 		Ximag[Aux2]=aai+Bi;
	MOVF        main_Aux2_L0+0, 0 
	MOVWF       R0 
	MOVF        main_Aux2_L0+1, 0 
	MOVWF       R1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	RLCF        R0, 1 
	BCF         R0, 0 
	RLCF        R1, 1 
	MOVLW       main_Ximag_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_Ximag_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_aai_L0+0, 0 
	MOVWF       R0 
	MOVF        main_aai_L0+1, 0 
	MOVWF       R1 
	MOVF        main_aai_L0+2, 0 
	MOVWF       R2 
	MOVF        main_aai_L0+3, 0 
	MOVWF       R3 
	MOVF        main_Bi_L0+0, 0 
	MOVWF       R4 
	MOVF        main_Bi_L0+1, 0 
	MOVWF       R5 
	MOVF        main_Bi_L0+2, 0 
	MOVWF       R6 
	MOVF        main_Bi_L0+3, 0 
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
;Cooley-Tukey-R2.c,112 :: 		Xreal[NP+Aux2]=aar-Br;
	MOVF        main_Aux2_L0+0, 0 
	ADDWF       main_NP_L0+0, 0 
	MOVWF       R3 
	MOVF        main_Aux2_L0+1, 0 
	ADDWFC      main_NP_L0+1, 0 
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
	MOVLW       main_Xreal_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_Xreal_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_Br_L0+0, 0 
	MOVWF       R4 
	MOVF        main_Br_L0+1, 0 
	MOVWF       R5 
	MOVF        main_Br_L0+2, 0 
	MOVWF       R6 
	MOVF        main_Br_L0+3, 0 
	MOVWF       R7 
	MOVF        main_aar_L0+0, 0 
	MOVWF       R0 
	MOVF        main_aar_L0+1, 0 
	MOVWF       R1 
	MOVF        main_aar_L0+2, 0 
	MOVWF       R2 
	MOVF        main_aar_L0+3, 0 
	MOVWF       R3 
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
;Cooley-Tukey-R2.c,113 :: 		Ximag[NP+Aux2]=aai-Bi;
	MOVF        main_Aux2_L0+0, 0 
	ADDWF       main_NP_L0+0, 0 
	MOVWF       R3 
	MOVF        main_Aux2_L0+1, 0 
	ADDWFC      main_NP_L0+1, 0 
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
	MOVLW       main_Ximag_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_Ximag_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        main_Bi_L0+0, 0 
	MOVWF       R4 
	MOVF        main_Bi_L0+1, 0 
	MOVWF       R5 
	MOVF        main_Bi_L0+2, 0 
	MOVWF       R6 
	MOVF        main_Bi_L0+3, 0 
	MOVWF       R7 
	MOVF        main_aai_L0+0, 0 
	MOVWF       R0 
	MOVF        main_aai_L0+1, 0 
	MOVWF       R1 
	MOVF        main_aai_L0+2, 0 
	MOVWF       R2 
	MOVF        main_aai_L0+3, 0 
	MOVWF       R3 
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
;Cooley-Tukey-R2.c,100 :: 		for (i=0;i<=L;i++){
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
;Cooley-Tukey-R2.c,114 :: 		}
	GOTO        L_main31
L_main32:
;Cooley-Tukey-R2.c,96 :: 		for (k=0;k<NP;k++){
	INFSNZ      main_k_L0+0, 1 
	INCF        main_k_L0+1, 1 
;Cooley-Tukey-R2.c,115 :: 		}
	GOTO        L_main28
L_main29:
;Cooley-Tukey-R2.c,93 :: 		for (P=N;P>=2;P=P/2){
	RRCF        main_P_L0+1, 1 
	RRCF        main_P_L0+0, 1 
	BCF         main_P_L0+1, 7 
;Cooley-Tukey-R2.c,116 :: 		}
	GOTO        L_main25
L_main26:
;Cooley-Tukey-R2.c,118 :: 		for (i=0;i<N;i++){
	CLRF        main_i_L0+0 
	CLRF        main_i_L0+1 
L_main34:
	MOVLW       0
	SUBWF       main_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main51
	MOVLW       128
	SUBWF       main_i_L0+0, 0 
L__main51:
	BTFSC       STATUS+0, 0 
	GOTO        L_main35
;Cooley-Tukey-R2.c,119 :: 		Xreal[i]=2*Xreal[i]/N;
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
	MOVLW       main_Xreal_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_Xreal_L0+0)
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
;Cooley-Tukey-R2.c,120 :: 		Ximag[i]=2*Ximag[i]/N;
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
	MOVLW       main_Ximag_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+0 
	MOVLW       hi_addr(main_Ximag_L0+0)
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
;Cooley-Tukey-R2.c,121 :: 		Xreal[i]=sqrt(pow(Xreal[i],2)+pow(Ximag[i],2));
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
	MOVLW       main_Xreal_L0+0
	ADDWF       R0, 0 
	MOVWF       FLOC__main+4 
	MOVLW       hi_addr(main_Xreal_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FLOC__main+5 
	MOVFF       FLOC__main+4, FSR0L
	MOVFF       FLOC__main+5, FSR0H
	MOVF        POSTINC0+0, 0 
	MOVWF       FARG_pow_x+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       FARG_pow_x+1 
	MOVF        POSTINC0+0, 0 
	MOVWF       FARG_pow_x+2 
	MOVF        POSTINC0+0, 0 
	MOVWF       FARG_pow_x+3 
	MOVLW       0
	MOVWF       FARG_pow_y+0 
	MOVLW       0
	MOVWF       FARG_pow_y+1 
	MOVLW       0
	MOVWF       FARG_pow_y+2 
	MOVLW       128
	MOVWF       FARG_pow_y+3 
	CALL        _pow+0, 0
	MOVF        R0, 0 
	MOVWF       FLOC__main+0 
	MOVF        R1, 0 
	MOVWF       FLOC__main+1 
	MOVF        R2, 0 
	MOVWF       FLOC__main+2 
	MOVF        R3, 0 
	MOVWF       FLOC__main+3 
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
	MOVLW       main_Ximag_L0+0
	ADDWF       R0, 0 
	MOVWF       FSR0L 
	MOVLW       hi_addr(main_Ximag_L0+0)
	ADDWFC      R1, 0 
	MOVWF       FSR0H 
	MOVF        POSTINC0+0, 0 
	MOVWF       FARG_pow_x+0 
	MOVF        POSTINC0+0, 0 
	MOVWF       FARG_pow_x+1 
	MOVF        POSTINC0+0, 0 
	MOVWF       FARG_pow_x+2 
	MOVF        POSTINC0+0, 0 
	MOVWF       FARG_pow_x+3 
	MOVLW       0
	MOVWF       FARG_pow_y+0 
	MOVLW       0
	MOVWF       FARG_pow_y+1 
	MOVLW       0
	MOVWF       FARG_pow_y+2 
	MOVLW       128
	MOVWF       FARG_pow_y+3 
	CALL        _pow+0, 0
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
	MOVFF       FLOC__main+4, FSR1L
	MOVFF       FLOC__main+5, FSR1H
	MOVF        R0, 0 
	MOVWF       POSTINC1+0 
	MOVF        R1, 0 
	MOVWF       POSTINC1+0 
	MOVF        R2, 0 
	MOVWF       POSTINC1+0 
	MOVF        R3, 0 
	MOVWF       POSTINC1+0 
;Cooley-Tukey-R2.c,118 :: 		for (i=0;i<N;i++){
	INFSNZ      main_i_L0+0, 1 
	INCF        main_i_L0+1, 1 
;Cooley-Tukey-R2.c,122 :: 		}
	GOTO        L_main34
L_main35:
;Cooley-Tukey-R2.c,123 :: 		}while(1);
	GOTO        L_main12
;Cooley-Tukey-R2.c,124 :: 		}
	GOTO        $+0
; end of _main
