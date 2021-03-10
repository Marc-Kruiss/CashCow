//@BaseCode
using System;

namespace CommonBase.Extensions
{
    public static class ObjectExtensions
    {
        public static void CheckArgument(this object obj, string argument)
        {
            if(obj is null)
            {
                throw new ArgumentNullException(nameof(argument));
            }
        }
    }
}
