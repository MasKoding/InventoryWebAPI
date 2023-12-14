# Install Package
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Npgsql.EntityFrameworkCore.PostgreSQL
Microsoft.IdentityModel.Tokens
Microsoft.AspNetCore.Authentication.JwtBearer
```

# Configuration JWT in Swagger .NET CORE 7
```c#
    builder.Services.AddAuthentication(optiones =>
            {
                optiones.DefaultAuthenticateScheme = 
                         JwtBearerDefaults.AuthenticationScheme;
                optiones.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                optiones.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidAudience = builder.Configuration["JwtSecurityToken:Audience"],
                    ValidIssuer = builder.Configuration["JwtSecurityToken:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey
                    (Encoding.UTF8.GetBytes(builder.Configuration["JwtSecurityToken:Key"])),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                };
            });
```

## Implementasi Testing API SWAGGER
<img src="contoh1.png">

## Implementasi Login Untuk Mendapatkan Token
<img src="contoh2.png">

## Implementasi Token Yang Berhasil Di Generate
<img src="contoh3.png">


## Implementasi Hit Endpoint Lain dengan menggunakan token sebagai HTTP Header
<img src="contoh4.png">

## Jika Token Valid & Response Success
<img src="contoh5.png">

## Jika Token Tidak Valid & Response Unauthorized
<img src="contoh6.png">
