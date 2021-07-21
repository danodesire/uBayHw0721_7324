using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleLicenseTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        
        private void Init() // variable initialization.
        {
            this.txtAmount.Text = "";
            this.cbxSelect_Usage.SelectedIndex = 0;
            this.cbxSelect_Motor.SelectedIndex = 0;
            this.dtpStart.Value = DateTime.Now.Date;
            this.dtpStart.Enabled = false;
            this.dtpEnd.Value = DateTime.Now.Date;
            this.dtpEnd.Enabled = false;
            this.radio_Allyear.Checked = true;
        }

        private void radioPeriod_CheckedChanged(object sender, EventArgs e)
        {
            // setting DateTimePicker disable if RadioButton first selection been chosen.
            dtpStart.Enabled = !(radio_Allyear.Checked);
            dtpEnd.Enabled = !(radio_Allyear.Checked);
        }

        private void buttonClear_Click(object sender, EventArgs e) // reset all data.
        {
            this.Init();
        }

        private void cbxSelect_Usage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cbxSelect_Usage.SelectedIndex)
            {
                // 機車
                case 0:
                    this.cbxSelect_Motor.Items.Clear();
                    this.cbxSelect_Motor.Items.AddRange(new object[] {
                    "150以下 / 12HP以下(12.2PS以下)",
                    "151-250 / 12.1-20HP(12.3-20.3PS)",
                    "251-500 / 20.1HP以上(20.4PS以上)",
                    "501-600",
                    "601-1200",
                    "1201-1800",
                    "1801或以上" });
                    break;
                // 貨車
                case 1:
                    this.cbxSelect_Motor.Items.Clear();
                    this.cbxSelect_Motor.Items.AddRange(new object[] {
                    "500以下",
                    "501-600",
                    "601-1200",
                    "1201-1800",
                    "1801-2400",
                    "2401-3000 / 138HP以下(140.1PS以下)",
                    "3001-3600",
                    "3601-4200 / 138.1-200HP(140.2-203.0PS)",
                    "4201-4800",
                    "4801-5400 / 200.1-247HP(203.1-250.7PS)",
                    "5401-6000",
                    "6001-6600 / 247.1-286HP(250.8-290.3PS)",
                    "6601-7200",
                    "7201-7800 / 286.1-336HP(290.4-341.0PS)",
                    "7801-8400",
                    "8401-9000 / 336.1-361HP(341.1-366.4PS)",
                    "9001-9600",
                    "9601-10200 / 361.1HP以上(366.5PS以上)",
                    "10201以上" });
                    break;
                // 大客車
                case 2:
                    this.cbxSelect_Motor.Items.Clear();
                    this.cbxSelect_Motor.Items.AddRange(new object[] {
                    "600以下",
                    "601-1200",
                    "1201-1800",
                    "1801-2400",
                    "2401-3000 / 138HP以下(140.1PS以下)",
                    "3001-3600",
                    "3601-4200 / 138.1-200HP(140.2-203.0PS)",
                    "4201-4800",
                    "4801-5400 / 200.1-247HP(203.1-250.7PS)",
                    "5401-6000",
                    "6001-6600 / 247.1-286HP(250.8-290.3PS)",
                    "6601-7200",
                    "7201-7800 / 286.1-336HP(290.4-341.0PS)",
                    "7801-8400",
                    "8401-9000 / 336.1-361HP(341.1-366.4PS)",
                    "9001-9600",
                    "9601-10200 / 361.1HP以上(366.5PS以上)",
                    "10201以上"});
                    break;
                // 自用小客車
                case 3:
                    this.cbxSelect_Motor.Items.Clear();
                    this.cbxSelect_Motor.Items.AddRange(new object[] {
                    "500以下 / 38HP以下(38.6PS以下)",
                    "501~600 / 38.1-56HP(38.7-56.8PS)",
                    "601~1200 / 56.1-83HP(56.9-84.2PS)",
                    "1201~1800 / 83.1-182HP(84.3-184.7PS)",
                    "1801~2400 / 182.1-262HP(184.8-265.9PS)",
                    "2401~3000 / 262.1-322HP(266-326.8PS)",
                    "3001-4200 / 322.1-414HP(326.9-420.2PS",
                    "4201-5400 / 414.1-469HP(420.3-476.0PS)",
                    "5401-6600 / 469.1-509HP(476.1-516.6PS)",
                    "6601-7800 / 509.1HP以上(516.7PS以上)",
                    "7801以上"});
                    break;
                // 營業用小客車
                case 4:
                    this.cbxSelect_Motor.Items.Clear();
                    this.cbxSelect_Motor.Items.AddRange(new object[] {
                    "500以下 / 38HP以下(38.6PS以下)",
                    "501~600 / 38.1-56HP(38.7-56.8PS)",
                    "601~1200 / 56.1-83HP(56.9-84.2PS)",
                    "1201~1800 / 83.1-182HP(84.3-184.7PS)",
                    "1801~2400 / 182.1-262HP(184.8-265.9PS)",
                    "2401~3000 / 262.1-322HP(266-326.8PS)",
                    "3001-4200 / 322.1-414HP(326.9-420.2PS)",
                    "4201-5400 / 414.1-469HP(420.3-476.0PS)",
                    "5401-6600 / 469.1-509HP(476.1-516.6PS)",
                    "6601-7800 / 509.1HP以上(516.7PS以上)",
                    "7801以上"});
                    break;
                default:
                    break;
            }
        }

        private double getPrice() // get price.
        {
            double pricePerYear = 0;
            switch (this.cbxSelect_Usage.SelectedIndex)
            {
                case 0:
                    double[] pScooter = { 0, 800, 1620, 2160, 4320, 7120, 11230 };
                    pricePerYear = pScooter[this.cbxSelect_Motor.SelectedIndex];
                    break;
                case 1:
                    double[] pTruck = { 900, 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 12600, 13500, 14400, 15300, 15300, 16200 };
                    pricePerYear = pTruck[this.cbxSelect_Motor.SelectedIndex];
                    break;
                case 2:
                    double[] pBus = { 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200 };
                    pricePerYear = pBus[this.cbxSelect_Motor.SelectedIndex];
                    break;
                case 3:
                    double[] pSelfCar = { 1620, 2160, 4320, 7120, 11230, 15210, 28220, 46170, 69690, 117000, 151200 };
                    pricePerYear = pSelfCar[this.cbxSelect_Motor.SelectedIndex];
                    break;
                case 4:
                    double[] pBusiness = { 900, 1260, 2160, 3060, 6480, 9900, 16380, 24300, 33660, 44460, 56700 };
                    pricePerYear = pBusiness[this.cbxSelect_Motor.SelectedIndex];
                    break;
                default:
                    break;
            }
            return pricePerYear;
        }

        private double getDays() // get total days.
        {
            DateTime startDate = this.dtpStart.Value;
            DateTime endDate = this.dtpEnd.Value;
            double totalDays = (endDate - startDate).TotalDays + 1; // counting way : start day 00:00 ~ end day 24:00
            return totalDays;
        }

        private bool checkDaysAmount() // check days amount is correct or not.
        {
            if (this.getDays() < 0)
            {
                this.Init();
                this.txtAmount.Text = "Please check about the date duration.";
                return false;
            }
            return true;
        }

        private void printResult()
        {
            // leap year check.
            DateTime leapYearCheck = DateTime.Now;
            double dayAmount = 0;
            double yearDays = 0;
            double taxResult = 0;

            if (DateTime.IsLeapYear(leapYearCheck.Year))
            {
                yearDays = 366;
                dayAmount = 366;
            }                
            else
            {
                yearDays = 365;
                dayAmount = 365;
            }                             

            if (this.radio_Allyear.Checked == true)
            {
                this.txtAmount.Text = $"使用期間:  {leapYearCheck.Year}/1/1 上午 12:00:00 ~ {leapYearCheck.Year}/12/31 上午 12:00:00\r\n";
                this.txtAmount.Text += $"計算天數:  {dayAmount}\r\n";
                this.txtAmount.Text += $"汽缸CC數: {this.cbxSelect_Motor.Text}\r\n";
                this.txtAmount.Text += $"用途:         {this.cbxSelect_Usage.Text}\r\n";

                taxResult = Math.Floor(getPrice() * dayAmount / yearDays);
                this.txtAmount.Text += $"計算公式:  {getPrice()} * {dayAmount} / {yearDays} = {taxResult}元\r\n";
                this.txtAmount.Text += $"應納稅額:  共{taxResult}元";
            }
            else
            {
                DateTime startDate = this.dtpStart.Value;
                this.txtAmount.Text = "";
                int loopTest = 0;
                while (true)
                {
                    leapYearCheck = startDate;
                    if (DateTime.IsLeapYear(leapYearCheck.Year))
                        yearDays = 366;
                    else
                        yearDays = 365;

                    DateTime yearEndDate = new DateTime(startDate.Year, 12, 31);
                    if (this.dtpEnd.Value <  yearEndDate)
                        yearEndDate = this.dtpEnd.Value;

                    double daysTemp = (yearEndDate - startDate).TotalDays + 1;

                    this.txtAmount.Text += $"使用期間:  {startDate} ~ {yearEndDate}\r\n";
                    this.txtAmount.Text += $"計算天數:  {daysTemp}\r\n";
                    this.txtAmount.Text += $"汽缸CC數: {this.cbxSelect_Motor.Text}\r\n";
                    this.txtAmount.Text += $"用途:         {this.cbxSelect_Usage.Text}\r\n";

                    double taxResultTemp = Math.Floor(getPrice() * daysTemp / yearDays);
                    taxResult += taxResultTemp;
                    this.txtAmount.Text += $"計算公式:  {getPrice()} * {daysTemp} / {yearDays} = {taxResultTemp}元\r\n";
                    this.txtAmount.Text += $"應納稅額:  共{taxResultTemp}元\r\n\r\n";
                    
                    loopTest += 1;
                    if (yearEndDate == this.dtpEnd.Value)
                        break;                      
                    else
                        startDate = new DateTime(startDate.Year + 1, 1, 1);                     
                }
                if(loopTest > 1)
                    this.txtAmount.Text += $"全部應納稅額:  共{taxResult}元\r\n";
            }
        }

        private void buttonComfirm_Click(object sender, EventArgs e)
        {
            if(this.checkDaysAmount())
            {
                if (this.cbxSelect_Motor.SelectedIndex > -1 && this.cbxSelect_Usage.SelectedIndex > -1)
                    this.printResult();
                else
                    this.txtAmount.Text = "Please select usage or CC number.";
            }
        }
    }
}
