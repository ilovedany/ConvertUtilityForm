namespace ConvertUtilityForm;

public partial class LoadingForm : Form
{
    public LoadingForm(int selectView,string xmlFilePath,string xlsxFilePath,int deleteOrNo,int openOrNo)
    {
        InitializeComponent();
        this.TopMost = true;
        Shown += LoadingFormAsync; //событие показа загрузочной формы

        this.selectView = selectView;
        this.xmlFilePath = xmlFilePath;
        this.xlsxFilePath = xlsxFilePath;
        this.deleteOrNo = deleteOrNo;
        this.openOrNo = openOrNo;
    }
    private int selectView;
    private string xmlFilePath;
    private string xlsxFilePath;
    private int deleteOrNo;
    private int openOrNo;
    private async void LoadingFormAsync(object sender, EventArgs e)
    {
        try
        {
            progressBar1.Value = 0;

            var wrapper = new ViewSelection(progress => Invoke(new MethodInvoker(() =>
            {
                progressBar1.Value = progress;
                label2.Text = $"{progress}%";
            })));

            await wrapper.ViewSelectionMethod(selectView, xmlFilePath, xlsxFilePath, deleteOrNo, openOrNo); //передача параметрв
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            Close();
        }
    }
}
