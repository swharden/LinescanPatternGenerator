rmdir /S /Q "X:\Software\Linescan Pattern Generator"
dotnet publish ../src/ --configuration Release
robocopy "..\src\bin\Release\net6.0-windows\publish" "X:\Software\Linescan Pattern Generator" /E /NJH /NFL /NDL
pause