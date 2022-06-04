using System;

namespace LearnCSharp
{
    interface IDataProvider
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из БД";
        }
    }

    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из Файла";
        }
    }

    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из АПИ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //IDataProcessor dataProcessor = new ConsoleDataProcessor(); 
            //dataProcessor.ProcessData(new DbDataProvider());
            //dataProcessor.ProcessData(new FileDataProvider());
            //dataProcessor.ProcessData(new APIDataProvider());

            int? number1 = null;

            number1 = number1 ?? 2;
        }
    }
}
