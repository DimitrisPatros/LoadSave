namespace BasketManagment
{
    public interface IExcel
    {
        bool SaveExcel(string FileName);
        bool LoadExcel(string FileName);
    }
}
