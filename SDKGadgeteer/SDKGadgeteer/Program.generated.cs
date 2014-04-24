//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDKGadgeteer
{
    using Gadgeteer;
    using GTM = Gadgeteer.Modules;


    public partial class Program : Gadgeteer.Program
    {

        /// <summary>The BreadBoard X1 module using socket 3 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.BreadBoard_X1 breadBoard_X1;

        /// <summary>The Button module using socket 5 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Button buttonRight;

        /// <summary>The Button module using socket 2 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Button buttonLeft;

        /// <summary>The Display N18 module using socket 6 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Display_N18 display_N18;

        /// <summary>The Joystick module using socket 4 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Joystick joystick;

        /// <summary>The LED Strip module (not connected).</summary>
        private Gadgeteer.Modules.GHIElectronics.LED_Strip led_Strip;

        /// <summary>The LightSensor module (not connected).</summary>
        private Gadgeteer.Modules.GHIElectronics.LightSensor lightSensor;

        /// <summary>The SDCard module using socket 7 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.SDCard sdCard;

        /// <summary>The Tunes module (not connected).</summary>
        private Gadgeteer.Modules.GHIElectronics.Tunes tunes;

        /// <summary>The UsbClientSP module using socket 8 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.UsbClientSP usbClientSP;

        /// <summary>This property provides access to the Mainboard API. This is normally not necessary for an end user program.</summary>
        protected new static GHIElectronics.Gadgeteer.FEZCerberus Mainboard
        {
            get
            {
                return ((GHIElectronics.Gadgeteer.FEZCerberus)(Gadgeteer.Program.Mainboard));
            }
            set
            {
                Gadgeteer.Program.Mainboard = value;
            }
        }

        /// <summary>This method runs automatically when the device is powered, and calls ProgramStarted.</summary>
        public static void Main()
        {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZCerberus();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }

        private void InitializeModules()
        {
            this.breadBoard_X1 = new GTM.GHIElectronics.BreadBoard_X1(3);
            this.buttonRight = new GTM.GHIElectronics.Button(5);
            this.buttonLeft = new GTM.GHIElectronics.Button(2);
            this.display_N18 = new GTM.GHIElectronics.Display_N18(6);
            this.joystick = new GTM.GHIElectronics.Joystick(4);
            Microsoft.SPOT.Debug.Print("The module \'led_Strip\' was not connected in the designer and will be null.");
            Microsoft.SPOT.Debug.Print("The module \'lightSensor\' was not connected in the designer and will be null.");
            this.sdCard = new GTM.GHIElectronics.SDCard(7);
            Microsoft.SPOT.Debug.Print("The module \'tunes\' was not connected in the designer and will be null.");
            this.usbClientSP = new GTM.GHIElectronics.UsbClientSP(8);
        }
    }
}
