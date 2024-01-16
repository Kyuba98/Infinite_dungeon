# Infinite_dungeon
Przed uruchomieniem projektu

USUN¥Æ WSZYSTKIE MIGRACJE!!!

add-migration InitialCreate
Update database powinieñ wystarczyæ. 
W przypadku problemów z uruchomienieniem prosze o kontakt jakub.krzeminski1998@gmail.com

zalecam uruchamianie za pomoc¹ visual studio 2022

Jeœli powy¿sza metoda nie dzia³a
zmiana "DefaultConnection" w program.cs na "Infinite_dungeon"
SQL Server Object Exploler prawy przycisk myszy na databases > Add New Database > Name "Infinite_dungeon"
Project > Connected Services > SQL Server database > SQL Server Express LocalDB 
add-migration InitialCreate
update-database