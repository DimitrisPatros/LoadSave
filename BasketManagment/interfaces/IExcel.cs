namespace BasketManagment
{
    public interface IExcel
    {
        bool SaveExcel(string FileName, string SheetName);
        bool LoadExcel(string FileName,string SheetName);
    }
}
