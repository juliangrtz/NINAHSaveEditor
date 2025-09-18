# Yes, I'm a Save Editor

<img width="872" height="354" alt="image" src="https://github.com/user-attachments/assets/73490c4c-e2a9-4b42-9631-fcadf2ac7df7" />

A Windows save game editor for **[No, I'm not a Human](https://store.steampowered.com/app/3180070/No_Im_not_a_Human/)**.  
This tool allows you to **decrypt, inspect, edit, and re-encrypt** `.sav` files used by the game.  
It is intended for educational and modding purposes — use at your own risk.

## Requirements
- Steam
- No, I'm not a Human
- .NET Framework 4.8 (preinstalled on Windows 11)
  
## Features

- Fully compatible with the game’s save system.
- The editor parses the full object tree dynamically.
- Edit fields directly inside the app.
- After editing, saves back to `.sav` format that the game accepts.

## Installation

Download the latest archive in [the Releases tab](https://github.com/juliangrtz/NINAHSaveEditor/releases).

Alternatively:

1. Clone the repository:
   ```bash
   git clone https://github.com/juliangrtz/NINAHSaveEditor
   cd NINAHSaveEditor
   ```
2. Open the solution in Visual Studio 2022 or Rider.

3. Build the project (Debug or Release).

## Disclaimer

This project is not affiliated with Trioskaz or Critical Reflex.
I do have their explicit permission to develop this tool.
Use of this editor may corrupt your saves or affect gameplay. Always back up your save files before editing!

## Technical Notes

### Encryption Scheme

- AES-256
- CBC mode
- PKCS7 padding

First 16 bytes of ciphertext = IV.

### Encoding

Data is Base64-encoded for storage.

### Serialization

Save data is a JSON structure with IL2CPP $type metadata.
