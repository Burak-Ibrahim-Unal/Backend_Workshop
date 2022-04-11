# Windows Service Example 2022

## General info
This project is made as a Windows Service...Just Checking Google and Facebook online or not... And create log at your local C drive
	
## Technologies
Project is created with:
* Net Core 6


To run this project's backend side, run powershell as a administrator:

```
Example
New-Service -Name ServiceName -BinaryPathName "ServicePath" -DisplayName "ServiceDisplayName" -StartupType Automatic
```

```
Example
New-Service -Name SmsTestService -BinaryPathName "D:\xxx\Publish\WindowsService\SmsWorkerService.exe" -Description "Otomatik Sms Test Service" -DisplayName "BurakTestService" -StartupType Automatic
```