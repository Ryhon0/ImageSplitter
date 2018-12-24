# ImageSplitter
Image splitter is a program which allows you to split images into squares, originally created as a command for a Discord Bot. It uses System.Drawing to  and [gifsicle](https://www.lcdf.org/gifsicle/) to conver images to .gif files

## Download
ImageSplitter is available for Windows and Linux/MacOS by using [Wine](https://wiki.winehq.org/Download) or [Mono](https://www.mono-project.com/download/stable/)
### [Download Page](https://github.com/Ryhon0/ImageSplitter/releases)
You need all the .exe files in the same folder and [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework-runtime) on Windows or [Wine](https://wiki.winehq.org/Download) and [Mono](https://www.mono-project.com/download) on Unix-like systems

# How to use
* Run `ImageSplitter.Winforms.exe`

    * Windows:

    ![](start.jpg)
    * Linux/MacOS: Open your console in the folder with the downloaded files and run `wine ImageSplitter.Winforms.exe`, on Mac and some desktop enviroments you can just double click it to run
    
    ![](startunix.jpg)

* Generate your images
    ![](generate.jpg)
    * Enter the path for the image and output loaction
    * Set the square size and the prefix or surfix
    * If you are using a animated file you can set the framerate
    * Generate preview to preview how the emotes will look
    * Generate your emotes

* Add the emotes to your Discord server, you can use `emotes.txt` to paste them quickly into chat

    ![](emotes.jpg)
    ![](discord.jpg)

# To do
* Add vertical and horizontal gap option
* Use a rendering engine with hardware acceleration support
* Automatically adjust the square size based on the column or row count