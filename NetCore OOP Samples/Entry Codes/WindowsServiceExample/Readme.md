# Windows Service Example 2022

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)

## General info
This project is made with Net Core and React.
	
## Technologies
Project is created with:
* React: 17.0.2
* Net Core: 6.0.2 (Net Core Sdk 6)
* Nodejs : 16.14.0
* Sqlite
* Visual Studio Code


To run this project's backend side, run powershell as a administrator:

```
Example
New-Service -Name ServiceName -BinaryPathName "ServicePath" -DisplayName "ServiceDisplayName" -StartupType Automatic
```
Example
New-Service -Name SmsTestService -BinaryPathName "D:\xxx\Publish\WindowsService\SmsWorkerService.exe" -Description "Otomatik Sms Test Service" -DisplayName "BurakTestService" -StartupType Automatic
