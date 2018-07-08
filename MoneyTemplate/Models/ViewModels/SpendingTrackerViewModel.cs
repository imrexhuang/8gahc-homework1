using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MoneyTemplate.Models.ViewModels
{
    public class SpendingTrackerViewModel
    {
        [DisplayName("類別")]
        public String TYPE { get; set; }

        [DisplayName("日期")]
        public String DATE { get; set; }

        [DisplayName("金額")]
        public int AMOUMT { get; set; }

        [DisplayName("備註")]
        public String REMARK { get; set; }
    }
}