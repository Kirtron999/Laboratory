using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Laboratory
{
    public class FileRepository : IRepository
    {
        public String FileTxt, FileDat;
        
        public FileRepository(String txt, String dat)
        {
            this.FileDat = dat;
            this.FileTxt = txt;
        }

        public List<TestInInterval> ReadTypicalTestsDat()
        {
            List<TestInInterval> typical = new List<TestInInterval>();
            using (StreamReader source = new StreamReader(FileDat))
            {
                String line;
                while ((line = source.ReadLine()) != null)
                {
                    String temp, test;
                    int index;

                    // выделение имени
                    String name;

                    index = line.IndexOf('|');
                    name = line.Substring(0, index);
                    line = line.Substring(index + 1);

                    //выделение категории
                    Importance category;

                    index = line.IndexOf('|');
                    temp = line.Substring(0, index);
                    line = line.Substring(index + 1);

                    if (temp == "HI")
                    {
                        category = Importance.important;
                    }
                    else if (temp == "NR")
                    {
                        category = Importance.usual;
                    }
                    else
                    {
                        throw new Exception("Illegal data(category) format");
                    }

                    //выделение минимального результата
                    double minResult;

                    index = line.IndexOf('|');
                    temp = line.Substring(0, index);

                    //проверка корректности значения
                    if (temp.IndexOf('.') != -1)
                    {
                        test = temp;
                        test = test.Substring(test.IndexOf('.') + 1);

                        if (test.Length > 2)
                        {
                            throw new Exception("Illegal data(min result) format");
                        }
                    }
                    else
                    {
                        throw new Exception("Illegal data(min result) format");
                    }
                    temp = temp.Replace('.', ',');
                    line = line.Substring(index + 1);

                    Console.WriteLine(temp);

                    minResult = Convert.ToDouble(temp);

                    //выделение максимального результата
                    double maxResult;

                    index = line.IndexOf('|');
                    temp = line.Substring(0, index);

                    //проверка корректности значения
                    if (temp.IndexOf('.') != -1)
                    {
                        test = temp;
                        test = test.Substring(test.IndexOf('.') + 1);

                        if (test.Length > 2)
                        {
                            throw new Exception("Illegal data(max result) format");
                        }
                    }
                    else
                    {
                        throw new Exception("Illegal data(max result) format");
                    }

                    temp = temp.Replace('.', ',');
                    line = line.Substring(index + 1);

                    maxResult = Convert.ToDouble(temp);

                    //выделение обозгначения единицы измерения
                    String unitSymbol;

                    index = line.IndexOf('|');
                    unitSymbol = line.Substring(0, index);
                    line = line.Substring(index + 1);

                    //выделение названия единицы измерения
                    String unitName;
                    unitName = line;

                    typical.Add(new TestInInterval(name, category, new Range1Interval(minResult, maxResult), unitName, unitSymbol));
                }
            }
            return typical;
        }
        public List<TestInInterval> ReadTypicalTestsTxt()
        {
            List<TestInInterval> typical = new List<TestInInterval>();
            using (StreamReader source = new StreamReader(FileTxt))
            {
                String line;
                while ((line = source.ReadLine()) != null)
                {
                    String temp, test;
                    int index;

                    //выделение категории
                    Importance category;

                    index = line.IndexOf(';');
                    temp = line.Substring(0, index);
                    line = line.Substring(index + 1);

                    if (temp == "1")
                    {
                        category = Importance.important;
                    }
                    else if (temp == "0")
                    {
                        category = Importance.usual;
                    }
                    else
                    {
                        throw new Exception("Illegal data(category) format");
                    }

                    //выделение имени
                    String name;

                    index = line.IndexOf(';');
                    name = line.Substring(0, index);
                    line = line.Substring(index + 1);

                    //выделение минимального результата
                    double minResult;

                    index = line.IndexOf(';');
                    temp = line.Substring(0, index);

                    //проверка корректности значения
                    if (temp.IndexOf(',') != -1)
                    {
                        test = temp;
                        test = test.Substring(test.IndexOf(',') + 1);

                        if (test.Length > 1)
                        {
                            throw new Exception("Illegal data(min result) format");
                        }
                    }
                    else
                    {
                        throw new Exception("Illegal data(min result) format");
                    }

                    line = line.Substring(index + 1);

                    minResult = Convert.ToDouble(temp);

                    //выделение максимального результата
                    double maxResult;

                    index = line.IndexOf(';');
                    temp = line.Substring(0, index);

                    //проверка корректности значения
                    if (temp.IndexOf(',') != -1)
                    {
                        test = temp;
                        test = test.Substring(test.IndexOf(',') + 1);

                        if (test.Length > 1)
                        {
                            throw new Exception("Illegal data(max result) format");
                        }
                    }
                    else
                    {
                        throw new Exception("Illegal data(max result) format");
                    }

                    line = line.Substring(index + 1);

                    maxResult = Convert.ToDouble(temp) + minResult;

                    //выделение обозгначения единицы измерения
                    String unitSymbol;

                    index = line.IndexOf(';');
                    unitSymbol = line.Substring(0, index);
                    line = line.Substring(index + 1);

                    //выделение названия единицы измерения
                    String unitName;
                    unitName = line.Substring(0, line.IndexOf(';'));

                    typical.Add(new TestInInterval(name, category, new Range1Interval(minResult, maxResult), unitName, unitSymbol));
                }
            }
            return typical;
        }
    }
}
