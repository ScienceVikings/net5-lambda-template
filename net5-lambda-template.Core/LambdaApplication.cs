using System;

namespace net5_lambda_template.Core
{
    public class LambdaApplication
    {
        public string DoTheJob(string input)
        {
            Console.WriteLine(input);
            return input.ToUpper();
        }
    }
}