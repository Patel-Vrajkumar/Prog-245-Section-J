using Microsoft.AspNetCore.Identity;
using ShopApp.Models;

namespace ShopApp.Data;

public static class DbInitializer
{
    public const string AdminRole    = "Admin";
    public const string CustomerRole = "Customer";

    public static void SeedProducts(ApplicationDbContext context)
    {
        if (context.Products.Any())
            return;

        var now = DateTime.UtcNow;

        var products = new List<Product>
        {
            // Electronics
            new()
            {
                Name = "Wireless Noise-Cancelling Headphones",
                Description = "Over-ear Bluetooth headphones with 30-hour battery life and active noise cancellation.",
                Price = 149.99m,
                Category = "Electronics",
                StockQuantity = 42,
                ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Mechanical Keyboard",
                Description = "Compact TKL mechanical keyboard with Cherry MX Blue switches and RGB backlighting.",
                Price = 89.95m,
                Category = "Electronics",
                StockQuantity = 28,
                ImageUrl = "https://images.unsplash.com/photo-1587829741301-dc798b83add3?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "USB-C Hub 7-in-1",
                Description = "Multiport adapter with HDMI 4K, 3× USB-A, SD card reader, and 100W power delivery.",
                Price = 39.99m,
                Category = "Electronics",
                StockQuantity = 75,
                ImageUrl = "https://images.unsplash.com/photo-1625895197185-efcec01cffe0?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "27-Inch 4K Monitor",
                Description = "IPS panel with 144 Hz refresh rate, HDR400, and USB-C connectivity.",
                Price = 499.00m,
                Category = "Electronics",
                StockQuantity = 15,
                ImageUrl = "https://images.unsplash.com/photo-1527443224154-c4a573d5e836?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Portable Bluetooth Speaker",
                Description = "Waterproof IPX7 speaker with 360° sound and 20-hour playtime.",
                Price = 59.99m,
                Category = "Electronics",
                StockQuantity = 60,
                ImageUrl = "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1?w=600",
                CreatedAt = now, UpdatedAt = now
            },

            // Clothing
            new()
            {
                Name = "Classic Fit Cotton T-Shirt",
                Description = "100% organic cotton crew-neck tee available in 12 colours.",
                Price = 19.99m,
                Category = "Clothing",
                StockQuantity = 200,
                ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Slim-Fit Chino Pants",
                Description = "Stretch-cotton chinos with a modern slim fit. Machine washable.",
                Price = 49.95m,
                Category = "Clothing",
                StockQuantity = 85,
                ImageUrl = "https://images.unsplash.com/photo-1624378439575-d8705ad7ae80?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Waterproof Rain Jacket",
                Description = "Lightweight packable jacket with sealed seams and adjustable hood.",
                Price = 89.00m,
                Category = "Clothing",
                StockQuantity = 40,
                ImageUrl = "https://images.unsplash.com/photo-1591047139829-d91aecb6caea?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Running Sneakers",
                Description = "Breathable mesh upper with responsive foam midsole for all-day comfort.",
                Price = 74.99m,
                Category = "Clothing",
                StockQuantity = 55,
                ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600",
                CreatedAt = now, UpdatedAt = now
            },

            // Home & Kitchen
            new()
            {
                Name = "Stainless Steel Insulated Tumbler",
                Description = "20 oz double-wall vacuum tumbler keeps drinks cold 24 h or hot 12 h.",
                Price = 29.99m,
                Category = "Home & Kitchen",
                StockQuantity = 120,
                ImageUrl = "https://images.unsplash.com/photo-1514228742587-6b1558fcca3d?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Air Fryer 5.8 Qt",
                Description = "Digital air fryer with 8 preset cooking functions and dishwasher-safe basket.",
                Price = 79.95m,
                Category = "Home & Kitchen",
                StockQuantity = 33,
                ImageUrl = "https://images.unsplash.com/photo-1626257395-233c3e1afeb0?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Bamboo Cutting Board Set",
                Description = "Set of 3 eco-friendly bamboo cutting boards with juice grooves.",
                Price = 34.99m,
                Category = "Home & Kitchen",
                StockQuantity = 90,
                ImageUrl = "https://images.unsplash.com/photo-1584622650111-993a426fbf0a?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Pour-Over Coffee Maker",
                Description = "Borosilicate glass dripper with a reusable stainless steel filter.",
                Price = 24.99m,
                Category = "Home & Kitchen",
                StockQuantity = 68,
                ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?w=600",
                CreatedAt = now, UpdatedAt = now
            },

            // Books
            new()
            {
                Name = "Clean Code",
                Description = "A handbook of agile software craftsmanship by Robert C. Martin.",
                Price = 34.99m,
                Category = "Books",
                StockQuantity = 50,
                ImageUrl = "https://images.unsplash.com/photo-1532012197267-da84d127e765?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "The Pragmatic Programmer",
                Description = "20th Anniversary Edition — your journey to mastery by Hunt & Thomas.",
                Price = 39.95m,
                Category = "Books",
                StockQuantity = 45,
                ImageUrl = "https://images.unsplash.com/photo-1544716278-ca5e3f4abd8c?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Designing Data-Intensive Applications",
                Description = "The big ideas behind reliable, scalable, and maintainable systems by Martin Kleppmann.",
                Price = 49.99m,
                Category = "Books",
                StockQuantity = 30,
                ImageUrl = "https://images.unsplash.com/photo-1589998059171-988d887df646?w=600",
                CreatedAt = now, UpdatedAt = now
            },

            // Sports & Outdoors
            new()
            {
                Name = "Adjustable Dumbbell Set",
                Description = "Pair of 5–52.5 lb adjustable dumbbells with quick-select dial.",
                Price = 299.00m,
                Category = "Sports & Outdoors",
                StockQuantity = 18,
                ImageUrl = "https://images.unsplash.com/photo-1534438327276-14e5300c3a48?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Yoga Mat Non-Slip",
                Description = "6mm thick eco-friendly TPE mat with alignment lines and carry strap.",
                Price = 29.99m,
                Category = "Sports & Outdoors",
                StockQuantity = 100,
                ImageUrl = "https://images.unsplash.com/photo-1599058917212-d750089bc07e?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Hiking Backpack 40L",
                Description = "Lightweight 40-litre pack with internal frame, hip belt, and rain cover.",
                Price = 119.99m,
                Category = "Sports & Outdoors",
                StockQuantity = 25,
                ImageUrl = "https://images.unsplash.com/photo-1622260614153-03223fb72052?w=600",
                CreatedAt = now, UpdatedAt = now
            },
            new()
            {
                Name = "Foam Roller",
                Description = "High-density EVA foam roller for muscle recovery and deep-tissue massage.",
                Price = 19.99m,
                Category = "Sports & Outdoors",
                StockQuantity = 150,
                ImageUrl = "https://images.unsplash.com/photo-1571019614242-c5c5dee9f50b?w=600",
                CreatedAt = now, UpdatedAt = now
            },
        };

        context.Products.AddRange(products);
        context.SaveChanges();
    }

    public static async Task SeedUsersAsync(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        // Ensure roles exist
        foreach (var role in new[] { AdminRole, CustomerRole })
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }

        // (email, password, firstName, lastName, role)
        var seedUsers = new[]
        {
            new { Email = "admin@shopapp.com", Password = "Admin123!",  FirstName = "Admin", LastName = "User",  Role = AdminRole    },
            new { Email = "jane@shopapp.com",  Password = "Password1!", FirstName = "Jane",  LastName = "Smith", Role = CustomerRole },
            new { Email = "john@shopapp.com",  Password = "Password1!", FirstName = "John",  LastName = "Doe",   Role = CustomerRole },
        };

        foreach (var seed in seedUsers)
        {
            var existing = await userManager.FindByEmailAsync(seed.Email);
            if (existing is not null)
            {
                // Make sure the role assignment is still correct even if user already existed
                if (!await userManager.IsInRoleAsync(existing, seed.Role))
                    await userManager.AddToRoleAsync(existing, seed.Role);
                continue;
            }

            var user = new ApplicationUser
            {
                UserName       = seed.Email,
                Email          = seed.Email,
                FirstName      = seed.FirstName,
                LastName       = seed.LastName,
                EmailConfirmed = true,
            };

            var result = await userManager.CreateAsync(user, seed.Password);
            if (result.Succeeded)
                await userManager.AddToRoleAsync(user, seed.Role);
        }
    }
}
