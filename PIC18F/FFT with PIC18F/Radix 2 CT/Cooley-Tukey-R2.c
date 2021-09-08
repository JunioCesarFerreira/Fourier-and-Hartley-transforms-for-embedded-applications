/*
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
*  Teste de aplicação algoritmo Cooley-Tukey Radix 2 decimation-in-time FFT *
*  Desenvolvido por Junio Cesar Ferreira                                    *
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *

          Teste de bancada com osciloscópio digital 23/06/2016
    * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    *                 Tempos de processamento                     *
    *  (Medidos no osciloscópio MO-2060 60MHz Unifran 23/06/2016) *
    * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    * Numero de Amostras * Tempo Amostragem * Tempo processamento *
    * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    *         16         *       880  us    *        9.20  ms     *
    *         32         *       1.8  ms    *        19.6  ms     *
    *        128         *       7.2  ms    *        87.2  ms     *
    * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  
*/

#define N    128  // Comprimento dos vetores de entrada e saída
#define pi   3.1415926535897932384626433832795028841971693993751

// Reversor de bits
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
      double Xreal[N];          // Vetor Componente Real
      double Ximag[N];          // Vetor Componente Imaginária
      double Wr[N/2], Wi[N/2];  // Vetor de coeficientes omega
      double pi_N=2*pi/N;       // Auxiliar Pi*n
      double aar, aai, bbr, bbi;// Entradas Butterfly
      double Br, Bi;            // Saídas Butterfly
      unsigned int i, k, L, desl, P, NP, Aux1, Aux2;
      // Configura SFRs
      ADCON1 = 14;
      TRISA = 1;
      TRISB = 0;
      PORTA = 0;
      PORTB = 0;

      do{
        PORTB=255;
        // Amostragem
        for (i=0;i<N;i++){  // ~ 7.2 ms
            Ximag[i]=(5/1023)*ADC_Read(0);
            Delay_us(50);
            }
        PORTB=0;
        // Carrega vetores
        for (i=0;i<N;i++){
            Xreal[Table_Reverse(i,N)]=Ximag[i];
            Ximag[i]=0;
            }
        // Carrega vetor de coeficientes
        for (i=0;i<N/2;i++){
            Wr[i] = cos(pi_N*i);
            Wi[i] = -sin(pi_N*i);
            }
        // Computa FFT Cooley-Tukey radix-2 Decimation-in-time
        for (P=N;P>=2;P=P/2){
            NP = (N/P);                // Comprimento da DFT decomposta
            // Deslocamento da Butterfly principal sobre o nível
            for (k=0;k<NP;k++){
                L=(P/2)-1;             // Limite para deslocamentos da Butterfly do nível atual
                desl = 2*NP;           // Fator de deslocamento interno do nível
                Aux1=k*P/2;
                for (i=0;i<=L;i++){
                    // Prepara entradas da Butterfly
                    Aux2=k+i*desl;
                    aar=Xreal[Aux2];
                    aai=Ximag[Aux2];
                    bbr=Xreal[NP+Aux2];
                    bbi=Ximag[NP+Aux2];
                    // Computa Butterfly DIT ...
                    Br=bbr*Wr[Aux1]-bbi*Wi[Aux1];
                    Bi=bbr*Wi[Aux1]+bbi*Wr[Aux1];
                    Xreal[Aux2]=aar+Br;
                    Ximag[Aux2]=aai+Bi;
                    Xreal[NP+Aux2]=aar-Br;
                    Ximag[NP+Aux2]=aai-Bi;
                    }
                }
            }
        // Normaliza resultado
        for (i=0;i<N;i++){
            Xreal[i]=2*Xreal[i]/N;
            Ximag[i]=2*Ximag[i]/N;
            Xreal[i]=sqrt(pow(Xreal[i],2)+pow(Ximag[i],2));
            }
        }while(1);
}
