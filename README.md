# Avancerad.Net Labb3 API

Ett REST API byggt med ASP.NET Core som hanterar användare, intressen och länkar. Datan sparas via Entity Framework Core.

Returnerar en lista med alla användare (id + namn).

**Exempelsvar:**
```json
[
  { "id": 1, "name": "Anna Andersson" },
  { "id": 2, "name": "Björn Borg" }
]
```

---

#### Hämta en användares intressen

```
GET /api/user/{userId}/interests
```

Returnerar alla intressen kopplade till en specifik användare.

**Exempel:**
```
GET /api/user/1/interests
```

**Exempelsvar:**
```json
[
  {
    "title": "Programmering",
    "description": "Koda och bygga system""
  },
  {
    "title": "Fotografi",
    "description": "Att fånga ögonblick med systemkamera eller mobil"
  }
]
```

---

#### Hämta en användares länkar

```
GET /api/user/{userId}/links
```

Returnerar alla sparade länkar för en användare, grupperade per intresse.

**Exempel:**
```
GET /api/user/1/links
```

**Exempelsvar:**
```json
[
  {
    "interestTitle": "Programmering",
    "url": "https://docs.microsoft.com/dotnet"
  },
  {
    "interestTitle": "Programmering",
    "url": "https://github.com"
  }
]
```
---

### Koppla intresse till användare

```
POST /api/user/add-interest
```
Lägger till ett befintligt intresse till en användare. Om användaren redan har intresset returneras ett felmeddelande.

**Request body:**
```json
{
  "userId": 1,
  "interestId": 3
}
```

**Lyckat svar:** `200 OK`
```
"Intresset har lagts till"
```
**Misslyckat svar (dublett):** `400 Bad Request`
```
"Denna användare har redan detta intresse."
```

---
### Lägga till en länk

```
POST /api/user/add-link
```

Sparar en URL och kopplar den till en användare och ett intresse. Användaren måste redan ha det aktuella intresset, annars returneras ett fel.

**Request body:**
```json
{
  "userId": 1,
  "interestId": 3,
  "url": "https://www.example.com"
}
```

**Lyckat svar:** `200 OK`
```
"Länken har sparats och kopplats till användarens intresse."
```
**Misslyckat svar:** `400 Bad Request`
```
"Användaren måste ha intresset för att lägga till en länk."
```

---

## Flöde – så här är det tänkt att användas

1. Hämta användare via `GET /api/user` för att se vilka id:n som finns.
2. Hämta en användares intressen med `GET /api/user/{userId}/interests`.
3. Koppla ett nytt intresse till en användare via `POST /api/user/add-interest`.
4. Lägg sedan till en länk kopplad till det intresset via `POST /api/user/add-link`.
5. Verifiera länkarna med `GET /api/user/{userId}/links`.
