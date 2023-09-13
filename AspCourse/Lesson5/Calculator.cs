using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Calculator
    {
        // Поля
        private string _version;

        private double _lastResult;

        private string _history;

        //Свойства


        //Конструктор
        public Calculator()
        {
            this._version = "1.0";
            this._history = "Created\n";
        }

        public double Sum (double x, double y) 
        {
            double result = x + y;
            this._history += $"Sum: {x} + {y} = {result}\n";
            this._lastResult = result;
            return result;
        }

        public double Difference(double x, double y)
        {
            double result = x - y;
            this._history += $"Difference: {x} - {y} = {result}\n";
            this._lastResult = result;
            return result;
        }

        public double Mult(double x, double y)
        {
            double result = x * y;
            this._history += $"Mult: {x} * {y} = {result}\n";
            this._lastResult = result;
            return result;
        }

        public double Divide(double x, double y)
        {
            double result = x / y;
            this._history += $"Sum: {x} / {y} = {result}\n";
            this._lastResult = result;
            return result;
        }

        public string GetHistory()
        {
            return _history;
        }
        public string GetVersion()
        {
            return _version;
        }
        public string GetLastResultString()
        {
            return _lastResult.ToString();
        }
        public double GetLastResultDouble()
        {
            return _lastResult;
        }
    }
}
