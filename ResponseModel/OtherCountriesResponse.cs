    //OTHER COUNTRIES RESPONSE MODEL{THEY ALL HAVE THE SAME RESPONSES}

    public class OtherCountryResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public OtherCountryMetaData Meta { get; set; }
    }

    public class OtherCountryMetaData
    {
        public OtherCountryAuthorization Authorization { get; set; }
    }

    public class OtherCountryAuthorization
    {
        public string Redirect { get; set; }
        public string Mode { get; set; }
    }