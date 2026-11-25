# Calemon

A sharable calendar. Goal is to be easily self-hostable with a single `docker compose` file.

Still far from finished.

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
