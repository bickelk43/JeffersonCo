INSTALLATION
#########################
>	Option 1:
	>>	Click on "Install.bat" to install the application
>	Option 2:
	>>	Navigate to "PaperCutDesktopManager_Alpha\Setup\Debug" and run the "Setup.exe"
	>>	The wizard will walk you through the basic install. 
>	Option 3:
	>>	Use the MSI in "PaperCutDesktopManager_Alpha\Setup\Debug" for installation

>	In PaperCut, you will need to add your IP as a trusted source to run API requests
	>>	This can be found here: http://[server ip]:9191/app?service=page/OptionsAdvanced
	>>	Options > Advanced > Allowed XML Web Services callers (this is towards the bottom)
	
>	If you have a nonstandard port, from the initial install, this will be a little funky, and I may have to modify the code
	a little bit for this to work. Just let me know if that is the case.
	
>	On the first run, click on "Configuration" in the menu bar, and enter in your servers IP address, and the PaperCut
	administrator password. This is needed in order for the application to make the call to the API. Settings will be saved in
	the PaperCutDesktopManager_Alpha.exe.Config. This is encrypted, using Triple DES Encryption.

What does it do?
#########################
>	Search for a username in the top left field, and return all values that are being displayed in the main window.

>	User Update:
	>>	If you would like to adjust any of these values, click on the checkbox at the bottom left, and enable the textbox fields. To save,
		click on "Update" to update the user. 

>	User and group sync:
	>>	If you want to trigger a manual sync of users and groups, click on "Sync" at the top left.

Notes
#########################
>	All source code is included
>	Bug reports/feature requests can be emailed to bickelk@jr7.k12.mo.us
>	If you wish to keep the config file empty of the PaperCut admin password, clear it out and save it, before you exit the application
	>>	I plan on fixing this at some point. This was a "quick and dirty" concept that I ended up bundling up for internal use
	
Changelog
#########################
4/15/19
	>	Correct name shows up when installed, instead of "setup" - 4/15/19
	>	Run as admin by default added
	>	Encrypted App.Config to protect plaintext credential info, and server info
		>>	Info will still be displayed to the user in plaintext





