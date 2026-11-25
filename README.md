# Calemon

A sharable calendar. Goal is to be easily self-hostable with a single `docker compose` file.

| Part     | Tech                        | Folder      |
| -------- | --------------------------- | ----------- |
| Frontend | Nuxt 4 / TypeScript         | `frontend/` |
| Backend  | ASP.NET Core (.NET 10) / C# | `api/`      |
| Database | PostgreSQL 18 (EF Core)     | Docker      |

## Development setup

Requires Docker, .NET 10 SDK and Node.js. Run the API and frontend in separate terminals from the project root.

```bash
echo "POSTGRES_PASSWORD=choose-a-password" > .env
docker compose up -d                        # database
dotnet watch --project api                  # API
cd frontend && npm install && npm run dev   # frontend
```

## API

Dates are ISO 8601 in UTC, e.g. `2026-12-01T09:00:00Z`.

### Events

| Method   | Route                        | Description                  | Success |
| -------- | ---------------------------- | ---------------------------- | ------- |
| `GET`    | `/api/calendar/events/year`  | Events in the selected year  | `200`   |
| `GET`    | `/api/calendar/events/month` | Events in the selected month | `200`   |
| `GET`    | `/api/calendar/events/week`  | Events in the selected week  | `200`   |
| `GET`    | `/api/calendar/events/day`   | Events on the selected day   | `200`   |
| `POST`   | `/api/calendar/events`       | Create an event              | `201`   |
| `PUT`    | `/api/calendar/events/{id}`  | Update an event              | `200`   |
| `DELETE` | `/api/calendar/events/{id}`  | Delete an event              | `204`   |

`GET` query parameters:

| Parameter     | Example                       | Description                                  |
| ------------- | ----------------------------- | -------------------------------------------- |
| `date`        | `date=2026-12-01`             | Any date in the selected year/month/week/day |
| `calendarIds` | `calendarIds=1&calendarIds=2` | One or more active calendars                 |

`POST` / `PUT` body:

```json
{
  "calendarId": 1,
  "title": "Dentist",
  "description": "Bring my teeth",
  "start": "2026-12-01T09:00:00Z",
  "end": "2026-12-01T10:00:00Z",
  "allDay": false
}
```

### Errors

| Status | When                                    |
| ------ | --------------------------------------- |
| `400`  | Invalid body, e.g. `end` before `start` |
| `404`  | Event not found                         |
