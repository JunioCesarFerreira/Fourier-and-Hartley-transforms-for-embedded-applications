# Fourier-and-Hartley-transforms-for-embedded-applications
Códigos utilizados em TCC, Desempenho comparativo entre FFT e FHT no ESP8266, Analisador de vibrações mecânicas baseado no acelerômetro MPU6050 e ESP8266, Engenharia mecatrônica, Unifran, 2016.
* Segue a descrição dos diretórios contidos neste repositório:
* [Dev_cpp](https://github.com/JunioCesarFerreira/Fourier-and-Hartley-transforms-for-embedded-applications/tree/master/Dev_cpp): 
Códigos para transformadas discretas e dos algoritmos Cooley-Tukey Radix-2 para as transformadas rápidas de Fourier e de Hartley, este é um arquivo interessante para quem está procurando compreender o funcionamento destes algoritmos. Escrito em linguagem C++ no DEV-CPP.
* [ESP8266_Arduino](https://github.com/JunioCesarFerreira/Fourier-and-Hartley-transforms-for-embedded-applications/tree/master/ESP8266_Arduino): 
Essencialmente os mesmos códigos desenvolvidos em C do diretório descrito acima, porém, prontos para rodar no NodeMCU ESP8266 com comunicação USB. No diretória de 'Interfaces' encontra-se o programa de recepção dos dados gerados pelo ESP8266.
* [Mechanical_Vibration_Analyzer](https://github.com/JunioCesarFerreira/Fourier-and-Hartley-transforms-for-embedded-applications/tree/master/Mechanical_Vibration_Analyzer):
Neste encontram-se a versão do código do analisador de vibrações mecânicas para o ESP8266, incluindo uma saida de sinal pulsante tal como o exemplo apresentado no trabalho escrito na aplicação de um delta de Dirac no AutoFalante. Veja [Trabalho_Escrito](https://github.com/JunioCesarFerreira/Fourier-and-Hartley-transforms-for-embedded-applications/blob/master/TCC_Junio.pdf) ou no [ResearchGate](https://www.researchgate.net/profile/Junio_Ferreira).
* [Interfaces](https://github.com/JunioCesarFerreira/Fourier-and-Hartley-transforms-for-embedded-applications/tree/master/Interfaces):
Neste encontram-se duas interfaces desenvolvidas em linguagem C# no Microsoft Visual Studio, sendo:
     - 'MyDataReceiver': Interface que recebe dados via USB, desenvolvida para receber os dados enviados pelo ESP [ESP8266_Arduino](https://github.com/JunioCesarFerreira/Fourier-and-Hartley-transforms-for-embedded-applications/tree/master/ESP8266_Arduino)
     - 'AnalisadorTresEixos': Interface desenvolvida para o analisador de vibrações mecânicas, recebe e exibe graficamente os dados enivados pelo ESP com o programa [Firmware_Vibration_Analiser](https://github.com/JunioCesarFerreira/Fourier-and-Hartley-transforms-for-embedded-applications/tree/master/Mechanical_Vibration_Analyzer). Permitindo inclusive, salvar dados em planilhas para tratamento posterior.
* [Matlab](https://github.com/JunioCesarFerreira/Fourier-and-Hartley-transforms-for-embedded-applications/tree/master/Matlab):
Alguns dos códigos de testes realizados em Matlab, uteis para plotar gráficos do trabalho e para verificar os resultados das transformadas. 
* [PIC18F](https://github.com/JunioCesarFerreira/Fourier-and-Hartley-transforms-for-embedded-applications/tree/master/PIC18F):
Versão desenvolvida no MikroC para PIC18F2550/4550.
