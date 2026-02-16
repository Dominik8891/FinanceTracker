# FinanceTracker 💰

Ein smarter, lokaler Finanzmanager für den Raspberry Pi. Entwickelt mit **C#**, **ASP.NET Core Blazor** und **Entity Framework Core**.

Diese Anwendung hilft dabei, Einnahmen und Ausgaben im Blick zu behalten und komplexe Schuldenverhältnisse zwischen Nutzern transparent zu verwalten.

## 🚀 Vision & Features

## 🚀 Features

### ✅ Bereits implementiert
- **Admin-basiertes Passwort-Reset:** Lokale Sicherheitslogik ohne externe SMTP-Abhängigkeit (ideal für Edge-Computing/Intranet).
- **Multi-User System:** Vollständiges Login- & Registrierungssystem (ASP.NET Identity).
- **Social Debt Tracking:** Forderungen und Schulden zwischen Nutzern verknüpfen.
- **Bestätigungsworkflow:** Schutz vor einseitigen Einträgen durch Akzeptieren/Ablehnen.
- **Detaillierter Zahlungsverlauf:** Teilzahlungen mit Historie pro Forderung.
- **Persönliches Dashboard:** Finanzielle Übersicht (Netto-Saldo) sofort nach Login.

### 🛠 In Arbeit / Roadmap
- [ ] **Daueraufträge & Fixkosten:** Automatische monatliche Buchung von Einnahmen/Ausgaben (z.B. Miete, Gehalt).
- [ ] **Integriertes Payment:** Schulden direkt aus dem eigenen Budget-Modul begleichen (Verknüpfung von Schulden und Transaktionen).
- [ ] **Automatisierte Tilgungspläne:** Monatliche Ratenzahlungen für Schulden festlegen.
- [ ] **KI-Prognose:** Automatische Berechnung des "Enddatums" einer Schuld basierend auf dem aktuellen Tilgungsverhalten.
- [ ] **Grafische Auswertungen:** Tortendiagramme für Ausgabenkategorien.

## 🛠 Tech Stack

- **Framework:** .NET 8.0 (Blazor Server)
- **Sprache:** C# (C-Sharp)
- **Datenbank:** SQLite
- **ORM:** Entity Framework Core (EF Core)
- **Styling:** Bootstrap 5

## 🔒 Sicherheits- & Architekturkonzept

Da dieses Projekt speziell für den **lokalen Betrieb (Self-Hosted/Pi)** optimiert ist, wurden bewusste Architekturentscheidungen getroffen:

* **Offline-First:** Das System benötigt keine aktive Internetverbindung. 
* **Hybrides Password-Recovery:** Statt unsicherer E-Mail-Konfigurationen in privaten Netzwerken nutzt die App ein Admin-Verifizierungssystem. Nutzer beantragen einen Reset, der Administrator generiert im geschützten Dashboard einen Einmal-Token.
* **Role-Based Access Control (RBAC):** Strikte Trennung zwischen Admin-Funktionen (User-Management, Reset-Freigaben) und Nutzer-Funktionen (Finanzdaten).

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