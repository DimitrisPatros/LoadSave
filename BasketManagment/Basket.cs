using Newtonsoft.Json;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasketManagment
{
    class Basket:IText,IExcel,IJson
    {

        public List<Product> Cart;

        public Basket()
        {
            Cart = new List<Product>();
        }



        public bool SaveJson(string FileName)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(Cart, Formatting.None);
                File.WriteAllText($@"C:\Users\patro\Desktop\doc\{FileName}.json", jsonData);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;

        }

        public bool LoadJson(string FileName)
        {
            try
            {
                // If i want i can put the filename that i am trying t open here 
                //string data = File.ReadAllText($@"C:\Users\patro\Desktop\doc\{FileName}.json");
                string data = File.ReadAllText(@"C:\Users\patro\Desktop\doc\tryToSaveToJason.json");
                Cart = JsonConvert.DeserializeObject<List<Product>>(data);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool SaveExcel(string FileName)
        {
            try
            {
                XSSFWorkbook wb = new XSSFWorkbook();
                ISheet sheet = wb.CreateSheet("Sheet");
                int x = 0;
                var r1 = sheet.CreateRow(0);
                r1.CreateCell(0).SetCellValue("ID");
                r1.CreateCell(1).SetCellValue("Name");
                r1.CreateCell(2).SetCellValue("Price");
                r1.CreateCell(2).SetCellValue("Category")

            foreach (Product p in Cart)
                {
                    x++;
                    var r = sheet.CreateRow(x);
                    r.CreateCell(0).SetCellValue(Cart[x - 1].Id);
                    r.CreateCell(1).SetCellValue(Cart[x - 1].Name);
                    r.CreateCell(2).SetCellValue(Cart[x - 1].Price);
                    r.CreateCell(2).SetCellValue(Cart[x - 1].Category);
                }

                using (var fs = new FileStream($"{FileName}.xlsx", FileMode.Create,
                FileAccess.Write))
                {
                    wb.Write(fs);
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool LoadExcel(string FileName)
        {
            try
            {
                Cart.Clear();
                XSSFWorkbook hssfwb;
                using (FileStream file = new FileStream
                    ($@"C:\Users\patro\source\repos\Excel\Excel\bin\Debug\netcoreapp2.2\{FileName}.xlsx"
                    , FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new XSSFWorkbook(file);
                }
                ISheet sheet = hssfwb.GetSheet("Sheet");
                for (int row = 1; row <= sheet.LastRowNum; row++)
                {
                    if (sheet.GetRow(row) != null)
                    {
                        double idTemp = sheet.GetRow(row).GetCell(0).NumericCellValue;
                        string name = sheet.GetRow(row).GetCell(1).StringCellValue;
                        double Price = sheet.GetRow(row).GetCell(2).NumericCellValue;
                        double categoryTemp = sheet.GetRow(row).GetCell(3).NumericCellValue;
                        int category = Convert.ToInt32(categoryTemp);
                        int id = Convert.ToInt32(idTemp);
                        Cart.Add(new Product(id, name, Price, category));
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool SaveText(string FileName)
        {
            using (StreamWriter file = new StreamWriter($" C: \\Users\\patro\\Desktop\\doc\\{filename}.txt"))
            {
                try
                {
                    foreach (Product p in Cart)
                    {
                        file.WriteLine(p.ToString());
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool LoadText(string FileName)
        {

            try
            {
                //Sentence = File.ReadAllLines($@"C:\Users\patro\Desktop\doc\{filename}.txt").ToList();
                using (FileStream fileStream = new FileStream($@"C:\Users\patro\Desktop\doc\{FileName}.txt"
                    , FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        Product product;
                        while ((productString = streamReader.ReadLine( ) != null)
                        {
                            productString.Split(" ").ToList();
                            Cart.Add(product);
                        }
                    }
                }

                foreach (Product p in Cart)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine(p);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public void PrintList()
        {
            foreach (Product p in Cart)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("---------------------");
            }
        }


    }
}



