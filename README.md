# 🎼 Genshin Impact Audio Exporter
This tool allows you to export audio files from Genshin Impact game data into different audio formats.

- Single executable file, all required libraries are already included
- Supports `.wav`, `.mp3`, `.ogg` and `.flac` audio formats
- Easy to use interface, no command line needed

### How to use

The audio files are saved as `.pck` data files within the Genshin Impact game data directory.
Example audio files location:
```
C:\Program Files\Genshin Impact\Genshin Impact Game\GenshinImpact_Data\StreamingAssets\Audio\GeneratedSoundBanks\Windows
```

1. Open the program and select which  `.pck` data files you would like to extract audio files from.
2. Select an output directory to save exported audio files to.
3. Choose your preferred audio formats to export to.
4. Click `Export` and wait for the program to finish exporting the audio files.


### Example

![Example](example.gif?raw=true "Example")

### Notes

When exporting has started, the program will create two directories named `libs` and `processing`. Do not remove or modify the contents of these directories as they are needed during the export process. They will be deleted automatically when the program is closed.

All previously exported audio files in the output directory *will be overwritten* when the same audio files are being exported again.
