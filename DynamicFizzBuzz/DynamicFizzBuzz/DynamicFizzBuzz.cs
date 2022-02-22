using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFizzBuzz
{
    public class DynamicFizzBuzz
    {
        public void Handle(DynamicFizzBuzzRequest request, Action<string> handleResult)
        {
            var result = string.Empty;

            for(var i = 1; i <= request.MaxNumber; i++)
            {
                var innerResult = string.Empty;
                foreach (var key in request.Configurations)
                {
                    if(i % key.Key == 0)
                    {
                        innerResult += key.Value;
                    }
                }

                if (string.IsNullOrEmpty(innerResult))
                {
                    result = i.ToString();
                }
                else
                {
                    result = innerResult;
                }

                handleResult(result);
            }
        }
    }
}
