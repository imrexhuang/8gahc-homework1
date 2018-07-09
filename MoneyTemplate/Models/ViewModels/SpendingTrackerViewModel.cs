using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MoneyTemplate.Models.ViewModels
{
    public class SpendingTrackerViewModel
    {
        [DisplayName("類別")]
        public TypeEnum TYPE { get; set; }

        [DisplayName("日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DATE { get; set; }

        [DisplayName("金額")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public int AMOUMT { get; set; }

        [DisplayName("備註")]
        public String REMARK { get; set; }
    }

    public enum TypeEnum
    {
        收入 = 'D',
        支出 = 'C'
    }
}