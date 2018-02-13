#
#
#
# MyScript1.Tests.ps1
#
#
#
. "$((get-item env:DNKS_PATH).Value)\Include.ps1"

Describe "ExecuteKnowledgeScript" {
	Context "Execute_ValidInput_EventRaised" {
		$Parameters.AccessKey="AKIAJVVK2KSEDYK4ZXMA";
		$Parameters.SecretKey="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";
		$Parameters.EngineName="sqlserver-ex";

		Mock CreateEvent { }

		$result = Execute

		It "Called once with severity 5" {
			Assert-MockCalled CreateEvent -Times 1 -ParameterFilter { $sev -eq 5 }
		}
	}
}
