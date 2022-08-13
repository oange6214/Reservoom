# Reservoom

It's about C# WPF MVVM Tutorial. 

Please see: https://www.youtube.com/watch?v=fZxZswmC_BY&list=PLA8ZIAm2I03hS41Fy4vFpRw8AdYNBXmNm&index=1

#1  Models - WPF MVVM TUTORIAL 

#2  Views - WPF MVVM TUTORIAL 

#3  View Models - WPF MVVM TUTORIAL 

#4  Commands - WPF MVVM TUTORIAL 

#5  Navigation - WPF MVVM TUTORIAL 

#6  Services (w/ Entity Framework) - WPF MVVM TUTORIAL 

#7  Stores - WPF MVVM TUTORIAL 

#8  Feedback (Loading, Validation, Error Messages) - WPF MVVM TUTORIAL 

#9  .NET Generic Host - WPF MVVM TUTORIAL 

#10 Publishing - WPF MVVM TUTORIAL 
	一、發佈 Release 版本: dotnet publish -c Release
	二、發佈 Release 版本，並包含 .NET 套件: dotnet publish -c Release --self-contained
	三、發佈 Release 版本，並包含 .NET 套件，且濃縮檔案數量: dotnet publish -c Release --self-contained -p:PublishSingleFile=true
	四、發佈 Release 版本，並包含 .NET 套件，且濃縮為一個檔案: dotnet publish -c Release --self-contained -p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true
	五、發佈 Release 版本，並包含 .NET 套件，且濃縮為一個檔案，設定執行環境 win-x64: dotnet publish -c Release --self-contained -r win-x64 -p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true