# GPS Trap Creator

Windows application for creating GPS polygon zones for RaceBoy-G35 lap timing system. Generates track zone files by placing markers on satellite maps and exporting polygon coordinates as CSV files.

## Overview

Creates rectangular GPS "trap" zones around race track checkpoints. Each zone is defined by four corner coordinates that the Arduino system uses to detect when a vehicle passes through during lap timing.

## Features

- **Satellite Map Interface** - Bing Maps integration with search functionality
- **Dual Marker Mode** - Place zone points and angle reference points
- **Automatic Polygon Generation** - Creates rotated rectangles based on track direction
- **CSV Export** - Exports coordinates in Arduino-compatible format

## Requirements

- Windows with .NET Framework 4.5.2+
- Internet connection for map tiles
- Visual Studio 2015+ (for building)

## Dependencies

```xml
GMap.NET.WindowsForms (1.7.5)
Newtonsoft.Json (10.0.3)
```

## Usage

### Creating Track Zones

1. **Search Location**: Enter track name and click Search
2. **Place Zone Points**: Select "Lay Points" and double-click to place green markers
3. **Place Angle Points**: Select "Lay Angles" and place red markers for track direction
4. **Generate Zones**: Click "Prepare" to create polygon zones
5. **Export**: Click "Export CSV" to save track file

### Zone Placement Strategy

- Place zone markers at key track positions (start/finish, turn exits, etc.)
- Place angle markers to indicate track direction at each zone
- Zones are created as rectangles rotated to match track angle

## CSV Output Format

```
Zone 0,lat1,lat2,lat3,lat4,lng1,lng2,lng3,lng4,zone_count
Zone 1,lat1,lat2,lat3,lat4,lng1,lng2,lng3,lng4,zone_count
```

- Coordinates multiplied by 10,000,000 for integer storage
- Four corner points define rectangular zone boundary
- Compatible with RaceBoy Arduino lap timing system

## Building

1. Open solution in Visual Studio
2. Restore NuGet packages
3. Build solution (Release configuration recommended)

## Integration

Generated CSV files are loaded onto SD card in `/Tracks` folder for use with RaceBoy-G35 system. Arduino code reads these files to create GPS polygon detection zones for lap timing.

## Controls

- **Double-click**: Place marker on map
- **Click marker**: Remove marker (with confirmation)
- **Search**: Find track by name
- **Clear All**: Remove all markers and reset
- **Prepare**: Generate polygon zones from markers
- **Export CSV**: Save track file for Arduino system

## Author

**John Daley** - Part of the RaceBoy-G35 system
