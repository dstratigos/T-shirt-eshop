using Dimitrios_Stratigos_Assignment4.Models;
using Dimitrios_Stratigos_Assignment4.SortingMethods;
using Dimitrios_Stratigos_Assignment4.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dimitrios_Stratigos_Assignment4.ExtensionMethods;

namespace Dimitrios_Stratigos_Assignment4.Services
{
    public class UserInterface
    {
        public static TShirt tshirt = new TShirt();
        public static List<TShirt> tshirts = MockTshirtGenerator.GenerateTShirts(49);
        public static List<TShirt> tshirtsSorted = new List<TShirt>();
        public static Basket basket = new Basket();

        public static void MainMenu()
        {
            int userChoice = 0;


            while (userChoice != 5)
            {
                var sb = new StringBuilder();

                sb
                   .AppendLine("Main Menu")
                   .AppendLine("1. Browse TShirts")
                   .AppendLine("2. Create my own TShirt")
                   .AppendLine("3. My basket")
                   .AppendLine("4. Fast Checkout")
                   .AppendLine("5. Exit");

                Console.WriteLine(sb.ToString());

                Console.Write("Make a choice: ");
                try
                {
                    userChoice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    userChoice = 0;
                }

                switch (userChoice)
                {
                    case 1:
                        BrowseMenu();
                        break;
                    case 2:
                        CreateMenu();
                        break;
                    case 3:
                        BasketMenu();
                        break;
                    case 4:
                        if (basket.TotalPayable() > 0)
                        {
                            var total = basket.TotalPayable();
                            Console.WriteLine($"\nTotal amount payable: {total}");
                            CheckOut();
                        }
                        else
                            BasketMenu();
                        break;
                    case 5:
                        Console.Write("\nThank you!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("\nNon valid choice! Try again...\n");
                        break;
                }

                if (userChoice == 5)
                    break;
            }
        }


        private static void BrowseMenu()
        {
            var userChoice = 0;
            var browser = new Browser() { TShirts = tshirts};
            var sb = new StringBuilder();

            sb
                .AppendLine()
                .AppendLine("Browse TShirts")
                .AppendLine("1. By Price Ascending")
                .AppendLine("2. By Price Descending")
                .AppendLine("3. By Color Ascending")
                .AppendLine("4. By Color Descending")
                .AppendLine("5. By Size Ascending")
                .AppendLine("6. By Size Descending")
                .AppendLine("7. By Fabric Ascending")
                .AppendLine("8. By Fabric Descending")
                .AppendLine("9. By Color/Size/Fabric Ascending")
                .AppendLine("10. By Color/Size/Fabric Descending")
                .AppendLine("11. Return to Main Menu");

            Console.WriteLine(sb.ToString());
            Console.Write("Make a choice: ");

            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNon valid choice! Try again...\n");
                return;
            }

            switch (userChoice)
            {
                case 1:
                    browser.SortingMethod = SortingEnum.QuickPriceAsc;
                    browser.SetSortingStrategy(new Sorter());                    
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 2:
                    browser.SortingMethod = SortingEnum.QuickPriceDesc;
                    browser.SetSortingStrategy(new Sorter());
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 3:
                    browser.SortingMethod = SortingEnum.BubbleColorAsc;
                    browser.SetSortingStrategy(new Sorter());
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 4:
                    browser.SortingMethod = SortingEnum.BubbleColorDesc;
                    browser.SetSortingStrategy(new Sorter());
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 5:
                    browser.SortingMethod = SortingEnum.QuickSizeAsc;
                    browser.SetSortingStrategy(new Sorter());
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 6:
                    browser.SortingMethod = SortingEnum.QuickSizeDesc;
                    browser.SetSortingStrategy(new Sorter());
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 7:
                    browser.SortingMethod = SortingEnum.BucketFabricAsc;
                    browser.SetSortingStrategy(new Sorter());
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 8:
                    browser.SortingMethod = SortingEnum.BucketFabricDesc;
                    browser.SetSortingStrategy(new Sorter());
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 9:
                    browser.SortingMethod = SortingEnum.BubbleAllAsc;
                    browser.SetSortingStrategy(new Sorter());
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 10:
                    browser.SortingMethod = SortingEnum.BubbleAllDesc;
                    browser.SetSortingStrategy(new Sorter());
                    tshirtsSorted = browser.Sort();
                    PrintOut.PrintOutList(tshirtsSorted);
                    break;
                case 11:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("\nNon valid choice! Try again...\n");
                    BrowseMenu();
                    break;
            }

            if (userChoice > 0 && userChoice < 11)
                ChooseMenu();
        }

        private static void ChooseMenu()
        {
            var userChoice = 0;

            Console.Write("Choose a TShirt or [0] to return to Main Menu: ");

            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNon valid choice! Try again...\n");
                return;
            }

            if (userChoice == 0)
            {
                Console.WriteLine();
                return;
            }
            else if (userChoice < 0 || userChoice > tshirts.Count)
            {
                Console.WriteLine("\nNon valid choice! Try again...\n");
                return;
            }
            else
            {
                tshirt = tshirtsSorted[userChoice - 1];
                Console.WriteLine("\nYour Choice:");
            }

            PrintOut.PrintOutSingle(tshirt);

            AddToBasket(userChoice);


        }

        private static void CreateMenu()
        {
            var userChoice = 0;
            var colors = Enum.GetNames(typeof(ColorEnum)).ToList();
            var sizes = Enum.GetNames(typeof(SizeEnum)).ToList();
            var fabrics = Enum.GetNames(typeof(FabricEnum)).ToList();

            var newTshirt = new TShirt();

            Console.WriteLine("\nColors");

            for (int i = 0; i < colors.Count; i++)
            {
                //Console.Write($"{(int)(ColorEnum)i + 1}. ");
                Console.Write($"{i + 1}. ");
                Console.WriteLine(colors[i]);
            }

            Console.Write("Choose color: ");

            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNon valid choice! Try again...\n");
                return;
            }

            if (userChoice <= 0 || userChoice > colors.Count)
            {
                Console.WriteLine("\nNo such choice! Try again...\n");
                return;
            }

            newTshirt.Color = (ColorEnum)(userChoice - 1);

            Console.WriteLine("\nSizes");

            for (int i = 0; i < sizes.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(sizes[i]);
            }

            Console.Write("Choose Size: ");

            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNon valid choice! Try again...\n");
                return;
            }

            if (userChoice <= 0 || userChoice > sizes.Count)
            {
                Console.WriteLine("\nNo such choice! Try again...\n");
                return;
            }

            newTshirt.Size = (SizeEnum)(userChoice - 1);

            Console.WriteLine("\nFabrics");

            for (int i = 0; i < sizes.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(fabrics[i]);
            }

            Console.Write("Choose Fabric: ");

            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNon valid choice! Try again...\n");
                return;
            }

            if (userChoice <= 0 || userChoice > fabrics.Count)
            {
                Console.WriteLine("\nNo such choice! Try again...\n");
                return;
            }

            newTshirt.Fabric = (FabricEnum)(userChoice - 1);

            newTshirt.SetPricingStrategy(new PriceTag(tshirt));
            newTshirt.GetPriceTag();

            Console.WriteLine("\nYour Choice:");
            PrintOut.PrintOutSingle(newTshirt);

            tshirt = newTshirt;

            AddToBasket(null);
        }

        private static void AddToBasket(int? userChoice)
        {
            Console.Write("Add to basket? Y/N: ");
            var addToBasket = Console.ReadLine();

            switch (addToBasket.ToLower())
            {
                case "y":
                    basket.TShirts.Add(tshirt);
                    if (userChoice == null)
                    {
                        Console.WriteLine($"\nTShirt added to basket.\n");
                        return;
                    }
                    else
                    {

                        Console.WriteLine($"\nTShirt {userChoice} added to basket.\n");
                        ChooseMenu();
                    }
                    break;
                case "n":
                    if (userChoice != null)
                        ChooseMenu();
                    break;
                default:
                    Console.WriteLine("\nNon valid choice! Try again...\n");
                    AddToBasket(userChoice);
                    break;
            }
        }

        private static void BasketMenu()
        {
            Console.WriteLine("\nMy basket:");

            if (basket.TShirts.Count == 0)
            {
                Console.WriteLine("\nThere is nothing in your basket at the moment.\n");
                return;
            }

            var userChoice = 0;
            var sb = new StringBuilder();

            int total = basket.TotalPayable();

            PrintOut.PrintOutList(basket.TShirts);

            Console.WriteLine($"\nCurrent amount payable: {total}\n");

            sb
                .AppendLine("1. Remove item")
                .AppendLine("2. Proceed to checkout")
                .AppendLine("3. Continue shopping");

            Console.WriteLine(sb.ToString());
            Console.Write("Make a choice: ");

            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNon valid choice! Try again...\n");
                return;
            }

            switch (userChoice)
            {
                case 1:
                    RemoveFromBasket();
                    break;
                case 2:
                    CheckOut();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("\nNon valid choice! Try again...\n");
                    BasketMenu();
                    break;
            }
        }

        private static void RemoveFromBasket()
        {
            var userChoice = 0;

            Console.Write("\nSelect Tshirt to remove: ");

            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNon valid choice! Try again...\n");
                BasketMenu();
            }

            if (userChoice > 0 && userChoice <= basket.TShirts.Count)
            {
                var tshirtToRemove = basket.TShirts[userChoice - 1];
                basket.TShirts.Remove(tshirtToRemove);

                Console.WriteLine($"\nTShirt {userChoice} removed from your basket");
            }
            else
                Console.WriteLine("\nNo such choice! Try again...");

            BasketMenu();
        }

        private static void CheckOut()
        {
            var userChoice = 0;
            //var payments = Enum.GetNames(typeof(PaymentEnum)).ToList();
            var payments = Enum.GetNames(typeof(PaymentEnum)).ToList();            

            Console.WriteLine("\nPayment methods:");

            for (int i = 0; i < payments.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(PositionEnumHelper.GetDisplayName((PaymentEnum)i));
            }

            Console.Write("Choose payment method: ");

            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNon valid choice! Try again...\n");
                return;
            }

            if (userChoice <= 0 || userChoice > payments.Count)
            {
                Console.WriteLine("\nNo such choice! Try again...\n");
                return;
            }

            basket.Payment = (PaymentEnum)userChoice;
            basket.SetPaymentMethod(new Payment());
            Console.WriteLine();
            basket.PaymentMethod();

            Console.Write("\nProceed with payment? Y/N: ");
            var proceed = Console.ReadLine();

            switch (proceed.ToLower())
            {
                case "y":
                    basket.TShirts.Clear();
                    basket.TotalPayable();
                    Console.WriteLine("\nThank you!\n");
                    return;
                case "n":
                    BasketMenu();
                    break;
                default:
                    Console.WriteLine("\nNon valid choice! Try again...\n");
                    break;
            }
        }
    }
}
