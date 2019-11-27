using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class Test
    {
        
        private String _number;
        private DateTime _startDateTime;
        private DateTime _endDateTime;
        private String _labAssistant;
        private double _result;
        private readonly TestDescription _description;

        public TestDescription Description
        {
            get { return _description; }
        }

        public String Number
        {
            get { return _number; }
        }

        public bool CorrectResult(Spicemen self, double newResult)
        {
            if (self.CurrentState == State.processing)
            {
                this._result = newResult;
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public bool IsSuccessful()
        {
            return this._description.InRange(this._result);
        }

        private Test(String number, DateTime startDateTime, DateTime endDateTime, String labAssistant, double result, TestDescription type)
        {
            this._number = number;
            this._startDateTime = startDateTime;
            this._endDateTime = endDateTime;
            this._labAssistant = labAssistant;
            this._result = result;
            this._description = type;

        }

        public static Test ConductTest(String number, String startTime, String endTime, String assistant, double result, TestDescription testType)
        {
            DateTime start, end;
            if (!DateTime.TryParse(startTime, out start) || !DateTime.TryParse(endTime, out end))
            {
                throw new System.ArgumentException();
            }
            return new Test(number, start, end, assistant, result, testType);
        }

        
    }
}
