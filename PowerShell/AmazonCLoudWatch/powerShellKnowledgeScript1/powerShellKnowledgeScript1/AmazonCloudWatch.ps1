
Function Execute() {
	#Todo: Implement Your Knowladge Script 
	#Todo: Use $NqExt to access NetIQ methods
	#Todo: Use $Parameters to access your inputs
	
	#Run this script locally in debug mode at least once to get the intellisense loaded and code suggestions working

	$awsCredentials = New-Object -TypeName Amazon.Runtime.BasicAWSCredentials -ArgumentList($Parameters.AccessKey,$Parameters.SecretKey);

	$cw = New-Object -TypeName Amazon.CloudWatch.AmazonCloudWatchClient($awsCredentials,[Amazon.RegionEndpoint]::USEast2);
	$dimension = New-Object -TypeName Amazon.CloudWatch.Model.Dimension;
	$dimension.Name="EngineName";
	$dimension.Value=$Parameters.EngineName;

	$msr = New-Object -TypeName Amazon.CloudWatch.Model.GetMetricStatisticsRequest;
	$msr.Dimensions.Add($dimension);
	$msr.StartTime=[System.DateTime]::Now.AddHours(-5);
	$msr.EndTime=[System.DateTime]::Now;
	$msr.Unit = [Amazon.CloudWatch.StandardUnit]::Percent;
	$msr.MetricName="CPUUtilization";
	$msr.Namespace="AWS/RDS";
	$msr.Period=5*60;
	$msr.Statistics.Add("Average");

	$result = $cw.GetMetricStatistics($msr);

	$thresholdExceeded=$FALSE;
	ForEach ($datapoint in $result.Datapoints)
	{
		If ($datapoint.Average -gt 1)
		{
			$thresholdExceeded=$TRUE;
			break;
		}
	}

	if ($thresholdExceeded) {
		$NqExt.CreateEvent(5, "Amazon AWS MSSQL CPU Level Exceeded","AKP_NULL", [string]::Empty, 0.0d, "CPU Utilization Exceeded Threshold for: $($Parameters.EngineName)", [string]::Empty, 0, 0, 0);
	}
	#Sample Usage:
	#$NqExt.CreateData(null, null, null, null, 0, "Data point details, Param2: " + $Parameters.MySampleInput, 0, null, 0, 0, 0, 0)
	#$NqExt.QTrace("Trace details")
	#$ver = $NqExt.GetVersion()	
}

#Do not remove
If($runOnAgent){Execute}Else{. "$(get-item $PSScriptRoot).PowerShell\AmazonCloudWatch.Tests.ps1"}