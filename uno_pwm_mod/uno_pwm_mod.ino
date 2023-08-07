// PWM (Pulse Width Modulation) range is 0 to 255.

const int pwmQtr = 3 ; // Initializing pin 3 as 1/4 pulse variable
const int pwmHalf = 5 ; // Initializing pin 5 as 1/2 pulse variable
const int pwmThreeQtr = 6 ; // Initializing pin 6 as 3/4 pulse variable

const int qtrPulseWidth = 63; // Initializing pulse width to 1/4
const int halfPulseWidth = 127; // Initializing pulse width to 1/2
const int threeQtrPulseWidth = 191; // Initializing pulse width to 3/4


void setup()
{
     pinMode(pwmQtr,OUTPUT) ; // Set pin 3
     pinMode(pwmHalf,OUTPUT) ; // Set pin 5
     pinMode(pwmThreeQtr,OUTPUT) ; // Set pin 6
}
void loop()
{
     analogWrite(pwmQtr, qtrPulseWidth); // Setting pwm to 63 
     analogWrite(pwmHalf, halfPulseWidth); // Setting pwm to 127 
     analogWrite(pwmThreeQtr, threeQtrPulseWidth); // Setting pwm to 191 
}