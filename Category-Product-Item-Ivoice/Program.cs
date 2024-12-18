using Category_Product_Item_Ivoice.Controllers;

CategoryController categoryController = new CategoryController();
ProductController productController = new ProductController();
ItemController itemController = new ItemController();
IvoiceController ivoiceController=new IvoiceController();
while (true)
{
crudd: Console.WriteLine("--------------Crud Operations---------------");
    Console.WriteLine("----------------1.For Category---------------");
    Console.WriteLine("----------------2.For Product---------------");
    Console.WriteLine("----------------3.For Item---------------");
    Console.WriteLine("----------------4.For Ivoice---------------");
    Console.WriteLine("----------------5.Exit----------------------");
    Console.Write("Enter your choice:");
    int choice = Int32.Parse(Console.ReadLine());
    if (choice == 1)
    {
    categoryy: Console.WriteLine("------------For category crud operations--------------");
        Console.WriteLine("1.GetAll  2.Delete   3.Update  4.GetById  5.Add  6.Exit");
        Console.Write("Enter your choice:");
        int categoryChoice = Int32.Parse(Console.ReadLine());
        if (categoryChoice == 1)
        {
            categoryController.GetAllCategory();
            goto categoryy;
        }
        else if (categoryChoice == 2)
        {
            categoryController.DeleteCategoryById();
            goto categoryy;

        }
        else if (categoryChoice == 3)
        {
            categoryController.UpdateCategory();
            goto categoryy;

        }
        else if (categoryChoice == 4)
        {
            categoryController.GetCategoryById();
            goto categoryy;

        }
        else if (categoryChoice == 5)
        {
            categoryController.AddCategory();
            goto categoryy;

        }
        else if (categoryChoice == 6)
        {
            goto crudd;
        }
        else
        {
            Console.WriteLine("Wrong choice format!");
            goto categoryy;

        }
    }
    else if (choice == 2)
    {
    productt: Console.WriteLine("------------For Product crud operations--------------");
        Console.WriteLine("1.GetAll  2.Delete   3.Update  4.GetById  5.Add  6.Exit");
        Console.Write("Enter your choice:");
        int productChoice = Int32.Parse(Console.ReadLine());
        if (productChoice == 1)
        {
            productController.GetAllShowProducts();
            goto productt;
        }
        else if (productChoice == 2)
        {
            productController.DeleteProductById();
            goto productt;

        }
        else if (productChoice == 3)
        {
            productController.UpdateProduct();
            goto productt;

        }
        else if (productChoice == 4)
        {
            productController.GetProductById();
            goto productt;

        }
        else if (productChoice == 5)
        {
            productController.AddProduct();
            goto productt;
        }
        else if (productChoice == 6)
        {
            goto crudd;
        }
        else
        {
            Console.WriteLine("Wrong choice format!");
            goto productt;

        }
    }
    else if (choice == 3)
    {
    itemm: Console.WriteLine("------------For Item crud operations--------------");
        Console.WriteLine("1.GetAll  2.Delete   3.Update  4.GetById  5.Add  6.Exit");
        Console.Write("Enter your choice:");
        int itemChoice = Int32.Parse(Console.ReadLine());
        if (itemChoice == 1)
        {
            itemController.GetAllItems();
            goto itemm;
        }
        else if (itemChoice == 2)
        {
            itemController.DeleteItemById();
            goto itemm;

        }
        else if (itemChoice == 3)
        {
            itemController.UpdateItem();
            goto itemm;

        }
        else if (itemChoice == 4)
        {
            itemController.GetItemById();
            goto itemm;

        }
        else if (itemChoice == 5)
        {
            itemController.AddItem();
            goto itemm;
        }
        else if (itemChoice == 6)
        {
            goto crudd;
        }
        else
        {
            Console.WriteLine("Wrong choice format!");
            goto itemm;

        }
    }
    else if (choice == 4)
    {
    ivoicee: Console.WriteLine("------------For Ivoice crud operations--------------");
        Console.WriteLine("1.GetAll  2.Delete   3.Update  4.GetById  5.Add 6.GetItemById 7.Exit");
        Console.Write("Enter your choice:");
        int ivoiceChoice = Int32.Parse(Console.ReadLine());
        if (ivoiceChoice == 1)
        {
            ivoiceController.GetAllIvoice();
            goto ivoicee;
        }
        else if (ivoiceChoice == 2)
        {
            ivoiceController.DeleteIvoiceById();
            goto ivoicee;

        }
        else if (ivoiceChoice == 3)
        {
            ivoiceController.UpdateIvoice();
            goto ivoicee;

        }
        else if (ivoiceChoice == 4)
        {
            ivoiceController.GetByIdVoice();
            goto ivoicee;

        }
        else if (ivoiceChoice == 5)
        {
            ivoiceController.AddIvoice();
            goto ivoicee;
        }
        else if (ivoiceChoice == 6)
        {
            ivoiceController.GetItemGetById();
            goto ivoicee;
        }
        else if (ivoiceChoice == 7)
        {
            goto crudd;
        }
        else
        {
            Console.WriteLine("Wrong choice format!");
            goto ivoicee;

        }
    }
    else
    {
        Console.WriteLine("Your choice is wrong.Please write true choice!");
        goto crudd;
    }

}
