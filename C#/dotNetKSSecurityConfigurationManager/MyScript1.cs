using System;

namespace dotNetKSSecurityConfigurationManager
{
    public sealed partial class MyScript1
    {
        protected override void Execute()
        {
            string email = string.Empty;
            var response = NqExt.GetContextEx("label", "MyApplication", "sub-label", "emailAddress", "val1", ref email);
        }
    }
}