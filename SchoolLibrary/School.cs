using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        //Auto-properties 
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure it starts with @ symbol
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("Twitter address must begin with @");
                }
            }
        }
        //how to pull in the same namespace twice (not usual)
        // Elementary.Volume volume;
        // High_School.Volume volume2;

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        // static = can see outside of this class without instantiating 
        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(this.Address);
            sb.AppendLine(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append(" ");
            sb.Append(Zip);

            return base.ToString();
        }
    }
}
