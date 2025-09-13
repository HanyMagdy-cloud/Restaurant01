# 🍽️ Restaurant MVC App

A simple ASP.NET Core MVC 9 project for a restaurant.\
It includes a menu, about page, reservation form, and a responsive
Bootstrap layout.

------------------------------------------------------------------------

## 🚀 Features

-   Home page with a full-screen hero section
-   About page with restaurant history and customer testimonials
-   Menu page with filterable categories (Pasta, Pizza, Burger, Fries)
-   Reservation system with table booking form
-   Responsive design using Bootstrap 5
-   SQL Server database integration with Entity Framework Core

------------------------------------------------------------------------

## 🛠️ Technologies Used

-   **.NET 9 (ASP.NET Core MVC)**
-   **Entity Framework Core 9** (Code First, SQL Server)
-   **Bootstrap 5** for styling and responsive layout
-   **Font Awesome 6** for social media icons
-   **SQL Server** for database

------------------------------------------------------------------------

## 📂 Project Structure

    Restaurant01/
    │── Controllers/
    │   ├── HomeController.cs
    │   ├── MenuController.cs
    │   └── ReservationsController.cs
    │
    │── Models/
    │   ├── MenuItem.cs
    │   └── Reservation.cs
    │
    │── Data/
    │   └── RestaurantDbContext.cs
    │
    │── Views/
    │   ├── Home/
    │   ├── Menu/
    │   ├── Reservations/
    │   └── Shared/ (_Layout.cshtml)
    │
    │── wwwroot/
    │   ├── css/
    │   ├── images/
    │   └── lib/

------------------------------------------------------------------------

## ⚙️ Setup Instructions

### 1. Clone the repository

``` bash
git clone https://github.com/your-username/restaurant-mvc.git
cd restaurant-mvc
```

### 2. Configure the database

Edit `appsettings.json` with your SQL Server connection string:

``` json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=RestaurantDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 3. Run migrations

Open **Package Manager Console** in Visual Studio:

``` powershell
Add-Migration InitialCreate
Update-Database
```

### 4. Run the project

``` powershell
dotnet run
```

Visit: <http://localhost:5000>

------------------------------------------------------------------------

## 📸 Screenshots (optional)

-   Home page hero
-   Menu page with filters
-   Reservation form
-   About page

------------------------------------------------------------------------

## 👨‍💻 Author

-   Your Name\
-   [LinkedIn](https://linkedin.com/) \| [GitHub](https://github.com/)
