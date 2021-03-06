//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:1.4.2.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using SdNcenter.Dnks.Parameters;
using SdNcenter.Dnks.Executors;
using SdNcenter.Dnks.KnowledgeScripts;
using SdNcenter.Dnks.Responses;
using SdNcenter.Dnks.ReportingTargets;
using SdNcenter.Dnks.PowerShell.KnowledgeScripts;

namespace powerShellKnowledgeScript1
{
    [global::System.Runtime.InteropServices.ComVisible(true)]
    [global::System.Runtime.InteropServices.Guid("fbcece91-1fb5-49d8-9e5f-1b3ea8d0c2a3")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.4.2.0")]
    public interface IAmazonCloudWatchParameters : IAmazonCloudWatchParametersLocal
    {
        [global::System.Runtime.InteropServices.DispId(1)]
        string EngineName { get; set; }
        [global::System.Runtime.InteropServices.DispId(2)]
        string AccessKey { get; set; }
        [global::System.Runtime.InteropServices.DispId(3)]
        string SecretKey { get; set; }

    }

    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.4.2.0")]
    public interface IAmazonCloudWatchParametersLocal
    {
        string EngineName { get; }
        string AccessKey { get; }
        string SecretKey { get; }

    }

    [global::System.Runtime.InteropServices.ComVisible(true)]
    [global::System.Runtime.InteropServices.Guid("f13b37db-83df-445c-910e-27f1e89d214f")]
    [global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.4.2.0")]
    public sealed class AmazonCloudWatchParameters : KSParameters, IAmazonCloudWatchParameters
    {
        public string EngineName { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }

    }

    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.4.2.0")]
    public partial class AmazonCloudWatch : PowerShellKnowledgeScriptBase<AmazonCloudWatchParameters,IAmazonCloudWatchParametersLocal, WindowsNqExt, IWindowsNqExt>
    {
        protected override string LicenseData
        {
            get { return "NTGUrdAkkSAevBD36HwJ5Aecidv416hxvq+VOHGhT1jTpCAKJzT/aJf0GLSHWrw92c1zykXYR0IS9SB0jzVkxHO01Po2UGlVl7IVMnApO0M="; }
        }
        
        protected override string DesKey
        {
            get { return "l6LJxKWDrFNCgCCr013uxq1o3vUsELZhriWpQ2+zRGvk0kFed/m94SAdcvz/OsZEmo4ps4KO04cf5vKiEPPnm7XrbRwNYjBOdqBFN7hwx/rA+49rwbDOehy5OVWViw5niIb8DIb2rCqJURt8TlT1+/vEEzeKxeCGvBnTP2WfsqyjrM7XaGQniZRm0QNa5Y01ut7olFIFxakK9GlZOSrDKqQDIZL1WwDyNR6XEv7QWDtGyccJwHv4hsIPlZpJj7C3Fjlk+Bi1twpaL4fZDA1AD3xk7QG2bGp7A/vy/JshCRKomVyI/0YwX2CLMO/WrH3i/okLX6HFb/dzrmFOkt+tjQ=="; }
        }

    }

    [global::System.Runtime.InteropServices.ComVisible(true)]
    [global::System.Runtime.InteropServices.Guid("4520acf1-adc4-4ce2-8204-f7751fe63e37")]
    [global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.4.2.0")]
    public interface IAmazonCloudWatchKnowledgeScript
    {
        IKsResponse Execute();
        AmazonCloudWatchParameters Parameters { get; }

        void SetVersion(string version);
        void SetCounterValue(double counterValue);
        void SetExecCommandResult(string execCommandResult);
        void SetJobID(long jobId);
        void SetMachName(string name);
        void SetScriptInterval(long interval);
        void SetIterationCount(long iterationCount);

        void SetImportData(string data);
        void SetTempFileName(string fileName);
        void SetDynaCollectDataReturn(bool ret);
        void SetDynaDataLogReturn(bool ret);

        void SetAgentInfoProdType(string prodType);
        void SetAgentInfoAgtVer(string agtVer);
        void SetAgentInfoInstallDir(string installDir);
        void SetContextExReturn(string value);
        void SetContextExPropValue(string value);

        void SetSecurityContextReturn(bool value);
        void SetSecurityContextValue(string value);
        void SetMCEnterCSReturn(long value);
        void SetMCGetMOIDReturn(string value);
        void SetMCVersionValue(string value);
        void SetNQSleepReturn(long value);
    }

    [global::System.Runtime.InteropServices.ComVisible(true)]
    [global::System.Runtime.InteropServices.Guid("04989420-01cf-49b8-b941-9f896e00818f")]
    [global::System.Runtime.InteropServices.ProgId("powerShellKnowledgeScript1.AmazonCloudWatch")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.4.2.0")]
    public sealed class AmazonCloudWatchScriptExecutor : BaseScriptExecutor<AmazonCloudWatch, AmazonCloudWatchParameters, IAmazonCloudWatchParametersLocal, WindowsNqExt, IWindowsNqExt>, IAmazonCloudWatchKnowledgeScript
    {
    }
}


