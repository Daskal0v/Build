namespace Build.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum DateFormat
{
    [Description("MM/DD/YYYY")]
    MonthDayYear = 1,
    [Description("DD/MM/YYYY")]
    DayMonthYear = 2

}
