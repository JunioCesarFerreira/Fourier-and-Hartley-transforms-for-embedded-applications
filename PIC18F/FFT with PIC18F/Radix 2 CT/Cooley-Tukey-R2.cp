#line 1 "C:/Users/Junio/Dropbox/Meu TCC/Desenvolvimento/FFT with PIC18F/Radix 2 CT/Cooley-Tukey-R2.c"
#line 25 "C:/Users/Junio/Dropbox/Meu TCC/Desenvolvimento/FFT with PIC18F/Radix 2 CT/Cooley-Tukey-R2.c"
unsigned int Table_Reverse(unsigned int index, unsigned int Lenght){
 unsigned int mirror, exp, Lim;
 switch (Lenght){
 case 8:
 Lim=3;
 break;
 case 16:
 Lim=4;
 break;
 case 32:
 Lim=5;
 break;
 case 64:
 Lim=6;
 break;
 case 128:
 Lim=7;
 break;
 case 256:
 Lim=8;
 break;
 case 512:
 Lim=9;
 break;
 }
 mirror = 0;
 for (exp=0;exp<Lim;exp++){
 mirror=mirror<<1;
 mirror+=(0x01&index);
 index=index>>1;
 }
 return mirror;
}

main(){
 double Xreal[ 128 ];
 double Ximag[ 128 ];
 double Wr[ 128 /2], Wi[ 128 /2];
 double pi_N=2* 3.1415926535897932384626433832795028841971693993751 / 128 ;
 double aar, aai, bbr, bbi;
 double Br, Bi;
 unsigned int i, k, L, desl, P, NP, Aux1, Aux2;

 ADCON1 = 14;
 TRISA = 1;
 TRISB = 0;
 PORTA = 0;
 PORTB = 0;

 do{
 PORTB=255;

 for (i=0;i< 128 ;i++){
 Ximag[i]=(5/1023)*ADC_Read(0);
 Delay_us(50);
 }
 PORTB=0;

 for (i=0;i< 128 ;i++){
 Xreal[Table_Reverse(i, 128 )]=Ximag[i];
 Ximag[i]=0;
 }

 for (i=0;i< 128 /2;i++){
 Wr[i] = cos(pi_N*i);
 Wi[i] = -sin(pi_N*i);
 }

 for (P= 128 ;P>=2;P=P/2){
 NP = ( 128 /P);

 for (k=0;k<NP;k++){
 L=(P/2)-1;
 desl = 2*NP;
 Aux1=k*P/2;
 for (i=0;i<=L;i++){

 Aux2=k+i*desl;
 aar=Xreal[Aux2];
 aai=Ximag[Aux2];
 bbr=Xreal[NP+Aux2];
 bbi=Ximag[NP+Aux2];

 Br=bbr*Wr[Aux1]-bbi*Wi[Aux1];
 Bi=bbr*Wi[Aux1]+bbi*Wr[Aux1];
 Xreal[Aux2]=aar+Br;
 Ximag[Aux2]=aai+Bi;
 Xreal[NP+Aux2]=aar-Br;
 Ximag[NP+Aux2]=aai-Bi;
 }
 }
 }

 for (i=0;i< 128 ;i++){
 Xreal[i]=2*Xreal[i]/ 128 ;
 Ximag[i]=2*Ximag[i]/ 128 ;
 Xreal[i]=sqrt(pow(Xreal[i],2)+pow(Ximag[i],2));
 }
 }while(1);
}
