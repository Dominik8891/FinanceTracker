# FinanceTracker 💰

Ein smarter, lokaler Finanzmanager für den Raspberry Pi. Entwickelt mit **C#**, **ASP.NET Core Blazor** und **Entity Framework Core**.

Diese Anwendung hilft dabei, Einnahmen und Ausgaben im Blick zu behalten und komplexe Schuldenverhältnisse zwischen Nutzern transparent zu verwalten.

## 🚀 Vision & Features

### Aktueller Stand (MVP)
- **Einnahmen & Ausgaben:** Schnelles Erfassen von Transaktionen.
- **Dashboard:** Echtzeit-Berechnung des Kontostands und der Summen.
- **SQLite Integration:** Robuste Datenhaltung in einer lokalen Datei.
- **Responsive UI:** Optimiert für die Nutzung am Smartphone (ideal für unterwegs) und PC.

### Geplante Erweiterungen (Roadmap)
- [ ] **Multi-User Login:** Sicheres Authentifizierungssystem für verschiedene Benutzer.
- [ ] **Social Debt Tracking:** - Andere Nutzer als Gläubiger oder Schuldner direkt im System verknüpfen.
    - Gemeinsame Verwaltung von Schuldenständen.
- [ ] **Bestätigungsworkflow (Vier-Augen-Prinzip):** - Wenn ein Gläubiger eine Zahlung einträgt (z. B. Sondertilgung), muss der Schuldner dies bestätigen, bevor der Saldo aktualisiert wird.
    - Schutz vor Fehleingaben oder vergessenen Einträgen.
- [ ] **Hosting auf Raspberry Pi:** Automatischer Start als Linux-Service.

## 🛠 Tech Stack

- **Framework:** .NET 8.0 (Blazor Server)
- **Sprache:** C# (C-Sharp)
- **Datenbank:** SQLite
- **ORM:** Entity Framework Core (EF Core)
- **Styling:** Bootstrap 5

## 🛠 Voraussetzungen (Prerequisites)

Bevor du startest, stelle sicher, dass folgende Tools auf deinem System installiert sind:

* **[.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0):** Das Software Development Kit zum Bauen und Ausführen der App.
* **[Visual Studio 2022](https://visualstudio.microsoft.com/de/vs/community/):** (Community Edition reicht aus) mit dem Workload **"ASP.NET und Webentwicklung"**.
* **Git:** Zum Klonen des Repositories.
* **[DB Browser for SQLite](https://sqlitebrowser.org/):** (Optional) Falls du direkt in die Datenbank-Datei schauen möchtest.

## 💻 Installation & Start (lokal)

1. Voraussetzungen prüfen:
```bash
dotnet --version
```

2. Projekt klonen:
```bash
git clone https://github.com/Dominik8891/FinanceTracker.git
cd FinanceTracker
```

3. Datenbank-Tools installieren:
```bash
dotnet tool install --global dotnet-ef
```

4. Datenbank erstellen:
```bash
dotnet ef database update
```

5. Anwendung starten:
```bash
dotnet watch run
```

Die App ist nun unter http://localhost:5000 oder https://localhost:5001 erreichbar.

## 🏠 Deployment auf Raspberry Pi

1. Build erstellen:
```bash
dotnet publish -c Release -r linux-arm64 --self-contained false -o ./publish
```

2. Dateien übertragen: 
Kopiere den Inhalt des publish-Ordners auf den Pi.

3. Ausführen auf dem Pi:
```bash
./FinanceTracker --urls "http://0.0.0.0:5000"
```

## 📝 Lizenz
Dieses Projekt steht unter der MIT-Lizenz.

---
*Entwickelt als Lernprojekt zur Vertiefung von C# und Web-Technologien.*