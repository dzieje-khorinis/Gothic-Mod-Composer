# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),

## [1.18.0] (2022-12-21)
### Added
- Build Mod Files configuration (with readonly 'Directories', 'Include', 'Exclude' sections for now)

## [1.17.0] (2022-12-19)
### Changed
- Upgraded solution to .NET 7
- Added retention for log files

## [1.16.0] (2022-07-06)
### Changed
- Disable app hiding mechanism. This will be fixed within - https://trello.com/c/SNpWUXBZ/152-rozdzieli%C4%87-minimalizowanie-i-zasobnik

### Fixed
- Couting elements in `Update mod extension files` step

## [1.15.1] (2022-01-18)
### Changed
- Improved hiding mechanism (now GUI hides to tray icon instead of task bar).

## [1.15.0] (2022-01-18)
### Fixed
- ZEN duplication on the list in some specific cases.

### Added
- Option to enable/disable auto ZEN list refresh mechanism.
- Option to force manual ZEN list refresh.
- Auto GUI hiding during profiles execution.

### Changed
- Removed `.ZEN` extension from worlds list in GUI.

## [1.14.0] (2021-12-02)
### Fixed
- ZEN duplication on the list in some specific cases.

### Changed
- Migration to .NET 6.
- Comparing directory names within assets directories are now case insensitive.

### Added
- In GUI there are new parameters for RunMod available:
  - Convert textures (`-ztexconvert`)
  - Convert data (`-zautoconvertdata`)
  - Convert all (`zconvertall`)
- Real-time counter while compiling meshes.
- GUI now requires Admin priviliges to run.
- Balloon tooltip after double click on G2 path or mod path in settings.

## [1.13.1] (2021-10-14)
### Fixed
- Real-time counter while compiling textures (with `ZCONVERTALL` parameter).

## [1.13.0] (2021-10-14)
### Fixed
- Update parses scripts (with `-ZREPARSE` parameter) when there is any change in Scripts folder.
- After profile execution is completed worlds are now properly refreshed.
- 'Clear logs directory' is disabled when there is no log files to clear.

### Changed
- UI improvements for 3D world list and icons.
- UI buttons alignment improvements in Settings window.
- Removed 640x480 resolution from the list.
- Removed old GMC application and related files from the modification repository.

### Added
- Real-time counter while compiling textures.
- GMC goes to tray icon on minimalize instead of exiting the app.
- Ability to copy paths to Gothic 2 Root and modification directories by double mouse click on textboxes.

## [1.12.0] (2021-09-27)
### Fixed
- VDF files are properly disabled after closing Spacer.
- ZEN worlds are now properly refreshed after `Compose` is finished.

### Changed
- Only supported resolutions are displayed.
- ZEN worlds are now sorted alphanumerical.
- ZEN worlds are now loaded in an asynchronous way.

### Added
- Support for starting GMC GUI at Windows startup.
- Support for `Music` and `Video` assets in G2 modification repository.
- Support for managing ZEN worlds from the list directly (deleting and renaming).
- Alert while executing `Build Mod File` profile when `GothicVDFS.exe` does not exist.
- Alert while executing `Update`/`Compose`/`Run Mod` profiles when `Gothic2.exe` does not exist.
- Buttons to open Gothic 2 and modification repository directories in windows explorer.
- Progress bar while loading ZEN Worlds.

## [1.11.0] (2021-09-23)
### Fixed
- Issue with long time closing GMC console.
- GUI doesn't loose ZEN World selection after profile execution.
- GUI can only we run once.
- Issue with crashing GMC when clearing logs.
- `Update Dialogues` step does not remove OU.BIN file anymore.

### Changed
- `Update Mod Extension` step copies files from mod's repo to Gothic root directory only if files differ.
- `Update`, `Compose` and `Enable VDF` profiles don't require ZEN World to be selected.
- `Disable BIK Video Files` step only disables `Logo1.bik` and `Logo2.bik` files instead of all `.bik` files.

### Added
- Option in GUI to make GMC console auto close after finish profile executing or not.
- Information in GUI when logs directory is cleared.
- New button in GUI to Run Editor/Spacer.

## [1.10.2] (2021-08-28)
### Fixed
- During 'Compose' only 'Scripts/_compiled' files are copied instead of whole Scripts directory. Whole Compose process should work properly now.
- Issue with worlds list refreshing in GUI when copying/pasting big size of world file to Worlds directory.
- Disable buttons (RunMod, Compose, Update) when there is no world on the list in GUI that is defined in configuration file.

## [1.10.1] (2021-08-27)
### Fixed
- Missing MUSIC.DAT file during 'Compose'.
- Add disable VDF files step during 'RestoreGothic'.

## [1.10.0] (2021-08-25)
### Changed
- Disable IniOverrides command step for 'Compose' and 'Update' profiles.
- Disable 'RunMod'/'Update'/'Compose' buttons when there is no 3D world selected.
- Profiles like 'Build Mod File', 'Restore Gothic', 'Enable VDF' don't require 3D world to be selected.
- REPARSEVIS parameter is not applied when there is ZREPARSE parameter set.

### Fixed
- Selected 3D world is now properly selected when running GMC UI or refreshing worlds list.

## [1.9.2] (2021-08-05)
### Fixed
- Wait for the process to exit before enabling FileWatcher directory subscription.

## [1.9.1] (2021-08-05)
### Fixed
- Issue with locked files by FileWatcher in `_Work\Data\Worlds` directory while running profiles.

## [1.9.0] (2021-08-05)
### Added
- New IniOverrides values in the following sections:
  - GAME
  - VIDEO
  - SOUND
- Zen 3D Worlds have visible full path with subfolders on the list.
- Zen 3D Worlds list is now automatically refreshed when there is any change (add new world, delete, rename) in the directory under `_Work\Data\Worlds`.

### Changed
- Cannot order IniOverrides table by `Key` column.

### Fixed
- Issue with saving newly added IniOverrides at the first time.
- Issue with playing Video when running Gothic with `RunMod` and `Update` profiles.

## [1.8.0] (2021-07-12)
### Changed
- New GMC.ini structure with default template.
- Disabled Overrides for SystemPack (till the original Overrides section will work as it should).

## [1.7.1] (2021-07-01)
### Fixed
- Remove the original entries in GMC.ini when have them in the `[OVERRIDES]` section in `OverrideIniCommand` step.
  
## [1.7.0] (2021-06-29)
### Added
- Manage IniOverrides in GUI:
  - Predefined values with custom values available.
  - Disable Overrides_SP section if System Pack is not available.
  - Restore default settings for IniOverrides section.

## [1.6.0] (2021-06-09)
### Added
- Handle Ini Overrides for SystemPack.
- New options in GUI Settings. We can now manage `IniOverrides` and `IniOverridesSP` values.
- Uncompiled files are now cleared during 'Compose' profile instead of 'RunMod' profile.
- GMC Version is now displayed directly in GUI also.
- GUI has option in menu to show ChangeLog and Trello board for the GMC project.

### Fixed
- Problem with duplication entries in `modFiles.json` file.
- Warnings are not displayed anymore when files are removed from the repository.

### Breaking Changes
- `gmc-2-ui.json` file has a little bit different structure. Because of this GUI will notify if we try to use the old one and will ask for removing the old configuration file.

## [1.5.0] (2021-05-24)
### Added
- New settings in GUI:
  - Resolution
- Add new steps in Compose profile. Video BIK are disabled before Gothic2.exe process is run and enabled after process is finished.
- More than one GMC profile cannot be executed at the same time (this works only from GUI).
- GMC logo icon (first draft).
  
### Changed
- GUI main page reorganization.
- ZEN's are read from Gothic directory, not from repository directory.
- When file is renamed that this action is loged as a 'rename' instead of 'moved'.
- GUI is now centered at startup.

## [1.4.0] (2021-05-12)
### Added
- New settings in GUI:
  - Restore Default configuration
  - Open Logs directory
  - Clear Logs directory

## [1.3.1] (2021-05-06)
### Fixed
- Settings from GUI are now used only for RunMod profile.

## [1.3.0] (2021-05-06)
### Added
- In GMC UI we have couple of additional setting parameters:
  - Window mode
  - Dev mode
  - Disable music
  - Disable sound
  - Reparse scripts
- GMC UI is looking for ZEN files also in subdirectories.

### Fixed
- In GMC UI ZEN files are now correctly verified if they are binary or not (based on their content instead of just size).

## [1.2.0] (2021-04-30)
### Added
- Settings window in GMC UI. We can set Gothic 2 root path, modification path and select 3D ZEN World.
- `--configurationFile` parameter in GMC.

## [1.1.1] (2021-04-22)
### Added
- `Gothic2.exe` compilation process is no longer ran when changes during the Update profile only happened in `Worlds` asset directory.
- MessageBox with confirmation before executing Compose ot RestoreGothic profile.

### Changed
- Order profiles in GMC UI.
- Improved `GMC.ini` content generation. Overriden elements are in the `[OVERRIDES]` section now.

### Fixed
- Order of dialogues compilation in *Compose* and *Update* profiles. Now dialogues compilation executes **after** scripts compilation by `Gothic2.exe` process.

## [1.1.0] (2021-04-02)
### Added
- GUI for GMC

## [1.0.4] (2021-04-01)
### Added
- Usage of `REPARSEVIS` parameter to `Gothic2.exe` when something is changed under `Scripts\System\VisualFX` directory.
- Removing `GMC.ini` helper file after each profile.
- Execute Gothic compilation step is now run conditionally only.

## [1.0.3] (2021-03-31)
### Added
- GMC version is now visible in log files.

### Fixed
- UpdateDialogues condition is now properly set.
- GMC Compose compilation crash due to missing `MUSIC.DAT` file under `Scripts/_compiled` directory.

## [1.0.2] (2021-03-30)
### Added
- Update dialogues step is executed only if needed.

### Fixed
- Problem with null reference exception in update dialogues.

## [1.0.1] (2021-03-29)
### Added
- Added `EnableVDF` profile.
- Handled null reference exception in CslWriter.
- Additional logging in case of unexpected exception in updating dialogues command.

## [1.0.0] (2021-03-26)
### Added
- Removing uncompiled assets (from Textures and Meshes folders) on `RunMod.bat` profile.

## [0.0.5] (2021-03-12)
### Changed
- Optimized dialogues updating step. Now it's changed to execute in Parallel instead of synchronously which is ~4 times faster than before`.

## [0.0.4] (2021-03-03)
### Added
- Added new profile - BuildModFile + created `BuildModFile.bat` to execute GMC with this profile easily.
- Added new configuration section in `gmc-2.json` file called 'GothicVdfsConfig'

## [0.0.3] (2021-03-01)
### Removed
- 'GothicRoot' configuration path from the `gmc-2.json` file and moved it as an argument of `GMC-2.exe`.

## [0.0.2] (2021-02-25)
### Added
- 'VDFS:PHYSICALFIRST' argument to `Gothic2.exe` in RunMod profile.
- GMC version is now displayed in GMC console title bar.

### Changed
- All `.bat` files to run GMC on maximized console window instead of windowed ones.

## [0.0.1] (2021-02-25)
### Added
- First official release of new GMC-2 tool.

[1.14.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.14.0
[1.13.1]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.13.1
[1.13.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.13.0
[1.12.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.12.0
[1.11.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.11.0
[1.10.2]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.10.2
[1.10.1]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.10.1
[1.10.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.10.0
[1.9.2]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.9.2
[1.9.1]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.9.1
[1.9.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.9.0
[1.8.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.8.0
[1.7.1]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.7.1
[1.7.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.7.0
[1.6.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.6.0
[1.5.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.5.0
[1.4.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.4.0
[1.3.1]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.3.1
[1.3.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.3.0
[1.2.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.2.0
[1.1.1]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.1.1
[1.1.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.1.0
[1.0.4]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.0.4
[1.0.3]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.0.3
[1.0.2]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.0.2
[1.0.1]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.0.1
[1.0.0]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/1.0.0
[0.0.5]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/0.0.5
[0.0.4]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/0.0.4
[0.0.3]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/0.0.3
[0.0.2]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/0.0.2
[0.0.1]: https://gitlab.com/dzieje-khorinis/gmc-2/-/releases/0.0.1
