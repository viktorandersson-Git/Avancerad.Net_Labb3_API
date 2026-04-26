Labb3 API

Hämta alla användare
GET /api/user
Hämta alla intressen för en användare

GET /api/user/{userId}/interests
Hämta alla länkar för en användare

GET /api/user/{userId}/links

Koppla ett intresse till en användare
POST /api/user/add-interest
Body: { "userId": 1, "interestId": 3 }

Lägga till en länk för en användare och ett intresse
POST /api/user/add-link
Body: { "userId": 1, "interestId": 3, "url": "https://example.com" }
