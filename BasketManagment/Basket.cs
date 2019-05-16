using System.Collections.Generic;

namespace BasketManagment
{
    public class Basket
    {

        public List<Product> Cart { get; set; }

        public Basket()
        {
            Cart = new List<Product>();
        }

 

        //public bool SaveExcel(string FileName, string SheetName)
        //{

        //    XSSFWorkbook wb = new XSSFWorkbook();
        //    ISheet sheet = wb.CreateSheet(SheetName);
        //    int x = 0;
        //    var r1 = sheet.CreateRow(0);
        //    r1.CreateCell(0).SetCellValue("ID");
        //    r1.CreateCell(1).SetCellValue("Name");
        //    r1.CreateCell(2).SetCellValue("Price");
        //    r1.CreateCell(3).SetCellValue("Category");

        //    foreach (Product p in Cart)
        //    {
        //        x++;
        //        var r = sheet.CreateRow(x);
        //        r.CreateCell(0).SetCellValue(Cart[x - 1].Id);
        //        r.CreateCell(1).SetCellValue(Cart[x - 1].Name);
        //        r.CreateCell(2).SetCellValue((double)Cart[x - 1].Price);
        //        r.CreateCell(3).SetCellValue(Cart[x - 1].Category.ToString());
        //    }
        //    try
        //    {
        //        using (var fs = new FileStream($@"C:\Users\patro\Desktop\doc\{FileName}.xlsx", FileMode.Create,
        //        FileAccess.Write))
        //        {
        //            wb.Write(fs);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //public bool LoadExcel(string FileName, string SheetName)
        //{
        //    Cart.Clear();
        //    try
        //    {
        //        Cart.Clear();
        //        XSSFWorkbook hssfwb;
        //        using (FileStream file = new FileStream
        //            ($@"C:\Users\patro\Desktop\doc\{FileName}.xlsx", FileMode.Open, FileAccess.Read))
        //        {
        //            hssfwb = new XSSFWorkbook(file);
        //        }
        //        ISheet sheet = hssfwb.GetSheet(SheetName);
        //        for (int row = 1; row <= sheet.LastRowNum; row++)
        //        {
        //            if (sheet.GetRow(row) != null)
        //            {
        //                int id = (int)sheet.GetRow(row).GetCell(0).NumericCellValue;
        //                string name = sheet.GetRow(row).GetCell(1).StringCellValue;
        //                decimal Price = (decimal)sheet.GetRow(row).GetCell(2).NumericCellValue;
        //                ProductCategoryId category = Enum.Parse<ProductCategoryId>(sheet.GetRow(row).GetCell(3).StringCellValue);
        //                Cart.Add(new Product(id, name, Price, category));
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //public bool SaveText(string FileName)
        //{
        //    try
        //    {
        //        using (StreamWriter file = new StreamWriter($"C:\\Users\\patro\\Desktop\\doc\\{FileName}.txt"))
        //        {
        //            foreach (Product p in Cart)
        //            {
        //                file.WriteLine(p.ToString());
        //            }
        //            return true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public bool LoadText(string FileName)
        //{
        //    Cart.Clear();
        //    try
        //    {
        //        foreach (var line in File.ReadAllLines($@"C:\Users\patro\Desktop\doc\{FileName}.txt"))
        //        {
        //            if (!string.IsNullOrWhiteSpace(line))
        //            {
        //                var item = line.Split(":");
        //                int id = int.Parse(item[0]);
        //                string name = item[1];
        //                decimal Price = decimal.Parse(item[2]);
        //                ProductCategoryId category = Enum.Parse<ProductCategoryId>(item[3]);
        //                Cart.Add(new Product(id, name, Price, category));

        //            }
        //        }
        //        PrintList();
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //public void PrintList()
        //{
        //    foreach (Product p in Cart)
        //    {
        //        Console.WriteLine(p.ToString());
        //        Console.WriteLine("---------------------");
        //    }
        //}

        //public void FillWithDummyData()
        //{
        //    Cart.Add(new Product(1, "puma", (decimal)89.99, ProductCategoryId.shoes));
        //    Cart.Add(new Product(2, "addidas", (decimal)115.55, ProductCategoryId.shoes));
        //    Cart.Add(new Product(3, "leves", (decimal)44.65, ProductCategoryId.jeans));
        //    Cart.Add(new Product(4, "gap", (decimal)88, ProductCategoryId.jeans));
        //    Cart.Add(new Product(5, "LV", (decimal)1124.25, ProductCategoryId.bags));
        //    Cart.Add(new Product(6, "Trusardi", (decimal)3.65, ProductCategoryId.shirt));
        //}
    }
}



