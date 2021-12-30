# GPSPlus
GPSPlus is a resource for FiveM by Albo1125 that provides GPS functionality based on street names.

## Installation & Usage
1. Download the latest release.
2. Unzip the GPSPlus folder into your resources folder on your FiveM server.
3. Add the following to your server.cfg file:
```text
ensure GPSPlus
```
4. Optionally, customise the command in `sv_GPSPlus.lua`.
5. Optionally, customise the street names and coordinates in `streetmappings.json`.

## Commands & Controls
* /gps STREETNAME - Sets a waypoint to the closest match for STREETNAME. If STREETNAME unrecognised or unspecified, removes the waypoint.

## Improvements & Licencing
Please view the license. Improvements and new feature additions are very welcome, please feel free to create a pull request. As a guideline, please do not release separate versions with minor modifications, but contribute to this repository directly. However, if you really do wish to release modified versions of my work, proper credit is always required and you should always link back to this original source and respect the licence.

## Libraries used (many thanks to their authors)
* [CitizenFX.Core.Client](https://www.nuget.org/packages/CitizenFX.Core.Client)
* [Newtonsoft.Json](https://www.nuget.org/packages/newtonsoft.json/12.0.2)