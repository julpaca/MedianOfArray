using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingMedianOfArray
{
    public class Array
    {
        private List<double> _doubleArray = new List<double>();
        private int _indexOfMedian = 0;

        public List <double> Arr
        {
            get { return _doubleArray; }
            set { _doubleArray = value; }
        }

        public int Median
        {
            get { return _indexOfMedian; }
        }

        public bool isTbNotEmpty(string tbArrayText)
        {
            if (tbArrayText.Length == 0)
                return false;
            else 
                return true;
        }

        public bool CanStringArrayConvertedToDouble(string tbArrayText)
        {
            bool canStringArrayConvertedToDouble = true;
            StringBuilder tbStringBuilder = new StringBuilder(tbArrayText);

            for (int i = tbStringBuilder.Length - 1; tbStringBuilder[i] == ' '; i--)
            {
                tbStringBuilder.Length--;
            }

            tbArrayText = Convert.ToString(tbStringBuilder);

            string[] stringArray = tbArrayText.Split(' ');

            foreach (string elemInArray in stringArray)
            {
                double elemInDouble = 0;
                bool result = double.TryParse(elemInArray, out elemInDouble);
                if (result == false)
                {
                    canStringArrayConvertedToDouble = false;
                    break;
                }
            }
            return canStringArrayConvertedToDouble;
        }

        public List <double> ConvertArrayInTb(string tbArrayText)
        {
            _doubleArray.Clear();
            bool canBeConverted = CanStringArrayConvertedToDouble(tbArrayText);
            StringBuilder tbStringBuilder = new StringBuilder(tbArrayText);

            for (int i = tbStringBuilder.Length - 1; tbStringBuilder[i] == ' '; i--)
            {
                tbStringBuilder.Length--;
            }

            tbArrayText = Convert.ToString(tbStringBuilder);

            //tbArray.Text = Convert.ToString(RemoveSpaces(tbStringBuilder));
            string[] stringArray = tbArrayText.Split(' ');
            //List<double> _doubleArray = new List<double>();

            foreach (string elemInArray in stringArray)
            {
                double elemInDouble = 0;
                bool result = double.TryParse(elemInArray, out elemInDouble);
                if (result == true)
                {
                    elemInDouble = Convert.ToDouble(elemInArray);
                    _doubleArray.Add(elemInDouble);
                }
            }

            string concatenation = default;
            foreach (double elemInDoubleArray in _doubleArray)
            {
                concatenation += Convert.ToString(elemInDoubleArray);
                concatenation += ' ';
                tbArrayText = concatenation;
            }

            if (canBeConverted == false)
            {
                //canBeConverted = false;
                System.Windows.Forms.MessageBox.Show("Найденные в массиве некорректные значения были удалены.", "Упс!");
            }
            return _doubleArray;
        }

        public int FindingOfMedian()
        {
            //string median = default;
            double max = 0;
            double min = _doubleArray[0];
            double leftSum = 0;
            double rightSum = 0;
            for (int i = 0; i < _doubleArray.Count; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += _doubleArray[j];
                }
                for (int k = i + 1; k < _doubleArray.Count; k++)
                {
                    rightSum += _doubleArray[k];
                }

                if (Math.Abs(leftSum - rightSum) >= max)
                    max = Math.Abs(leftSum - rightSum);
            }

            for (int i = 1; i < _doubleArray.Count - 1; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < i; j++)
                    leftSum += _doubleArray[j];
                for (int k = i + 1; k < _doubleArray.Count; k++)
                    rightSum += _doubleArray[k];
                if (Math.Abs(leftSum - rightSum) <= max)
                    max = Math.Abs(leftSum - rightSum);
            }

            for (int i = 1; i < _doubleArray.Count - 1; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < i; j++)
                    leftSum += _doubleArray[j];
                for (int k = i + 1; k < _doubleArray.Count; k++)
                    rightSum += _doubleArray[k];
                if (Math.Abs(leftSum - rightSum) == max)
                    _indexOfMedian = Convert.ToInt32(i+1);
            }
            return _indexOfMedian;
        }
    }
}
