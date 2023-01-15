#ifndef FastFourierTransform_HPP
#define FastFourierTransform_HPP

#include <Arduino.h>
#include <CommonAlgorithms.hpp>

typedef struct
{
	double real;
	double imag;
} complexNumber;

class FastFourierTransform : CommonAlgorithms
{
	public:
		// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
		// * FFT Algoritmo Cooley-Tukey radix-2 descimation-in-time
		// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
		void calc(double input[], uint16_t inputLength, complexNumber* output)
		{
			uint16_t N = inputLength;
			double pi_N=2*PI/N;       // Auxiliar Pi*n
			complexNumber W[N/2];
		
			for (uint32_t i=0; i<N; i++)
			{
				output[reverseBits(i,N)].real = input[i];
				output[i].imag = 0;
			}
			
			// Coefficient array
			for (uint32_t i=0;i<N/4;i++)
			{
				//W[i].real = cos(pi_N*i);
				//W[i].imag = -sin(pi_N*i);
				uint32_t tmp = i*512/N;
				W[i].real     =  tab_trig[tmp];
				W[i+N/4].real = -tab_trig[128-tmp];
				W[i].imag     = -tab_trig[128-tmp];
				W[i+N/4].imag = -tab_trig[tmp];
			}
			// FFT Cooley-Tukey radix-2
			for (uint32_t P=N;P>=2;P=P/2)
			{
				uint32_t NP = (N/P);    // Length of the decomposed DFT
				uint32_t L=P/2;         // Limit to Butterfly speeds from current level
				uint32_t desl = 2*NP;   // Internal level displacement factor
				// Displacement of main Butterflys
				for (uint32_t k=0; k<NP; k++)
				{
					uint32_t index1 = k*P/2;
					// Displacement of similar Butterflys
					for (uint32_t i=0; i<L; i++)
					{
						// Prepare entries Butterfly
						uint32_t index2 = k+i*desl;
						// Butterfly DIT.
						double Br=W[index1].real*output[NP+index2].real;
						double Ar=W[index1].imag*output[NP+index2].imag;
						double Bi=W[index1].real*output[NP+index2].real;
						double Ai=W[index1].imag*output[NP+index2].imag;
						Br-=Ar;
						Bi+=Ai;
						output[index2].real = output[index2].real + Br;
						output[index2].imag = output[index2].imag + Bi;
						output[NP+index2].real = output[index2].real - Br;
						output[NP+index2].imag = output[index2].imag - Bi;
					}
				}
			}
		}
};

#endif // !FastFourierTransform_HPP