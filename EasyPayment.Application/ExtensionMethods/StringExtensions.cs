using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPayment.Application.ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool Equate(this string value, string comparer)
        {
            if ((string.IsNullOrEmpty(value)) || (string.IsNullOrEmpty(comparer)))
                throw new NullReferenceException();
            return value.Trim().ToLower().Equals(comparer.Trim().ToLower());
        }

    }
}
