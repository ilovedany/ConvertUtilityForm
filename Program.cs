namespace ConvertUtilityForm;

static class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        int selectView = int.Parse(args[0]);
        string xmlFilePath = args[1];
        string xlsxFilePath = args[2];
        int deleteOrNo = int.Parse(args[3]);
        int openOrNo = int.Parse(args[4]);

        ApplicationConfiguration.Initialize();

        Application.Run(new LoadingForm(selectView,xmlFilePath,xlsxFilePath,deleteOrNo,openOrNo));
    }    
}