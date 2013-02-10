using System;
using umbraco.cms.businesslogic.datatype;

namespace JKarsrud.TimePicker.UI
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