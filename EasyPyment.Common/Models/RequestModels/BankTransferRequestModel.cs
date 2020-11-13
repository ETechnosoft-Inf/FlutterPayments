using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.RequestModels
{
   public class BankTransferRequestModel
    {
        public string tx_ref { get; set; }
        public string amount { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string currency { get; set; }
        public int duration { get; set; }
        public int frequency { get; set; }
        public string narration { get; set; }
        public bool is_permanent { get; set; }
    }
}
