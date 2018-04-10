# SteamVR Launcher from Mixed Reality

This simple application uses the Steam protocol extension to launch SteamVR from a Windows Mixed Reality Environment. It provides a 3D icon which will allow you to pin the Application in your house to use the next time you enter Mixed Reality.

## How to install:

Microsoft will not allow Apps in the store that launch other Apps unless that other App is also in the store. SteamVR is not in the Microsoft Store so this App will not be approved. To get around this, you will have to sideload the app.

You have two choices to install:
- Build the code yourself, no other steps needed, other than to enable developer mode in Windows 10. If you are building the code
you know how to do that.
- If you don't want to build the code yourself.
    1. download the .zip file from the Release tab and unzip it. The zip file contains two files, the certificate needed in the next step and the App bundle.
    1. Follow these instructions to side load App: https://docs.microsoft.com/en-us/windows/application-management/sideload-apps-in-windows-10#how-do-i-sideload-an-app-on-desktop
    
## Running the App
Once installed, you will see an icon in the Recently Added section of the 
Start Menu. If you don't see the Steam VR Launcher App, the App isn't installed. If the App installed, you can startup Windows Mixed Reality and the App will show up when you view `All Apps` after pressing the Windows key on your controller. That's it, just select it and you can pin it to your environment!
