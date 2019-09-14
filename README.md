# Guardian
Basic Debugger Detection in C# (Process Monitor, Anti-Debugger)

**TO THE SKIDS:** Stop using my code without giving credits thx.

## Instructions
1. Clone & Build the DLL
2. Add Guardian.dll as a reference to your project
3. Go to the main function (before the GUI appears) and add the following code in it:
```cs
string urlForHashCheck = "https://pastebin.com/raw/eFKXR4Jq"; // Upload the MD5 hash of your finished file to pastebin (you can use any other site)
bool AntiDump = true; // Set this to true if you want to prevent your assembly from being dumped from the memory
bool AntiDebug = true; // Activates the process monitor and scans for debugger tools
bool AntiEmulation = true; // Blocks emulation, virtual machines & sandboxie
List<string> AntiNetBlacklist = new List<string>() { "pastebin.com", "mywebsite.tld", "someIpOfYourServer" }; // Add your website(s) to be blocked from host file editing

Guardian.Main.Start(urlForHashCheck, AntiDump, AntiDebug, AntiEmulation, AntiNetBlacklist); // Run Guardian with the settings provided above
```
4. Done

### NO FURTHER SUPPORT WILL BE PROVIDED!!!