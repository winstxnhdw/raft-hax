# raft-hax

Internal cheats for [Raft](https://en.wikipedia.org/wiki/Raft_(video_game)).

## Requirements

- Windows 10 or higher
- [Microsoft .NET SDK](https://dotnet.microsoft.com/en-us/download)

## Installation

If you are on Windows 11, follow the instructions [here](https://github.com/winstxnhdw/rc15-hax/wiki) instead. Otherwise, recursively clone this repository.

```bash
git clone --recursive https://github.com/winstxnhdw/raft-hax.git
```

You can now build and install the dependencies by executing `requirements.bat`. It is not required to build dnSpy if you do not plan on doing any [development](#Development).

## Usage

Execute `launch.bat` when you have lauched the game.

## Development

[dnSpy](https://github.com/dnSpy/dnSpy) is included as a submodule when you recursively clone this directory. If you plan to contribute to the development, dnSpy is an invaluable tool for browsing the Raft source code. You may compile dnSpy by executing `requirements.bat` and entering `Y` when the prompt to build dnSpy appears. You can then run the compiled dnSpy executable.

```bash
dnSpy/dnSpy.exe &
```

## Developer Binds

All known/useful developer keyboard binds.

| Action  | Shortcut |
| ------- | -------- |
| NoClip (Save/Load) | Shift + N    |
| NoClip (Restore)   | N            |
| God Mode           | F2           |
| Restore Stats      | F3           |
| Starter Kit        | Shift + F4   |
| Paintbrush Kit     | Control + F4 |

## Developer Commands

All known developer commands.

| Action  | Command |
| ------- | -------- |
| Give    | /give [item-id] |
| Give OP Weapon | /give spear |
| Give Titanium Sword | /give sword |
| Reset Achievements | /reset achievements |
| Reset Interactables | /reset interactables |
| Reset Characters | /reset characters |
| Reset Buffs | /reset buff |
| Reset Timescale | /reset timescale |
| Teleport to Player | /tp [player-name] |
| Teleport to Treasure | /tp treasure |
| Teleport to Raft | /tp raft |
| Unlock All Characters | /unlock all |
| Unlock All Notes | /notebook all |
| Nuke Entities | /nuke |
| Treasure Kit | /kit treasure |
| Painting Redbeet Kit | /kit painting_redbeet |
| Painting Tangaroa Kit | /kit painting_tangaroa |
| Paintbrush Kit | /kit paintbrush |
| Resources Kit | /kit resources |
| Seedflower Kit | /kit seedflower |
| Seed Kit | /kit seed |
| Armor Kit | /kit armor |
| Tiki Kit | /kit tiki |
| Radio Kit | /kit radio |
| Armor Kit | /kit armor |
| Cassette Kit | /kit cassette |
| Hat Kit | /kit hat |
| Head Kit | /kit head |
| Utopia Kit | /kit utopia |
| Temperance Kit | /kit temperance |
| Bowl Recipe Kit | /kit recipebowl |
| Paper Recipe Kit | /kit recipepaper |
| Raw Food Kit | /kit foodraw |
| Cooked Food Kit | /kit foodcooked |
| Buff Kit | /kit buff |
| Play Test Kit | /kit playtest |
| Fishing Kit | /kit fishing |
| Trophy Fish Kit | /kit trophyfish |
| Blueprint Kit | /kit blueprint |
| Equip Hazmat | /hazmat [true/false] |

## Custom Binds

| Action  | Shortcut |
| ------- | -------- |
| Paddle  | F10      |
