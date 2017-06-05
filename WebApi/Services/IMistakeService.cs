using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    interface IMistakeService
    {
        void saveToFile(string text);
        Mistake getMistake();
    }
}
