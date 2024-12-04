# Simple chat application using ASP.NET MVC & .NET 9

# Features
```
Audio Calls ❌
Video Calls ❌
End-to-End Encryption ❌
Two-Factor Authentication (2FA) ❌
Message Saving (Optional) ❌
```

# Install node modules
```
1. npm install
```

# Compile js & css
```
1. npx tailwindcss -i ./wwwroot/app.css -o ./wwwroot/app.min.css --watch
2. npm run watch
```

# Migrations
```
1. dotnet ef migrations add Initial
2. dotnet ef database update
```

# App settings
```
Provide the following values into appsettings.json

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=./MyDatabase.db"
  }
}
```

# Production mode
```
1. npm run build
2. build the project in release mode
```