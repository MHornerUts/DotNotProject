using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Xml.Linq;
using static WinFormGroupProject.Program;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Runtime.CompilerServices;
using MailKit.Search;

namespace WinFormGroupProject
{
    internal static class Program
    {
        static List<AreaManager> areaManagers = new List<AreaManager>();
        static List<Restaurant> restaurants = new List<Restaurant>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Setup();
            Initialise();
            ApplicationConfiguration.Initialize();
            Application.Run(new InitialForm(restaurants, areaManagers));
        }

        static void Setup()
        {
            Default newdefault = new Default();
            AreaManager areaManager = new AreaManager()
            {
                Name = "John AM",
                Password = "Password",
            };

            Manager newManager = new Manager()
            {
                Name = "John RM",
                Password = "Password",
            };

            Restaurant newRestaurant = new Restaurant()
            {
                name = "Successful test",
                manager = newManager,
                stockList = newdefault.stockList,
                stockUsage = newdefault.stockList,
                menu = newdefault.menu
            };

            SupplyManager newSupplyManager = new SupplyManager()
            {
                Name = "Dave", 
                Password = "Password"
            };

            Supplier newSupplier = new Supplier() {
                name = "test 1", 
                email = "themattenator@hotmail.com"
            };

            Order newOrder = new Order { 
                OrderID = 1, 
                OrderSupplier = newSupplier, 
                OrderDesc = "Should have taken teh money labasky", 
                OrderRestaurant = newRestaurant, 
                OrderStocks = new List<Stock>() { new Stock { name = "Side of yoke", price = 30.0f, amount = 100 }, } 
            };

            areaManager.supp.Add(newSupplier);
            areaManager.orders.Add(newOrder);

            newSupplyManager.restaurants = new List<Restaurant> { newRestaurant };
            areaManager.suppliers.Add(newSupplyManager);

            newRestaurant.manager.Restaurant = newRestaurant;
            areaManager.restaurants.Add(newRestaurant);

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("areamanager.txt", FileMode.Create))
            {
                formatter.Serialize(fileStream, areaManager);
            }

            using (FileStream fileStream = new FileStream("restaurants.txt", FileMode.Create))
            {
                formatter.Serialize(fileStream, newRestaurant);
            }
        }

        static void Initialise()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("areamanager.txt", FileMode.Open))
                if (fileStream.Length > 0)
                {
                    AreaManager areaManager;

                    // Use a try-catch block in case of any issues during deserialization
                    try
                    {
                        while (fileStream.Position < fileStream.Length)
                        {
                            areaManager = (AreaManager)formatter.Deserialize(fileStream);
                            areaManagers.Add(areaManager);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any deserialization issues
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

            using (FileStream fileStream = new FileStream("restaurants.txt", FileMode.Open))
                if (fileStream.Length > 0)
                {
                    Restaurant restaurant;

                    // Use a try-catch block in case of any issues during deserialization
                    try
                    {
                        while (fileStream.Position < fileStream.Length)
                        {
                            restaurant = (Restaurant)formatter.Deserialize(fileStream);
                            restaurants.Add(restaurant);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any deserialization issues
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
        }

        public static void Save(Restaurant restaurant)
        {
            Debug.WriteLine("Method activated");
            // Create a BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();

            // Create a temporary list to hold the updated restaurants
            List<Restaurant> tempRestaurants = new List<Restaurant>();

            using (FileStream fileStream = new FileStream("restaurants.txt", FileMode.Open, FileAccess.Read))
            {
                // Use a separate file stream to write the updated data to a temporary file
                using (FileStream tempFileStream = new FileStream("temp_restaurants.txt", FileMode.Create, FileAccess.Write))
                {
                    bool restaurantReplaced = false;

                    while (fileStream.Position < fileStream.Length)
                    {
                        Restaurant currentRestaurant = (Restaurant)formatter.Deserialize(fileStream);

                        if (currentRestaurant.name == restaurant.name)
                        {
                            // Replace the object with the new restaurant
                            formatter.Serialize(tempFileStream, restaurant);
                            restaurantReplaced = true;
                        }
                        else
                        {
                            // If it's not the restaurant to be replaced, add it to the list and write to the temporary file
                            tempRestaurants.Add(currentRestaurant);
                            formatter.Serialize(tempFileStream, currentRestaurant);
                        }
                    }

                    if (!restaurantReplaced)
                    {
                        // If the restaurant wasn't found in the file, add it to the list and write to the temporary file
                        tempRestaurants.Add(restaurant);
                        formatter.Serialize(tempFileStream, restaurant);
                    }
                }
            }

            // Replace the original file with the temporary file
            File.Delete("restaurants.txt");
            File.Move("temp_restaurants.txt", "restaurants.txt");

            Console.WriteLine("Restaurant saved successfully.");
        }

}

[Serializable]
    public abstract class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Restaurant Restaurant { get; set; }
    }

    [Serializable]
    public class AreaManager : User
    {
        public List<Restaurant> restaurants = new List<Restaurant>();
        public List<SupplyManager> suppliers = new List<SupplyManager>();
        public List<Order> orders = new List<Order>();
        public List<Supplier> supp = new List<Supplier>();

        public void CreateRestaurant(string name)
        {
          
            Default temp = new Default();
            //this.restaurants = new List<Restaurant>();
            Restaurant newRestaurant = new Restaurant();
            newRestaurant.name = name;
            newRestaurant.stockList = temp.stockList;
            newRestaurant.stockUsage = temp.stockList;
            newRestaurant.ResetUsage();
            newRestaurant.menu = temp.menu;
            newRestaurant.manager = CreateManager(newRestaurant);
            this.restaurants.Add(newRestaurant);
        }

        private Manager CreateManager(Restaurant restaurant)
        {
            Manager newManager = new Manager();
            newManager.Restaurant = restaurant;

            return newManager;
        }

        public SupplyManager CreateSupplier(Restaurant restaurant, String supplierName, String supplierPassword) 
        { 
            SupplyManager newSupplyManager = new SupplyManager() {Name = supplierName, Password = supplierPassword };
            newSupplyManager.restaurants = new List<Restaurant> {restaurant};
            suppliers.Add(newSupplyManager);
            return newSupplyManager;
        }

        public List<Restaurant>? GetRestaurants() { 
            return restaurants;
        }

        public SupplyManager SupplyManagerLogin(String name, String password) {
            foreach (SupplyManager sm in suppliers) {
                if (sm.Name == name && sm.Password == password) { 
                    return sm;
                }
            }
            return null;
        }

        //This is how I save things
        public void Save()
        {
            AreaManager areaManager = this;

            List<AreaManager> tempAreaManager = new List<AreaManager>();

            // Create a BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();

            // Check if the file exists, and if not, create it
            if (!File.Exists("areamanager.txt"))
            {
                File.Create("areamanager.txt").Close();
            }

            using (FileStream fileStream = new FileStream("areamanager.txt", FileMode.Open, FileAccess.ReadWrite))
            {
                // Use a try-catch block in case of any issues during deserialization
                try
                {
                    while (fileStream.Position < fileStream.Length)
                    {
                        AreaManager currentAreaManager = (AreaManager)formatter.Deserialize(fileStream);

                        // Check if the current areamanager matches the one we want to replace
                        if (currentAreaManager.Name == areaManager.Name)
                        {
                            // Replace the object with the new areamanager 
                            tempAreaManager.Add(areaManager);
                        }
                        else
                        {
                            // If it's not the areamanager to be replaced, add it to the list
                            tempAreaManager.Add(currentAreaManager);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any deserialization issues
                    Console.WriteLine("Error: " + ex.Message);
                }

                // Serialize the updated list back to the file
                tempAreaManager.Add(areaManager);

                // Clear the file before writing the updated data
                fileStream.SetLength(0);

                foreach (AreaManager updatedAreaManager in tempAreaManager)
                {
                    formatter.Serialize(fileStream, updatedAreaManager);
                }
            }

            Console.WriteLine("Areamanager saved successfully.");
        }
    }

    [Serializable]
    public class SupplyManager : User
    {
        public List<Restaurant>? restaurants;

    }
    [Serializable]
    public class Manager : User
    {
        
    }
    [Serializable]
    public class Attendant : User
    {

    }

    [Serializable]
    public class Restaurant
    {
        public string name { get; set; }
        public Manager manager { get; set; }
        public List<Attendant> Attendants = new List<Attendant>();
        public List<Stock> stockList { get; set; }
        public List<Stock> stockUsage { get; set; }
        public List<MenuItem> menu { get; set; }
        public List<MenuItem> sale = new List<MenuItem>();
        public List<List<MenuItem>> saleList = new List<List<MenuItem>>();
        public Order currentOrder;
        public List<MenuItem> GetMenu()
        {
            return menu;
        }

        public User Login(string name, string password)
        {
            if (name == manager.Name && password == manager.Password)
            {
                return manager;
            }

            else if (Attendants != null)
            {
                foreach (Attendant attendant in Attendants)
                {
                    if (name == attendant.Name && password == attendant.Password)
                    {
                        return attendant;
                    }
                }
            }
            
            // If no matching user is found, return null or handle as needed
            return null;
        }

        public void CreateAttendant(string name, string password)
        {
            Attendant attendent = new Attendant()
            {
                Name = name,
                Password = password,
                Restaurant = this
            };

            Attendants.Add(attendent);
            Program.Save(this);
            Debug.Write("Hello");
        }

        public void ResetUsage()
        {
            foreach (Stock stock in stockUsage)
            {
                stock.amount = 0;
            }
        }

        public void AdjustProjection()
        {
            for (int i = 0; i < stockList.Count; i++)
            {
                stockList[i].recommendedOrderAmount = stockUsage[i].amount - stockList[i].amount;
                Debug.WriteLine(stockList[i].amount);
            }
        }
    }
    [Serializable]
    public class MenuItem
    {
        public string name;
        public float price;
        public float quantity;
        public List<Ingredient> ingredientList = new List<Ingredient>();
        public MenuItem(string name, float price, List<Ingredient> ingredientList)
        {
            this.name = name;
            this.price = price;
            this.ingredientList = ingredientList;
        }
        public string GetName() {
            return name;
        }

        public float GetPrice() { 
            return price;
        }

        public List<Ingredient> GetList() { 
            return ingredientList;
        }
    }
    [Serializable]
    public class Ingredient
    {
        public string name;
        public int quantity;

        public Ingredient(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
        public string GetName() {
            return name;
        }

        public int GetQuantity() { 
            return quantity;
        }
    }
    [Serializable]
    public class Stock
    {
        public string name { get; set; }
        public float price { get; set; }
        public float amount { get; set; }
        public float recommendedOrderAmount { get; set; }
        public float orderQuantity = 1;
    }


    public class Default
    {
        public List<Stock> stockList;
        public List<MenuItem> menu;

        public Default()
        {
            stockList = CreateStocklist();
            menu = CreateMenu();
        }

        public List<Stock> CreateStocklist()
        {
            return new List<Stock>
        {
        new Stock { name = "Bun", price = 2.0f, amount = 100 },
        new Stock { name = "Beef", price = 3.0f, amount = 200 },
        new Stock { name = "Chicken", price = 3.0f, amount = 150 },
        new Stock { name = "Lettuce", price = .5f, amount = 150 },
        new Stock { name = "Tomato", price = .5f, amount = 150 },
        new Stock { name = "Onion", price = .5f, amount = 150 },
        new Stock { name = "Cheese", price = 1.0f, amount = 150 }
        };
        }

        public List<MenuItem> CreateMenu()
        {
            return new List<MenuItem>
          {
        new MenuItem("Beef Burger", 10.0f, new List<Ingredient>
        {
            new Ingredient("Bun", 1),
            new Ingredient("Beef", 1), // Create a new Ingredient
            new Ingredient("Lettuce", 1),
            new Ingredient("Tomato", 1),
            new Ingredient("Onion", 1)
        }),
        new MenuItem("Chicken Burger", 15.0f, new List<Ingredient>
        {
            new Ingredient("Bun", 1),
            new Ingredient("Chicken", 1), // Create a new Ingredient
            new Ingredient("Lettuce", 1),
            new Ingredient("Tomato", 1),
            new Ingredient("Onion", 1)
        }),
        new MenuItem("Cheeseburger", 15.0f, new List<Ingredient>
        {
            new Ingredient("Bun", 1),
            new Ingredient("Cheese", 1), // Create a new Ingredient
            new Ingredient("Beef", 1)
        })
        };

            }
        }

        public class TEST
    {
        public void test()
        {
            Debug.WriteLine("Worked");
        }
    }

    // A class for suppliers
    [Serializable]
    public class Supplier { 
        public string name { get; set;}
        public string email { get; set; }

    }

    // A class for orders
    [Serializable]
    public class Order {
        public int OrderID { get; set; }
        public Supplier OrderSupplier { get; set; }
        public string OrderDesc { get; set; }
        public List<Stock> OrderStocks = new List<Stock>();
        public Restaurant OrderRestaurant { get; set; }

        public void ConfirmOrder()
        {
            foreach (Stock stock in OrderStocks) {
                if (OrderRestaurant.stockList.Find(Stock => Stock.name == stock.name) is null)
                {
                    OrderRestaurant.stockList.Add(stock);
                }
                else {
                    OrderRestaurant.stockList.Find(Stock => Stock.name == stock.name).amount = OrderRestaurant.stockList.Find(Stock => Stock.name == stock.name).amount + stock.amount;
                }
            }
        }

        
    }

    //A class that sends mail
    public class MailSender 
    {
        private string email;
        private string password;

        public MailSender() {
            email = "posutsproject@gmail.com";
            password = "xjke bvke oqyl kljk";
        }

        //Sends a message to a given address
        public void send(string msg, string subject, string emailThis, MsgLoadingForm form) {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("POS", email));
                message.To.Add(new MailboxAddress("Suppler", emailThis));
                message.Subject = subject;
                //Makes the text in the text box
                message.Body = new TextPart("plain")
                {
                    Text = @msg
                };

                using (var client = new SmtpClient())
                {
                    //Sets the stuff needed to use outlook as a mail server
                    client.Connect("smtp.gmail.com", 587, false);
                    //Console.WriteLine("Authenticating");
                    client.Authenticate(email, password);
                    //Console.WriteLine("Authenticated");
                    client.Send(message);
                    //Console.WriteLine("Sent");
                    client.Disconnect(true);
                }
            } catch (MailKit.Security.AuthenticationException ex) {
                form.failed();
            }
        }
    }

}
