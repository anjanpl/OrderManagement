# Vault Set Up for VNEXT:

1. > Get sourcegear vault standard client version 8.0.1 from [https://sourcegear.com/vault/downloads2.html](https://sourcegear.com/vault/downloads2.html)

1. > Once installed connect to 10.2.115.110 using your assigned username and pw.

1. ![Source Gear Vault](https://raw.githubusercontent.com/anjanpl/OrderManagement/master/SourceGearVault.png)

1. > Select Repository PowerNET.vNext
1. > Once open select $ and then open File > Set Up Working Folder (set to C:\Dev\ PowerNET.vNext) 
1. > SourceGear Vault setting should be as Tools -> Options 
   ![Source Gear Vault Setting](https://raw.githubusercontent.com/anjanpl/OrderManagement/master/SourceGearVaultSetting.png)
1. > Get latest $/Web/currentbranchname (replace currentbranchname  to nemesia)with sub folders
1. > Get latest $/Service/currentbranchname (replace currentbranchname  to nemesia) with sub folders
1. > Once completed getting latest files
1. > Open Dos as administrator. Basically, we need to open Developer Command Prompt for VS2015 as administrator.
    * Make sure you do have Dot Net Framework 4.5 Installed
    * If not installed download this from 
        [https://dotnet.microsoft.com/en-us/download/dotnet-framework/net45](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net45) and install
    * Visual Studio 2015 Settings should be as Tools > NuGet Package Manager > Package Manager Settings
    ![Visual Studio 2015 Settings](https://raw.githubusercontent.com/anjanpl/OrderManagement/master/VS2015Settings.png)
    Need to put **NNR** in **Name** textbox and the following link in the **Source** textbox.
    [http://tcjp.nnrglobal.com/guestAuth/app/nuget/v1/FeedService.svc/](http://tcjp.nnrglobal.com/guestAuth/app/nuget/v1/FeedService.svc/)
    
    
1. > Change folder to working root set up in step 5
    ![Developer Command Prompt for VS2015](https://raw.githubusercontent.com/anjanpl/OrderManagement/master/PortalCreationProcessLocally.png)
1. > Type command **devprov create currentbranchname**  (replace currentbranchname  to nemesia) as like above image.
1. > If portal creation process is sucessful this will return as the folllowing image.
     ![Developer Command Prompt for VS2015 Process Completed](https://raw.githubusercontent.com/anjanpl/OrderManagement/master/SucessfulInvokePortal.png)
1. > Once all portal invokes and opened at the browser the UI should be look like below.
![Developer Command Prompt for VS2015 Process Completed](https://raw.githubusercontent.com/anjanpl/OrderManagement/master/PackageInstallation.png)
1. > Package Installation should be done for all the portals opened in the browser using proper Credential Details
1. > Once sites open login with nnrusa user credentials for VNEXT