#ifndef CommonAlgorithms_HPP
#define CommonAlgoritmns_HPP

#include <Arduino.h>

class CommonAlgorithms
{
	protected:
		bool checkExp2(uint32_t value)
		{
			uint8_t count = 0;
			for (uint8_t i=0; i<16; i++)
			{
				if (value&1 == 1)
				{
					count++;
				}
				value >>= 1;
			}
			return !(count > 1);
		}
	
		uint16_t log_2(uint32_t value)
		{
			uint16_t log2Result = 0;
			for (uint8_t i=0; i<16; i++)
			{
				if (value == 1)
				{
					log2Result = i;
					break;
				}
				value >>= 1;
			}
			return log2Result;
		}
	
		uint32_t reverseBits(uint32_t index, uint32_t length)
		{
			uint16_t log2 = log_2(length);
			uint32_t mirror = 0;
			for (uint8_t i=0; i<log2; i++)
			{
				mirror <<= 1;
				mirror += (0x01&index);
				index >>= 1;
			}
			return mirror;
		}
};

#include "TrigonometricTable.h"

#endif // !FastFourierTransform_HPP