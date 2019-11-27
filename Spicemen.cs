using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class Spicemen
    {
        private String _number;
        private DateTime _arrivalDate;
        private String _description;
        private List<String> _contacts;
        private List<Test> _tests;

        //update
        public State CurrentState = State.reception;
        private DateTime StartResearch, EndResearch;
        private String Expert;
        
        public bool CorrectNumber(String newValue)
        {
            if (CurrentState == State.reception)
            {
                this._number = newValue;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CorrectArrivalDate(DateTime newValue)
        {
            if (CurrentState == State.reception)
            {
                this._arrivalDate = newValue;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CorrectDescription(String newValue)
        {
            if (CurrentState == State.reception)
            {
                this._description = newValue;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CorrectContacts(List<String> newValue)
        {
            if (CurrentState == State.reception)
            {
                this._contacts = newValue;
                return true;
            }
            else
            {
                return false;
            }
        }

        private Spicemen(String number, DateTime date, String description, List<String> contacts)
        {
            this._number = number;
            this._arrivalDate = date;
            this._description = description;
            this._contacts = contacts;
            this._tests = new List<Test>();
            this.StartResearch = DateTime.Now;
            this.CurrentState = State.reception;

        }

        public static Spicemen CreateSpicement(String number, String strDate, String description, List<String> contacts)
        {
            DateTime date;
            if (!DateTime.TryParse(strDate, out date))
            {
                throw new System.ArgumentException();
            }
            return new Spicemen(number, date, description, contacts);

        }

        public List<Test> Tests
        {
            get { return _tests; }
        }

        public bool IsChecked()
        {
            if (this._tests.Count != 0 && this.CurrentState == State.processing)
            {
                int importantTestsFailed = 0, usualTestsFailed = 0;
                foreach (Test analysis in this._tests)
                {
                    if ((analysis.Description.Category == Importance.important) && (!analysis.IsSuccessful()))
                    {
                        importantTestsFailed++;
                    }
                    if ((analysis.Description.Category == Importance.usual) && (!analysis.IsSuccessful()))
                    {
                        usualTestsFailed++;
                    }
                }

                if ((importantTestsFailed == 0) && (usualTestsFailed <= 2))
                    return true;
                else
                    return false;
            }
            else
                throw new Exception("Can't be tested!");
        }

        public bool AddTest(String number, String start, String end, String assistant, double result, int choice, TestDescription testType)
        {
            if (this.CurrentState == State.research)
            {
                Test test = Test.ConductTest(number, start, end, assistant, result, testType);
                this._tests.Add(test);
                return true;
            }

            else
                return false;
            
        }

        public bool AddTest(Test test)
        {
            if (this.CurrentState == State.research)
            {
                this._tests.Add(test);
                return true;
            }

            else
                return false;
        }

        public bool StartProcessing()
        {
            if (this.CurrentState == State.research)
            {
                this.CurrentState = State.processing;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool StartResearching()
        {
            if (this.CurrentState == State.reception)
            {
                StartResearch = DateTime.Now;
                this.CurrentState = State.research;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool AnalysisCompleted(String researcher)
        {
            if (this.CurrentState == State.processing)
            {
                this.CurrentState = State.archive;
                this.EndResearch = DateTime.Now;
                this.Expert = researcher;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool CorrectTestResult(String testNumber, double newResult)
        {
            if (this.CurrentState == State.processing)
            {
                for (int i = 0; i < this._tests.Count; i++)
                {
                    if (this._tests[i].Number == testNumber)
                    {
                        return this._tests[i].CorrectResult(this, newResult);
                    }
                }
            }

            return false;
        }

    }
}
