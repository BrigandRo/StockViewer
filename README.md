# StockViewer
Displays at the top of the screen (over the windows but not over games) the live prices of stocks from the yahoo database.

## Description
The program was made to help me view live stock prices in one place at a glance without the need to open a website.
You can modify the stocks that it shows, the screen if you have multiple and many more.

## Usage
Unzip the “EXE.rar” to the desktop or any other place and run it.
To change the settings or to exit the program you can find the blue icon in the System Tray.
For the changes in the Settings to take effect you need to press “Ok”.

## Optional compile
Open “StockViewer.sln” with Visual Studio and open Tools -> NuGet Package Manager -> Package Manager Console
Write in the console the command: dotnet publish -c Release
The output will be a .exe file in the “StockViewer\bin\Release\net5.0-windows\win-x64\publish”
