# StockViewer
Displays at the top of the screen (over windows but not over games) the live prices of stocks from the yahoo database.

## Description
The program was made to help me view live stock prices in one place at a glance without the need to open a website.<br/>
The application is customizable, you can modify the stocks that it shows and many more.<br/>
It even works if you have multiple screens.

## How to use
Download the latest version of .exe from Releases and run it.<br/>
To change the settings or to exit the program you can find the blue icon in the System Tray.<br/>
For the changes in the Settings to take effect you need to press “Ok”.

## Optional compile
Open “StockViewer.sln” with Visual Studio and open Tools -> NuGet Package Manager -> Package Manager Console<br/>
Write in the console the command: dotnet publish -c Release<br/>
The output will be a .exe file in the “StockViewer\bin\Release\net5.0-windows\win-x64\publish”