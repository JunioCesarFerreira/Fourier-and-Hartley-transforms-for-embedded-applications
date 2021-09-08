/*
Teste de aplicação algoritmo Cooley-Tukey Radix 2 modificado para FHT
Desenvolvido por Junio Cesar Ferreira
*/
#define N     128  // Comprimento dos vetores de entrada e saída
#define pi    3.1415926535897932384626433832795028841971693993751
#define pi_4  0.78539816339744830961566084581988
#define raiz2 1.4142135623730950488016887242097

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
        double v[N];
        double X[N];
        double C[N/2],S[N/2];
        double pi_N=2*pi/N;      // Auxiliar Pi*n
        double _a, _b, _c;
        unsigned int i, k, L, desl, P, NP;

        ADCON1 = 14;
        TRISA = 1;
        TRISB = 0;
        PORTA = 0;
        PORTB = 0;

        do{
          PORTB=255;
          for (i=0;i<N;i++){  // ~ 7.48 ms
              v[i]=(5/1023)*ADC_Read(0);
              Delay_us(50);
          }
          PORTB=0;

        // Calculo da FHT
        // Carrega vetores
        for (i=0;i<N;i++) X[Table_Reverse(i,N)]=v[i];

        // Carrega vetor de coeficientes
        for (i=0;i<N/2;i++){
                C[i]=cos(i*2*pi/N);
                S[i]=sin(i*2*pi/N);
        }

        // Computa FHT Cooley-Tukey radix-2
        for (P=N;P>=2;P=P/2){
                NP = (N/P);  // Comprimento da DHT decomposta
                L=P/2;          // Limite para deslocamentos da Butterfly do nível atual
                desl = 2*NP;    // Fator de deslocamento interno do nível
                // Deslocamento da Butterfly principal
                for (k=0;k<NP;k++){ // Desloca grupo de butterflys
                        for (i=0;i<L;i++){ // Desloca Butterfly
                                // Prepara entradas da Butterfly
                                _a=X[k+i*desl];
                                _b=X[k+NP+i*desl]*C[k*P/2];
                                _c=X[Complemento(k,NP)+NP+i*desl]*S[k*P/2];
                                // Computa Butterfly DIT ...
                                v[k+i*desl]=_a+_b+_c;
                                v[k+NP+i*desl]=_a-_b-_c;
                        }
                }
                for (i=0;i<N;i++) X[i]=v[i];
        }
        // Normaliza resultado
        for (i=0;i<N;i++) X[i]=2*X[i]/N;
        // Computa T. de Fourier atraves da T. Hartley
        for (i=1;i<N/2;i++){
            X[i]=(sqrt(2)/2)*sqrt(X[i]*X[i]+X[N-i]*X[N-i]);
            //V[N-i]=V[i];
        }
        }while(1);

}
