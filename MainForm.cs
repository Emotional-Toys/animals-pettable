using Cartheur.Animals.Pettable.WaveformSDK;
using Smdn.Devices.MCP2221;
using System.Drawing;
using System.Windows.Forms;

namespace Cartheur.Animals.Pettable
{
    public partial class MainForm : Form
    {
        public static bool Instance { get; set; }
        public static MCP2221 Device { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Instance = true;
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

        #region Events
        private void PettedDetectedAntennaOneButtonClick(object sender, System.EventArgs e)
        {
            PetDetectedAntennaOneButton.BackColor = Color.LightGreen;
        }
        private void PetDetectedAntennaTwoButtonClick(object sender, System.EventArgs e)
        {
            PetDetectedAntennaTwoButton.BackColor = Color.Bisque;
        }
        private void CloseButtonClick(object sender, System.EventArgs e)
        {
            Instance = false;
            Close();
        }
        #endregion
    }
}
