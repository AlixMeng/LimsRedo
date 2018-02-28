using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimsRedo
{
    public class Controller
    {
        DatabaseReader databaseReader = new DatabaseReader();
        DatabaseWriter databaseWriter = new DatabaseWriter();

        public void EnterData(SampleDataAttributes sampleDataAttributes)
        {
            databaseWriter.InsertSample(sampleDataAttributes);
        }

        public List<string> GetSampleByValue(string searchValue, string spParameter)
        {
            return databaseReader.GetSampleByValue(searchValue, spParameter);
        }

        public List<string> GetSampleByID(int sampleID)
        {
            return databaseReader.GetSampleByID(sampleID);
        }
        public bool CanConvertToDouble(string str)
        {
            return StringToDouble.CanConvertToDouble(str);
        }
        public double ConvertToDouble(string str)
        {
            return StringToDouble.ConvertToDouble(str);
        }
    }
}
