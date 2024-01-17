
using System.ComponentModel.Design;

string greeting = @"Welcome to Brass & Poem! We sell a unique selection of poetry and brass musical instruments.";

List<Product> product = new()
{
    new Product()
    {
        Name = "French Horn",
        Price = 4200.00M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Milk & Honey",
        Price = 30.00M,
        ProductTypeId =2
    },
    new Product()
    {
        Name = "Tuba",
        Price = 1500.00M,
        ProductTypeId =1
    },
    new Product()
    {
        Name = "Shakespeare's Sonnets",
        Price = 30.00M,
        ProductTypeId =2
    },
    new Product()
    {
        Name = "Trumpet",
        Price = 800.00M,
        ProductTypeId = 1
    }
};

List<ProductType> productTypes = new()
{
    new ProductType()
    {
        Title = "Brass Instrument",
        Id = 1,

    },
    new ProductType()
    {
        Title = "Poetry",
        Id = 2

    },
};

Console.WriteLine(greeting);

string choice = null;
while (choice !="5")
{
    DisplayMenu();
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("\n A list of all of our products:");
            DisplayAllProducts(product, productTypes );
            break;
        case "2":
            Console.WriteLine("\nEnter the number of the product you wish to delete:");
            DeleteProduct(product, productTypes);
            break;
        case "3":
            Console.WriteLine("\nAdd a product:");
            AddProduct(product, productTypes);
            break;
        case "4":
            Console.WriteLine("\nUpdate a product:");
            UpdateProduct(product, productTypes);
            break;
        case "5":
            Console.WriteLine("\nThank you, Goodbye!");
            break;
        default:
            Console.WriteLine("\nInvalid selection. Please enter a number between 1-5.");
            break;
    }
}

void DisplayMenu()
{
    Console.WriteLine("\n");
    Console.WriteLine(@"Choose from the main menu:
1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit");
}

//display all products
void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("\n");
    if (products.Count == 0)
    {
        Console.WriteLine("Sorry, There are no products at this time.");
    }
    //loop through each product in the list
    for (int i = 0; i < products.Count; i++)
    {
        //FirstOrDefault is the Linq method used to find the first or default (product type)
        Product product = products[i];
        ProductType productType = productTypes.FirstOrDefault(prodType => prodType.Id == product.ProductTypeId);
        Console.WriteLine($"{i + 1}. {product.Name}, {productType.Title}\n{product.Price}\n");
    }
}

//delete a product
void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    while (true)
    {
        DisplayAllProducts(products, productTypes);

        if (int.TryParse(Console.ReadLine(), out int choiceIndex))
        {
            if (choiceIndex == 0)
            {
                break;
            }
            else if (choiceIndex >= 1 && choiceIndex <= products.Count)
            {
                products.RemoveAt(choiceIndex - 1);
                Console.WriteLine("\nYou have successfully deleted this product.");
                break;
            }
            else
            {
                Console.WriteLine("\nError: Invalid Selection. Please enter a valid number (1-5) or 0 to see the main menu.");
            }
        }
    }
}

    void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }