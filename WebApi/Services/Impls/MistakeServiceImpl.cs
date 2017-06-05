using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services.Impls
{
    public class MistakeServiceImpl : IMistakeService
    {


        string writePath = @"C:\Users\Айрат\documents\visual studio 2015\Projects\WebApi\WebApi\App_Data\codeForAnalysis.txt";
        public Mistake getMistake()
        {
            //получение сведений об ошибках с другого проекта
            return new Mistake();
        }

        public void saveToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }
    }
}
