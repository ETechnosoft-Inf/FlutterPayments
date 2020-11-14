using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models.ResponseModels
{
    public class OtherCountriesResponses
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
}
