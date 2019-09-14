# Guardian
Basic Debugger Detection in C# (Process Monitor, Anti-Debugger)

**TO THE SKIDS:** Stop using my code without giving credits thx.

## Instructions
- Clone & Build the DLL
- Add Guardian.dll as a reference to your project
- Go to the main function (before the GUI appears) and add the following code in it:
```cs
string urlForHashCheck = "https://pastebin.com/raw/eFKXR4Jq"; // Upload the MD5 hash of your finished file to pastebin (you can use any other site)
bool AntiDump = true; // Set this to true if you want to prevent your assembly from being dumped from the memory
bool AntiDebug = true; // Activates the process monitor and scans for debugger tools
bool AntiEmulation = true; // Blocks emulation, virtual machines & sandboxie
List<string> AntiNetBlacklist = new List<string>() { "pastebin.com", "mywebsite.tld", "someIpOfYourServer" }; // Add your website(s) to be blocked from host file editing

Guardian.Main.Start(urlForHashCheck, AntiDump, AntiDebug, AntiEmulation, AntiNetBlacklist); // Run Guardian with the settings provided above
```

## Further Improvements you can make
- Add more protections
- Optimize the performance
- Fix some of the code
- Add a simple hash check for the DLL to prevent file replacing
- Obfuscate the DLL

### This project is not longer active, so I made it open-source.
### If you have any questions just message me on Discord: KNIF#0001
