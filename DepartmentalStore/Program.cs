using DepartmentalStore.Data;
using DepartmentalStore.Domain;
using System;

namespace DepartmentalStore
{
    public class Program
    {
        public static DepartmentStoreContext Context = new DepartmentStoreContext();
        static void Main(string[] args)
        {
            AddAddress();
            AddCategory();
            AddInventory();
            AddProduct();
            AddProductCategory();
            AddPurchaseOrder();
            AddRole();
            AddStaff();
            AddSupplier();
            AddSupplierProduct();

        }
        //Insert Values in Role Table
        public static void AddRole()
        {
            var Role = new Role { RoleName = "Accountant", Description = "Money Transactions" };
            var Role1 = new Role { RoleName = "Guard", Description = "Protecting Store" };
            var Role2 = new Role { RoleName = "Sweeper", Description = "Cleaning" };
            var Role3 = new Role { RoleName = "Manager", Description = "Manage WorkFlow" };
            Context.AddRange(Role, Role1, Role2, Role3);
            Context.SaveChanges();
        }


        //Insert Values in Staff Table
        public static void AddStaff()
        {
            var staff = new staff { RoleId = 4, AddressId = 4, FirstName = "Yanshik", LastName = "Rajput", Email = "yansh123@gmail.com" };
            var staff1 = new staff { RoleId = 5, AddressId = 5, FirstName = "Harshit", LastName = "Varshney", Email = "har123@gmail.com" };
            var staff2 = new staff { RoleId = 6, AddressId = 6, FirstName = "Vikas", LastName = "Kumar", Email = "viks123@gmail.com" };
            var staff3 = new staff { RoleId = 7, AddressId = 7, FirstName = "Max", LastName = "Boy", Email = "max123@gmail.com" };
            Context.AddRange(staff, staff1, staff2, staff3);
            Context.SaveChanges();
        }


        //Insert Values in Category Table
        public static void AddCategory()
        {
            var category = new Category { CategoryName = "Stationary" };
            var category1 = new Category { CategoryName = "Electronics" };
            var category2 = new Category { CategoryName = "Men Wears" };
            var category3 = new Category { CategoryName = "Chocolates" };
            Context.AddRange(category, category1, category2, category3);
            Context.SaveChanges();
        }     

        //Insert Values in Address Table
        public static void AddAddress()
        {
            var Address = new Address { AddressLine1 = "Nayanpura", AddressLine2 = "Panipat Road", City = "Bijnor", State = "Uttar Pradesh", Pincode = "564532" };
            var Address1 = new Address { AddressLine1 = "Ramgarh", AddressLine2 = "Mall Road", City = "Dehradun", State = "Uttarakhand", Pincode = "765432" };
            var Address2 = new Address { AddressLine1 = "Baghpati", AddressLine2 = "Khateema Road", City = "Bhopal", State = "Arunachal Pradesh", Pincode = "763456" };
            var Address3 = new Address { AddressLine1 = "Hanuman Chowk", AddressLine2 = "Kullu Road", City = "Meerut", State = "Himachal", Pincode = "908765" };
            Context.AddRange(Address, Address1, Address2, Address3);
            Context.SaveChanges();
        }


        //Insert Values in Inventory Table
        public static void AddInventory()
        {
            var Inventory = new Inventory { ProductId = 1, Instock = true, Quantity = 15 };
            var Inventory1 = new Inventory { ProductId = 2, Instock = false, Quantity = 25 };
            var Inventory2 = new Inventory { ProductId = 3, Instock = true, Quantity = 40 };
            var Inventory3 = new Inventory { ProductId = 4, Instock = false, Quantity = 30 };
            Context.AddRange(Inventory, Inventory1, Inventory2, Inventory3);
            Context.SaveChanges();
        }


        //Insert Values in Product Table
        public static void AddProduct()
        {
            var Product = new Product { Name = "Jeans", Manufacturer = "Levi's", ShortCode = "Bottomwear", CostPrice = 2500, SellingPrice = 3500 };
            var Product1 = new Product { Name = "Shirts", Manufacturer = "Roadster", ShortCode = "Upperwear", CostPrice = 1500, SellingPrice = 2500 };
            var Product2 = new Product { Name = "Shoes", Manufacturer = "Adidas", ShortCode = "Footwear", CostPrice = 5500, SellingPrice = 7900 };
            var Product3 = new Product { Name = "Chocolates", Manufacturer = "DairyMilk", ShortCode = "Eatable", CostPrice = 150, SellingPrice = 600 };
            Context.AddRange(Product, Product1, Product2, Product3);
            Context.SaveChanges();

        }


        //Insert Values in ProductCategory Table
        public static void AddProductCategory()
        {
            var ProductCategory = new ProductCategory { Id = 1, CategoryId = 1 };
            var ProductCategory1 = new ProductCategory { Id = 2, CategoryId = 2 };
            var ProductCategory2 = new ProductCategory { Id = 3, CategoryId = 3 };
            var ProductCategory3 = new ProductCategory { Id = 4, CategoryId = 4 };
            Context.AddRange(ProductCategory, ProductCategory1, ProductCategory2, ProductCategory3);
            Context.SaveChanges();

        }

        //Insert Values in PurchaseOrder Table
        public static void AddPurchaseOrder()
        {
            var PurchaseOrder = new PurchaseOrder { ProductId = 1, SupplierId = 1, OrderDate = "2019-08-11", QuantityRequired = 90 };
            var PurchaseOrder1 = new PurchaseOrder { ProductId = 2, SupplierId = 2, OrderDate = "2012-05-22", QuantityRequired = 50 };
            var PurchaseOrder2 = new PurchaseOrder { ProductId = 3, SupplierId = 3, OrderDate = "2016-09-15", QuantityRequired = 30 };
            var PurchaseOrder3 = new PurchaseOrder { ProductId = 4, SupplierId = 4, OrderDate = "2015-09-29", QuantityRequired = 70 };
            Context.AddRange(PurchaseOrder, PurchaseOrder1, PurchaseOrder2, PurchaseOrder3);
            Context.SaveChanges();

        }



        //Insert Values in Supplier Table
        public static void AddSupplier()
        {
            var Supplier = new Supplier { SupplierName = "Max", SupplierPhoneNumber = "9876567897", Gender = 'M', Email = "max123@gmail.com", City = "San Francisco" };
            var Supplier1 = new Supplier { SupplierName = "Rex", SupplierPhoneNumber = "8765456789", Gender = 'F', Email = "rex123@gmail.com", City = "California" };
            var Supplier2 = new Supplier { SupplierName = "Adam", SupplierPhoneNumber = "8754345676", Gender = 'F', Email = "adam123@gmail.com", City = "New York" };
            var Supplier3 = new Supplier { SupplierName = "Maxwell", SupplierPhoneNumber = "9867546789", Gender = 'M', Email = "maxwell123@gmail.com", City = "Seattle" };
            Context.AddRange(Supplier, Supplier1, Supplier2, Supplier3);
            Context.SaveChanges();
        }


        //Insert Values in SupplierProduct Table
        public static void AddSupplierProduct()
        {
            var SupplierProduct = new SupplierProduct { SupplierId = 1, Id = 1 };
            var SupplierProduct1 = new SupplierProduct { SupplierId = 2, Id = 2 };
            var SupplierProduct2 = new SupplierProduct { SupplierId = 3, Id = 3 };
            var SupplierProduct3 = new SupplierProduct { SupplierId = 4, Id = 4 };
            Context.AddRange(SupplierProduct, SupplierProduct1, SupplierProduct2, SupplierProduct3);
            Context.SaveChanges();
        }

    }
}
