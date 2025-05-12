using XmlToXlsx;
namespace ConvertUtilityForm
{
    public class ViewSelection
    {
        private readonly Action<int> _progressCallback;

        public ViewSelection(Action<int> progressCallback)
        {
            _progressCallback = progressCallback;
        }

        XmlToExcelConverter XmlToExcelConverter = new XmlToExcelConverter();
        GetXmlFromDataBase xmlFromDataBase = new GetXmlFromDataBase();

        //метод для выбора вида утилиты
        public async Task ViewSelectionMethod(int selectView, string pathToXml, string pathToSave, int deleteOrNo, int openOrNo)
        {
            await Task.Run(() =>
            {
                _progressCallback?.Invoke(25); //обратная связь для progressbar
                switch (selectView)
                {
                    case 1:
                        _progressCallback?.Invoke(50);
                        string savePathXml = Path.ChangeExtension(pathToXml, ".xlsx"); //смена расширения
                        _progressCallback?.Invoke(75);
                        XmlToExcelConverter.ConvertXmlToXlsxPath(pathToXml,savePathXml, deleteOrNo, openOrNo); //вызов утилиты по директории
                        _progressCallback?.Invoke(100);
                        break;

                    case 2:
                        _progressCallback?.Invoke(50);
                        string xmlDataString = xmlFromDataBase.GetStringXmlFromDB("connectionString", "table", "column", 1);
                        _progressCallback?.Invoke(75);
                        XmlToExcelConverter.ConvertXmlToXlsxString(xmlDataString, pathToSave, openOrNo); //вызов утилиты по строке, которая содержит xml
                        _progressCallback?.Invoke(100);
                        break;

                    default:
                        throw new ArgumentException();
                }
            });
        
        }
    }
}
