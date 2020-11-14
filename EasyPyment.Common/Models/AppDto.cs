using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPyment.Common.Models
{
    public class AppDto
    {
        public long Id { get; set; }

        public string AppName { get; set; }
        public string AppCode { get; set; }
        public string AppKey { get; set; }
        public string ServicePrincipal { get; set; }
        public bool IsActive { get; set; }

    }
}
