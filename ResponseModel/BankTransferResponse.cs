//BANK TRANSFER RESPONSE
    public class BankTransferResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public BankTransferMetaData Meta { get; set; }
    }

    public class BankTransferMetaData
    {
        public BankTransferAuthorization Authorization { get; set; }
    }

    public class BankTransferAuthorization
    {
        public string TransferReference { get; set; }
        public string TransferAccount { get; set; }
        public string TransferBank { get; set; }
        public DateTime AccountExpiration { get; set; }
        public string TransferNote { get; set; }
        public long TransferAmount { get; set; }
        public string Mode { get; set; }
    }
