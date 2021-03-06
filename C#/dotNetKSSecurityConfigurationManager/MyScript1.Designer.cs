//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:1.0.0.0
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

namespace dotNetKSSecurityConfigurationManager
{
    [global::System.Runtime.InteropServices.ComVisible(true)]
    [global::System.Runtime.InteropServices.Guid("10e0b421-039e-4f9b-896d-c7240b926aa6")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.0.0.0")]
    public interface IMyScript1Parameters : IMyScript1ParametersLocal
    {
        [global::System.Runtime.InteropServices.DispId(1)]
        string MySampleInput { get; set; }

    }

    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.0.0.0")]
    public interface IMyScript1ParametersLocal
    {
        string MySampleInput { get; }

    }

    [global::System.Runtime.InteropServices.ComVisible(true)]
    [global::System.Runtime.InteropServices.Guid("76075655-d5c4-4a78-aae3-2ec51db4cc5a")]
    [global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.0.0.0")]
    public sealed class MyScript1Parameters : KSParameters, IMyScript1Parameters
    {
        public string MySampleInput { get; set; }

    }

    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.0.0.0")]
    public partial class MyScript1 : KnowledgeScriptBase<MyScript1Parameters, IMyScript1ParametersLocal, WindowsNqExt, IWindowsNqExt>
    {
        protected override string LicenseData
        {
            get { return "x8PQfVzc+lXQyk5W1smjEd5hDE55igdJOohXMYlsHsv6hliTNTzc7JguIYj8OLrocD25lO+XU4qEzbfk7lhr2hNE+6TxTH6uQpPzH2bHbzo0XqhVh4eYmw=="; }
        }
        
        protected override string DesKey
        {
            get { return "ia0tFedtHkEHyOSVR6LxcPjRFQb4aROl0q49St55XSiGOSjnyKNZjYWN+DFbduywu4t9LblR2hwLeY08zcti4yKZJaUl1MPxiog/JSNlWu0uiJ/SB489oYo45U6qM/5KBMVnb5iY71qCn/ii1pIdanBXJaFb7WEVB1hID6L4s75ctLZjqQoSywtURSaAzMoC6etdNoshK9pcsg1SK210dC7EWm5GaekawcGNQk19w99KxLPfTBfb+wSBwDDdiAm565ahg8lOzNuYolzOrwpRP2PEZ0+czL8xvIe8j1KdYiF9Tu19oy+kaVGbNErUSMT8IwWFPM+fhjsvQSnAS8rj/Q=="; }
        }
    }

    [global::System.Runtime.InteropServices.ComVisible(true)]
    [global::System.Runtime.InteropServices.Guid("e1d01a20-8ab0-4ba7-a527-e64f7fc83641")]
    [global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.0.0.0")]
    public interface IMyScript1KnowledgeScript
    {
        IKsResponse Execute();
        MyScript1Parameters Parameters { get; }

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
    [global::System.Runtime.InteropServices.Guid("f12e97e1-a775-4f0d-80cb-b7006598f4f2")]
    [global::System.Runtime.InteropServices.ProgId("DNKS.dotNetKSSecurityConfigurationManager.MyScript1")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("KsSettingsTool", "1.0.0.0")]
    public sealed class MyScript1ScriptExecutor : BaseScriptExecutor<MyScript1, MyScript1Parameters, IMyScript1ParametersLocal, WindowsNqExt, IWindowsNqExt>, IMyScript1KnowledgeScript
    {
    }
}


