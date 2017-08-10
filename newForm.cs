//The attached Code or Example is provided As Is.  
//It has not been tested or validated as a product, 
//for use in a deployed application or system, or for use in hazardous environments.  
//You assume all risks for use of the Code or Example.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MccDaq;

namespace AnalogIn_toMeter_SW_Timed
{
    public partial class Form1 : Form
    {
        public MccDaq.DaqDeviceDescriptor[] inventory;
        public MccDaq.MccBoard DaqBoard; 
        public MccDaq.ErrorInfo ULStat;
        public MccDaq.Range Range;
        public System.Int32 numchannels = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //First Lets make sure there's an E-1608 plugged in,
            System.Boolean Boardfound = false;

            //First Lets make sure there's an E-1608 plugged in,
            MccDaq.DaqDeviceManager.IgnoreInstaCal(); //Don't use Information from InstaCal

            //Load all the boards it can find
            inventory = MccDaq.DaqDeviceManager.GetDaqDeviceInventory(MccDaq.DaqDeviceInterface.Any);
            System.Int32 numDevDiscovered = inventory.Length; //how many was that?

            if (numDevDiscovered > 0)
            {
                for (System.Int16 BoardNum = 0; BoardNum < numDevDiscovered; BoardNum++)
                {
                    try
                    {
                        DaqBoard = MccDaq.DaqDeviceManager.CreateDaqDevice(BoardNum, inventory[BoardNum]);
                        if (DaqBoard.BoardName.Contains("E-1608"))
                        {
                            Boardfound = true;
                            DaqBoard.FlashLED();
                            break;
                        }
                        else
                        {
                            MccDaq.DaqDeviceManager.ReleaseDaqDevice(DaqBoard);
                        }
                    }
                    catch (MccDaq.ULException ule)
                    {
                        System.Windows.Forms.MessageBox.Show(ule.Message, "No Board detected");
                    }
                }
            }

            if (Boardfound == false)
            {
                System.Windows.Forms.MessageBox.Show("No E-1608 series board found in system.  Please run InstaCal.", "No Board detected");
                this.Close();
            }

            System.String mystring = DaqBoard.BoardName.Substring(0, DaqBoard.BoardName.Trim().Length) +
            " found as board number: " + DaqBoard.BoardNum.ToString();
            this.Text = mystring;

            //Initialize controls on the form needing attention
            LoadComboBox(cmboAInRange);

            //Determine if set for single ended or differential by the number of channels.
            DaqBoard.BoardConfig.GetNumAdChans(out numchannels);
            nudAInChannel.Maximum = numchannels - 1;

             //set up sample timing
            for (int i = 1; i < 11; i++)
                cbRate.Items.Add(i);
            cbRate.SelectedIndex = 9;
        }

        public void LoadComboBox(ComboBox sender)
        {
            sender.Items.Add("+/-10");
            sender.Items.Add("+/- 5");
            sender.Items.Add("+/- 2");
            sender.Items.Add("+/- 1");
            sender.SelectedIndex = 0;
        }

        public void SelectRange(Int32 ComboBoxIndex)
        {
            switch (ComboBoxIndex)
            {
                case 0:
                    Range = MccDaq.Range.Bip10Volts;
                    analogMeter1.Minimum = -10;
                    analogMeter1.Maximum = 10;
                    break;
                case 1:
                    Range = MccDaq.Range.Bip5Volts;
                    analogMeter1.Minimum = -5;
                    analogMeter1.Maximum = 5;
                    break;
                case 2:
                    Range = MccDaq.Range.Bip2Volts;
                    analogMeter1.Minimum = -5;
                    analogMeter1.Maximum = 5;
                    break;
                case 3:
                    Range = MccDaq.Range.Bip1Volts;
                    analogMeter1.Minimum = -5;
                    analogMeter1.Maximum = 5;
                    break;
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                lblAIMode.Text = "Работает";
                btnStartStop.Refresh();
                tmrAnalogIn.Interval = 1000 / Convert.ToInt32(cbRate.SelectedItem);
                tmrAnalogIn.Enabled = true;
                cmboAInRange.Enabled = false;
                cbRate.Enabled = false;
            }
        else
            {
                btnStartStop.Text = "Start";
            	lblAIMode.Text = "Ожидание";
            	tmrAnalogIn.Enabled = false;
            	cmboAInRange.Enabled = true;
            	cbRate.Enabled = true;
            }
        }

        private void tmrAnalogIn_Tick(object sender, EventArgs e)
        {
            //here is how to implement the VIn32 Method.
            System.Double VInVolts;

            SelectRange(cmboAInRange.SelectedIndex);

            ULStat = DaqBoard.VIn32(Convert.ToInt16(nudAInChannel.Value), Range,out VInVolts, MccDaq.VInOptions.Default);
            if (ULStat.Value != MccDaq.ErrorInfo.ErrorCode.NoErrors) 
            {
                errhandler(ULStat);
                return;
		    }

            txtADValue.Text = VInVolts.ToString("#0.0000");
            analogMeter1.Value = VInVolts;
        }
  

        public void errhandler(MccDaq.ErrorInfo ULStat )
        {
            //Generic UL error handler
            tmrAnalogIn.Enabled = false;
            System.Windows.Forms.MessageBox.Show(ULStat.Message, "Universal Library Error " );
            lblAIMode.Text = "Idle";
            btnStartStop.Text = "Start";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		void CbRateSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
    }
}
