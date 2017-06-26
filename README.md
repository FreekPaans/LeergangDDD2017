## LocalDB benodigd

Voor dit practicum is het noodzakelijk dat er een werkende localdb met de naam `(localdb)\v12.0` op je machine staat.

Je kan dit met het commando `sqllocaldb i` testen:
```
C:\>sqllocaldb i
MSSQLLocalDB
ProjectsV12
v12.0
```

Als `sqllocaldb` niet uitgevoerd kan worden, dan moet je waarschijnlijk eerst MS SQL Express (waar localdb een onderdeel van uitmaakt) installeren, zie [https://docs.microsoft.com/ru-ru/sql/database-engine/configure-windows/sql-server-2016-express-localdb]() .

Als `sqllocaldb` wel werkt, maar `v12.0` er niet tussen staat, maak deze dan aan:
```
C:\>sqllocaldb c "v12.0"
```
