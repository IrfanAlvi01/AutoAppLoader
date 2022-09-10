# AutoAppLoader
## Description:
A custom auto application loader for windows, which load your favourite apps on every bootup. Its completly customizable,
more apps can be add or remove by hard code or adding them from app GUI(Custom app Menu). Also has a Single Click load functionality.

## How to Run: 
To start project in your Visual Studio, you need to open `GUI.sln` file with visual studio and all project files will start appearing in your
VS project explorer.

## Working:
After loading project in VS code, theres GUI directory which contain all source code of this project. `Program.cs` contain driver code for this
project. All functionalities of this project are modular and located in separate files. `CustomA-B.cs` files contain code for custom app loading
functionlity, where `panelShooter.cs` file has code for multi-mode screenshooter. `Setting.cs` has very basic setting options & more planned to implement
in future, whereas `SubMainA-B.cs` files are self-explainatory.
