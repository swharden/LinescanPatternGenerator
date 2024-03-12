rmdir /S /Q "X:\Software\Linescan Pattern Generator"
dotnet publish ../src/ --configuration Release
robocopy "..\src\bin\Release\net8.0-windows\publish" "X:\Software\Linescan Pattern Generator" /E /NJH /NFL /NDL
explorer "X:\Software\Linescan Pattern Generator"
pause