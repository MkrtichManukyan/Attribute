using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class MyAttribute : System.Attribute
    {
        private readonly string _date;

        public string Date
        {
            get { return _date; }
        }

        public MyAttribute(string date)
        {
            this._date = date;
        }

        private int _number;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
