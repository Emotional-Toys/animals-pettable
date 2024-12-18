using Cartheur.Animals.Pettable.WaveformSDK;
using System;

namespace Cartheur.Animals.Pettable
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
        public void InitializeBoard()
        {

        }
        public void IntializeDigilent()
        {

        }
        public void RetrieveDigilentData()
        {
            // Get the desired data from the oscilloscope of pet detection, and of what kind?
        }
        public void RetrieveRawData()
        {
            // Get the datastream from an ADC of the signals arriving from the antenna: Includes the precision rectifier circuit I have planned and a circuit-board ready.
            // Use the GPIO(ADC) of the MCP2221A as input from the antenna (hardware).
        }

        private void PettedDetectedAntennaOneButtonClick(object sender, System.EventArgs e)
        {
            //PetDetectedAntennaOneButton.BackColor = Color.LightGreen;
        }
        private void PetDetectedAntennaTwoButtonClick(object sender, System.EventArgs e)
        {
            //PetDetectedAntennaTwoButton.BackColor = Color.Bisque;
        }

    }
}
