using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco.cms.businesslogic.datatype;

namespace Kyber.TimePicker.UI
{
    public class TimePickerDataType : AbstractDataEditor
    {


        public override string DataTypeName
        {
            get { return "Umbraco TimePicker"; }
        }

        public override Guid Id
        {
            get { throw new NotImplementedException(); }
        }
    }
}