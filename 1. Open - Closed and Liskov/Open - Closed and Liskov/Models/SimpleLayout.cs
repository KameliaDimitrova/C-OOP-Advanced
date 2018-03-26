using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using Open___Closed_and_Liskov.Models.Contracts;

namespace Open___Closed_and_Liskov.Models
{
   public class SimpleLayout:ILayout
   {
        //error.DateTime-e....
       private const string DateFormat = "M/d/yyyy h:mm:ss tt";
        private const string Format = "{0} - {1} - {2}";

        public string FormatError(IError error)
        {
            string dateString = error.DateTime.ToString(DateFormat, CultureInfo.InvariantCulture);
            string formatedError = string.Format(Format, dateString, error.Level.ToString(),error.Message);
            return formatedError;
        }
    }
}
 