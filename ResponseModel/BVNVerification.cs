 //BVN VERIFICATION
  public class BvnResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public BVNDetails Data { get; set; }
    }

    public class BVNDetails
    {
        public long bvn { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string date_of_birth { get; set; }
        public string phone_number { get; set; }
        public string registration_date { get; set; }
        public string enrollment_bank { get; set; }
        public string enrollment_branch { get; set; }
        public string image_base_64 { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string watch_listed { get; set; }
        public string Nationality { get; set; }
        public string marital_status { get; set; }
        public string state_of_residence { get; set; }
        public string lga_of_residence { get; set; }
        public string Image { get; set; }
    }