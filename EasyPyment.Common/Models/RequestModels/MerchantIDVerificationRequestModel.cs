using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.RequestModels
{
   public class MerchantIDVerificationRequestModel
    {
        public string account_number { get; set; }
        public string account_bank { get; set; }
    }
}
