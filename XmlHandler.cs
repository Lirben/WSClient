using System;
using LibEquine;
using System.Xml;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace WSClient
{
    class XmlHandler
    {
        private XmlDocument _xmlDoc;
        public List<Sample> SampleList { get; set;  }

        public XmlHandler()
        {
            _xmlDoc = new XmlDocument();
            SampleList = new List<Sample>();

            XmlElement rootEl = _xmlDoc.CreateElement("Equine");
            _xmlDoc.AppendChild(rootEl);
        }

        public void Clear()
        {
            _xmlDoc.DocumentElement.RemoveAll();
        }

        public void WriteSample(Sample sample)
        {
            XmlElement sampleEl = _xmlDoc.CreateElement("Sample");
            XmlElement timeEl = _xmlDoc.CreateElement("Time");
            XmlElement hoofEl = _xmlDoc.CreateElement("Hoof");

            timeEl.InnerText = sample.timestamp.ToString();
            hoofEl.InnerText = ((int)sample.hoof).ToString();                      

            sampleEl.AppendChild(timeEl);
            sampleEl.AppendChild(hoofEl);

            foreach (Types.SensorLocation sensorLocation in Enum.GetValues(typeof(Types.SensorLocation)))
            {
                XmlElement DataEl = _xmlDoc.CreateElement(sensorLocation.ToString());
                DataEl.InnerText = sample.forcevalues[(int)sensorLocation].ToString();
                sampleEl.AppendChild(DataEl);
            }

            _xmlDoc.DocumentElement.AppendChild(sampleEl);
        }

        public void SaveToFile(string xmlFileName)
        {
            _xmlDoc.Save(xmlFileName);
            SampleList.Clear();
            _xmlDoc.DocumentElement.RemoveAll();
        }

        public void LoadFile(string xmlFileName)
        {
            SampleList.Clear();
            _xmlDoc.Load(xmlFileName);

            foreach(XmlNode sampleNode in _xmlDoc.DocumentElement.ChildNodes)
            {
                int[] forceValues = new int[4];

                foreach (Types.SensorLocation sensorLocation in Enum.GetValues(typeof(Types.SensorLocation)))
                    forceValues[(int)sensorLocation] = int.Parse(sampleNode.SelectSingleNode(sensorLocation.ToString()).InnerText);


                SampleList.Add(new Sample((Types.HoofLocation)int.Parse(sampleNode.SelectSingleNode("Hoof").InnerText),
                    uint.Parse(sampleNode.SelectSingleNode("Time").InnerText), forceValues));
            } 
        }
    }
}
