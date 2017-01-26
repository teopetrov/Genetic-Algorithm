using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OphirLMMeasurementLib;

namespace GeneticAlgorithm
{
    [Status(Utilities.DevelopementStatus.Active)]
    [DDL("EvaluatorOphirLM8", "Ophir LM 8 products")]
    public class EvaluatorOphirLM8 : IEvaluator
    {
        protected int imageSize = 0;
        int hDevice = 0;
        CoLMMeasurement LM;
        public EvaluatorOphirLM8()
        {
            this.initDevice();
        }
        //~EvaluatorOphirLM8()
        //{
        //    this.closeDevice();
        //}
        protected void initDevice()
        {
            object serialNumbers = new object();
            LM = new CoLMMeasurement();
            LM.ScanUSB(out serialNumbers);
            string[] serialNumbersArray = (string[])serialNumbers;
            if (serialNumbersArray.Length == 0)
            {
                throw new Exception("Evaluator device cannot be found.");
            }
            LM.OpenUSBDevice(serialNumbersArray[0], out this.hDevice);
            LM.ConfigureStreamMode(this.hDevice, 0, 2, 1);
            LM.StartStream(this.hDevice, 0);
            //maybe sleep 1000?
        }
        public void closeDevice()
        {
            LM.StopStream(this.hDevice, 0);
            LM.Close(this.hDevice);
        }
        public double calculateFitness(IndividualBase ind)
        {
            double ret = 0;
            //TODO: send image to phase modulator
            object value, timestamp, status;
            LM.GetData(this.hDevice, 0, out value, out timestamp, out status);
            if (((string[])status)[0] == "0")
            {
                ret = Convert.ToDouble(((string[])value)[0]);
            }
            return ret;
        }
        public double getMaxScore()
        {
            return imageSize * Configuration.pixelMaxValue;
        }
        public List<int> getSampleImage()
        {
            return Utilities.getFocusingMirror(this.imageSize);
        }
    }
}
