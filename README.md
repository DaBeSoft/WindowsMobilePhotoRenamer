# Windows Mobile Photo Renamer
Renames Windows 10 Mobiles RAW Photos to match the JPG names

The default Camera-App in Windows 10 (Mobile) saves the jpg and the RAW Photo with differrent Names. For Example:

WP_20161028_22_39_17_Raw__highres.dng - WP_20161028_22_39_17_Raw.jpg

That is a problem if you want to import the photos into Adobe Lightroom, because it doesnt detect it as the same photo.

So I wrote this little Tool to bulk rename all the Photos taken with my Lumia. After running the tool the names of the JPEG and the RAW File match and Lightroom detects it as duplicate.

#Usage
Just start the application and enter the path to your photos.

#Compile it yourself
There is a windows build provided in the release section.

Since this Program is written in .NET CORE its also possibl to run it on Linux or a Mac. You Probably have to compile it yourself tough.

git clone https://github.com/DaBeSoft/WindowsMobilePhotoRenamer.git
dotnet restore
dotnet run

More at:
https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/using-with-xplat-cli
