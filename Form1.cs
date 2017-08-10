using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
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
            System.Boolean Boardfound = false;
            MccDaq.DaqDeviceManager.IgnoreInstaCal();
            inventory = MccDaq.DaqDeviceManager.GetDaqDeviceInventory(MccDaq.DaqDeviceInterface.Any);
            System.Int32 numDevDiscovered = inventory.Length;

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
                        System.Windows.Forms.MessageBox.Show(ule.Message, "Плата не обнаружена");
                    }
                }
            }

            if (Boardfound == false)
            {
                System.Windows.Forms.MessageBox.Show("E-1608 не найден. Запустите InstaCal", "Плата не обнаружена");
                this.Close();
            }
            System.String mystring = DaqBoard.BoardName.Substring(0, DaqBoard.BoardName.Trim().Length) + " найдена под номером: " + DaqBoard.BoardNum.ToString();
            this.Text = mystring;
            LoadComboBox(cmboAInRange);
            DaqBoard.BoardConfig.GetNumAdChans(out numchannels);
            nudAInChannel.Maximum = numchannels - 1;
             
            for (int i = 1; i < 10; i++)
                cbRate.Items.Add(i*10);
            cbRate.SelectedIndex = 1;
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
            if (btnStartStop.Text == "Старт")
            {
                btnStartStop.Text = "Стоп";
                lblAIMode.Text = "Работает";
                btnStartStop.Refresh();
                tmrAnalogIn.Interval = 1000 / Convert.ToInt32(cbRate.SelectedItem);
                tmrAnalogIn.Enabled = true;
                cmboAInRange.Enabled = false;
                cbRate.Enabled = false;
            }
        else
            {
                btnStartStop.Text = "Старт";
            	lblAIMode.Text = "Ожидание";
            	tmrAnalogIn.Enabled = false;
            	cmboAInRange.Enabled = true;
            	cbRate.Enabled = true;
            }
        }

        private void tmrAnalogIn_Tick(object sender, EventArgs e)
        {
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
            
            tmrAnalogIn.Enabled = false;
            System.Windows.Forms.MessageBox.Show(ULStat.Message, "Universal Library Error " );
            lblAIMode.Text = "Ожидание";
            btnStartStop.Text = "Старт";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		void CbRateSelectedIndexChanged(object sender, EventArgs e)
		{
		}
		void AnalogMeter1Load(object sender, EventArgs e)
		{
		}
		void Label2Click(object sender, EventArgs e)
		{
		}
		void Time_labelClick(object sender, EventArgs e)
		{
		}
		void TxtADValueTextChanged(object sender, EventArgs e)
		{
			DateTime time = DateTime.Now;
            String strTime = time.ToString("hh:mm:ss.ffffff");
            time_label.Text = strTime;
		}			
    }
}
