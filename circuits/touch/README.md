## The touch (petting) interface

Of the output characteristics the machine has (vibration, lights) it does not have any input reception vectors. Here is the touch - or more accurately petting - interface that will allow a communication paradigm between the machine and a person.

## Adding recognizable touch to the design

The first thing that is required is an interface to detect when a person touches the animal. This is accomplished by an antenna I made-up for the Model 'G' experiments, but see that - in reverse - it functions backwards. It detects the presence of the magnetic field of the person. It is illustrated in the following figure.

![antenna.jpg](../../media/antenna.jpeg)

The complicated part will be to detect and leverage the signal. I am thinking some of the 2N2222 amplifiers I have will aid in this.

## Support in the hardware vector

In order to calibrate and understand the requirements, it is first wise to experiment with arduino in the following manner

![circuit-touch-pet.png](../../media/touch-detection-circuit.png)

With the following code

```
int value = 0;
float voltage;

void setup() {
  analogReference(INTERNAL);
  //analogReference(EXTERNAL);
  Serial.begin(9600);
}

void loop() {
  value = analogRead(A0);
  voltage = value * 5000/1023;
  Serial.print("Voltage = ");
  Serial.println(voltage);
  delay(500);
}
```
I was using the interface directly both at the end and the beginning of `R1`, however, there is a way to dial it in better, although it maybe too small to be measurable in any meaningful way.

### Another

![read-analog-input.png](../../media/touch-detection-practical.png)
![analog-circuit-comps.png](../../media/resistor-colours.png)

With the following code

```
/*
  Voltmeter
        Code to test the performance of the antenna input measurment hardware.
*/

int analogInput = 1;
float Vout = 0.00;
float Vin = 0.00;
float R1 = 10000.00;  // resistance of R1 (10K)
float R2 = 1000.00;   // resistance of R2 (1K)
int val = 0;

void setup() {
  pinMode(analogInput, INPUT);  //assigning the input port
  Serial.begin(9600);           //BaudRate
}

void loop() {

  val = analogRead(analogInput);  //reads the analog input
  Vout = (val * 5.00) / 1024.00;  // formula for calculating voltage out i.e. V+, here 5.00
  Vin = Vout / (R2 / (R1 + R2));  // formula for calculating voltage in i.e. GND
  if (Vin < 0.09)                 //condition
  {
    Vin = 0.00;  //statement to quash undesired reading !
  }
  Serial.print("\t The voltage seen at the antenna is: ");
  Serial.print(Vin);
  delay(1000);  //for maintaining the speed of the output in serial moniter
}
```

It doesn't indicate the deal with the resistors as they seem to be identical in the schematic. Looking at the code, it doesn't seem to matter, as long as they are different values.

-----

## Actual voltages available

Using the hp oscilloscope and a 10x probe, I can measure the following (no postprocessing):

Minimum LO:

![lo-pot.jpg](../../media/min-lo-osc.jpeg)

Maximum HI:

![hi-pot.jpg](../../media/max-hi-osc.jpeg)

Which gives a range of `25 mV` and `67 mV`. Such small numbers cannot be picked up by the arduino, it only has a 10-bit resolution, after all. Surly I can dream of a circuit to amplify using the 2N2222 but I need to be conscious of the extra power requirement.