using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZPRO.Model;
using ZPRO.PublicSiteController;

namespace ProjectZ.PublicSite
{
    public partial class ZStatistic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            panAuto.Visible = false;
            panAutoZ.Visible = false;
            panAutoResults.Visible = false;

            panManual.Visible = false;
            panManualZ.Visible = false;
            panManualResults.Visible = false;
        }



        // Code for automatic samples (user doesn't have individual observations)  //
        
        protected void bAutoSample_Click(object sender, EventArgs e)
        {
            panMainMenu.Visible = false;
            panSelectManual.Visible = false;
            panAuto.Visible = true;
        }

        protected void bManualSample_Click(object sender, EventArgs e)
        {
            panMainMenu.Visible = false;
            panSelectAuto.Visible = false;
            panManual.Visible = true;
        }


        // User enters sample size, population mean, sample mean, sample stdev
        protected void bAutoCalc_Click(object sender, EventArgs e)
        {
            Sample s = new Sample();
            s.SampleSize = int.Parse(tbSampleSizeA.Text);
            s.PopulationMean = double.Parse(tbPopMean.Text);
            s.SampleMean = double.Parse(tbMean.Text);
            s.SampleStDev = double.Parse(tbStdDev.Text);

            ZStat z = new ZStat();
            z.Alpha = double.Parse(rbAlphaLevel.SelectedValue.ToString());
            z.TwoTailed = bool.Parse(rbTwoTailed.SelectedValue.ToString());

            if (z.Alpha == 0.05 && z.TwoTailed == true)
            {
                z.CriticalZ = 1.960;
            }
            else if (z.Alpha == 0.05 && z.TwoTailed == false)
            {
                z.CriticalZ = 1.645;
            }
            else if (z.Alpha == 0.01)
            {
                z.CriticalZ = 2.326;
            }

            z.ObservedZ = (s.SampleMean - s.PopulationMean) / s.SampleStDev;

            autoAlpha.Text = z.Alpha.ToString();
            autoTwoTailed.Text = z.TwoTailed.ToString();
            autoCriticalZ.Text = z.CriticalZ.ToString();
            autoObservedZ.Text = z.ObservedZ.ToString();

            panAutoZ.Visible = true;

            ZStatisticController con = new ZStatisticController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            con.InsertSample(s);
            con.InsertZ(z);
        }

        protected void bManualCalc_Click(object sender, EventArgs e)
        {
            Sample s = new Sample();
            s.PopulationMean = double.Parse(tbPopMean.Text);

            double total = 0.0;
            double variance = 0.0;
            int sampsize = 0;
            List<double> calcVar = new List<double>();
            
            // Build the sample from user input
            foreach (string sNum in tbEnterObs.Text.Split(new char[] { ',' }))
            {
                double num = double.Parse(sNum);
                calcVar.Add(num);
                total += num;
                sampsize++;
            }
            s.SampleSize = sampsize;
            s.SampleMean = total / sampsize;


            for (int i=0; i<calcVar.Count; i++)
            {
                variance += (calcVar[i] - s.SampleMean) * (calcVar[i] - s.PopulationMean);
            }
            s.SampleStDev = Math.Sqrt(variance);


            // Calculate the Z score for this sample
            ZStat z = new ZStat();
            z.Alpha = double.Parse(rbAlphaLevel.SelectedValue.ToString());
            z.TwoTailed = bool.Parse(rbTwoTailed.SelectedValue.ToString());

            if (z.Alpha == 0.05 && z.TwoTailed == true)
            {
                z.CriticalZ = 1.960;
            }
            else if (z.Alpha == 0.05 && z.TwoTailed == false)
            {
                z.CriticalZ = 1.645;
            }
            else if (z.Alpha == 0.01)
            {
                z.CriticalZ = 2.326;
            }

            z.ObservedZ = (s.SampleMean - s.PopulationMean) / s.SampleStDev;
        }



        protected void bAutoHypTest_Click(object sender, EventArgs e)
        {
            panAutoResults.Visible = true;
            labAutoConfidence.Text = (100 - (double.Parse(autoAlpha.Text) * 100)).ToString() + "%";
            labAutoConfidence.ForeColor = System.Drawing.Color.DarkViolet;

            if (Math.Abs(double.Parse(autoCriticalZ.Text)) > Math.Abs(double.Parse(autoObservedZ.Text)))
            {
                labAutoHypObsZ.Text = "greater";
                labAutoHypObsZ.ForeColor = System.Drawing.Color.Green;

                labAutoPassFail.Text = "passed";
                labAutoPassFail.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labAutoHypObsZ.Text = "lesser";
                labAutoHypObsZ.ForeColor = System.Drawing.Color.Red;

                labAutoPassFail.Text = "failed";
                labAutoPassFail.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void bManHypTest_Click(object sender, EventArgs e)
        {
            panManualResults.Visible = true;
            labManConfidence.Text = (1 - (double.Parse(autoAlpha.Text) * 100)).ToString();
            labManConfidence.ForeColor = System.Drawing.Color.Violet;

            if (Math.Abs(double.Parse(manCriticalZ.Text)) > Math.Abs(double.Parse(manObservedZ.Text)))
            {
                labManHypObsZ.Text = "greater";
                labManHypObsZ.ForeColor = System.Drawing.Color.Green;

                labManPassFail.Text = "passed";
                labManPassFail.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labManHypObsZ.Text = "lesser";
                labManHypObsZ.ForeColor = System.Drawing.Color.Red;

                labManPassFail.Text = "failed";
                labManPassFail.ForeColor = System.Drawing.Color.Red;
            }
        }








        // WORK IN PROGRESS
        protected void FillObservations(Sample s)
        {

            ZStatisticController con = new ZStatisticController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
        }




        protected List<Observation> GetObservations()
        {
            ZStatisticController con = new ZStatisticController(ConfigurationManager.ConnectionStrings["DBInformation"].ToString());
            return con.GetObservations();

        }
    }
}