function IsAdministrator
{
	$Identity = [System.Security.Principal.WindowsIdentity]::GetCurrent()
	$Principal = New-Object System.Security.Principal.WindowsPrincipal($Identity)
	$Principal.IsInRole([System.Security.Principal.WindowsBuiltInRole]::Administrator)
}

function IsUacEnabled
{
	(Get-ItemProperty HKLM:\Software\Microsoft\Windows\CurrentVersion\Policies\System).EnableLua -ne 0
}

if (!(IsAdministrator))
{
    if (IsUacEnabled)
    {
			# We are not running "as Administrator" - so relaunch as administrator

			# Create a new process object that starts PowerShell
			$newProcess = new-object System.Diagnostics.ProcessStartInfo "PowerShell";

			# Specify the current script path and name as a parameter
			$newProcess.Arguments = $myInvocation.MyCommand.Definition;

			# Indicate that the process should be elevated
			$newProcess.Verb = "runas";

			# Start the new process
			[System.Diagnostics.Process]::Start($newProcess);

			# Exit from the current, unelevated, process
			exit    
		}
    else
    {
			throw "You must be administrator to run this script"
    }
}

$source = "Log4NetSample"

if ([System.Diagnostics.EventLog]::SourceExists($source) -eq $false) {
	[System.Diagnostics.EventLog]::CreateEventSource($source, "Application")
	"Created event source $source"
} else {
	"Event source $source already exists"
}

Read-Host
