# Infinite_dungeon
Przed uruchomieniem projektu

USUN�� WSZYSTKIE MIGRACJE!!!

add-migration InitialCreate
Update database powinie� wystarczy�. 
W przypadku problem�w z uruchomienieniem prosze o kontakt jakub.krzeminski1998@gmail.com

zalecam uruchamianie za pomoc� visual studio 2022

Je�li powy�sza metoda nie dzia�a
zmiana "DefaultConnection" w program.cs na "Infinite_dungeon"
SQL Server Object Exploler prawy przycisk myszy na databases > Add New Database > Name "Infinite_dungeon"
Project > Connected Services > SQL Server database > SQL Server Express LocalDB 
add-migration InitialCreate
update-database