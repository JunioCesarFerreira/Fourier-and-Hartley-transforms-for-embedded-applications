#line 1 "C:/Users/Junio/Dropbox/Meu TCC/Desenvolvimento/FHT with PIC18F/Radix 2/FHT-CT-R2.c"
#line 13 "C:/Users/Junio/Dropbox/Meu TCC/Desenvolvimento/FHT with PIC18F/Radix 2/FHT-CT-R2.c"
double Modulo(double Val){
 if (Val<0) return Val*-1;
 else return Val;
}
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

unsigned int Complemento(unsigned int K, unsigned int L){
 if (K==0) return 0;
 else return (L-K);
}

main(){
 double v[ 128 ];
 double X[ 128 ];
 double C[ 128 /2],S[ 128 /2];
 double pi_N=2* 3.1415926535897932384626433832795028841971693993751 / 128 ;
 double _a, _b, _c;
 unsigned int i, k, L, desl, P, NP;

 ADCON1 = 14;
 TRISA = 1;
 TRISB = 0;
 PORTA = 0;
 PORTB = 0;

 do{
 PORTB=255;
 for (i=0;i< 128 ;i++){
 v[i]=(5/1023)*ADC_Read(0);
 Delay_us(50);
 }
 PORTB=0;



 for (i=0;i< 128 ;i++) X[Table_Reverse(i, 128 )]=v[i];


 for (i=0;i< 128 /2;i++){
 C[i]=cos(i*2* 3.1415926535897932384626433832795028841971693993751 / 128 );
 S[i]=sin(i*2* 3.1415926535897932384626433832795028841971693993751 / 128 );
 }


 for (P= 128 ;P>=2;P=P/2){
 NP = ( 128 /P);
 L=P/2;
 desl = 2*NP;

 for (k=0;k<NP;k++){
 for (i=0;i<L;i++){

 _a=X[k+i*desl];
 _b=X[k+NP+i*desl]*C[k*P/2];
 _c=X[Complemento(k,NP)+NP+i*desl]*S[k*P/2];

 v[k+i*desl]=_a+_b+_c;
 v[k+NP+i*desl]=_a-_b-_c;
 }
 }
 for (i=0;i< 128 ;i++) X[i]=v[i];
 }

 for (i=0;i< 128 ;i++) X[i]=2*X[i]/ 128 ;

 for (i=1;i< 128 /2;i++){
 X[i]=(sqrt(2)/2)*sqrt(X[i]*X[i]+X[ 128 -i]*X[ 128 -i]);

 }
 }while(1);

}
