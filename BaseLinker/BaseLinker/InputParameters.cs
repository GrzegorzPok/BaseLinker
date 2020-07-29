using System;

namespace BaseLinker
{
    public class InputParameters
    {
        public int OrderId { get; set; }
        public int? NumberOfCopies { get; set; }
        public int? Seconds { get; set; }
        public bool IsCorrect { get; set; }

        public InputParameters()
        {
            NumberOfCopies = 1; // default number of copies
        }

        internal void FillParameters(string[] splittedStr)
        {
            try
            {
                if (splittedStr.Length == 1)
                {
                    OrderId = Int32.Parse(splittedStr[0]);
                }
                else if (splittedStr.Length == 3)
                {
                    OrderId = Int32.Parse(splittedStr[0]);
                    NumberOfCopies = Int32.Parse(splittedStr[1]);
                    Seconds = Int32.Parse(splittedStr[2]);
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid number of input parameters!");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            IsCorrect = true;
        }
    }
}
