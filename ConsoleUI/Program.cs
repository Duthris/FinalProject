using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {            
            ProductTest();
            CategoryTest();
            ProductUnitPriceTest();
            ProductCategoryIdTest();
            ProductCategoryNameTest();

            Console.ReadLine();
        }

        private static void ProductCategoryNameTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                Console.WriteLine("\n############ SİSTEMDE KAYITLI ÜRÜN / KATEGORİ LİSTESİ ############\n");

                foreach (var product in result.Data)
                {
                    Console.WriteLine("{0}: {1} / {2}\n", product.ProductId, product.ProductName, product.CategoryName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ProductCategoryIdTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetAllByCategoryId(2);

            if (result.Success == true)
            {
                Console.WriteLine("\n############ BELİRTİLEN KATEGORİ NUMARASINA AİT ÜRÜNLER ############\n");

                foreach (var product in result.Data)
                {
                    Console.WriteLine("{0}: {1}", product.ProductId, product.ProductName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ProductUnitPriceTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetByUnitPrice(40, 100);

            if (result.Success == true)
            {
                Console.WriteLine("\n############ BELİRTİLLEN FİYAT ARALIĞINDAKİ ÜRÜNLER ############\n");

                foreach (var product in result.Data)
                {
                    Console.WriteLine("{0}: {1}", product.ProductId, product.ProductName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            Console.WriteLine("\n############ SİSTEMDE KAYITLI ÜRÜN KATEGORİLERİ ############\n");

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine("{0}: {1}", category.CategoryId, category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetAll();

            if (result.Success == true)
            {
                Console.WriteLine("############ SİSTEMDE KAYITLI ÜRÜNLER ############\n");

                foreach (var product in result.Data)
                {
                    Console.WriteLine("{0}: {1}", product.ProductId, product.ProductName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
