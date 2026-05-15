# FORGED - Workout Hub

FORGED; en enkel, webbaserad
workout tracker-applikation byggd med Blazor och C#, samt implementationen av en
säker och automatiserad CI/CD-pipeline enligt DevSecOps-principer.
Bakgrunden till projektet är att det vid utveckling av webbaserade applikationer ofta
saknas en sammanhållen och automatiserad process från kodändring till driftsättning.
Manuella processer ökar risken för mänskliga fel, säkerhetsbrister och inkonsekventa
miljöer.
En fungerande Blazor-applikation med grundläggande CRUD-
funktionalitet för loggning av träningspass och aktiviteter.
Applikationen är
containeriserad med Docker och publiceras via en automatiserad GitHub Actions-
pipeline. Pipelinen automatiserar kodkontroll, bygge och Docker-image-skapande vid
varje kodändring.
