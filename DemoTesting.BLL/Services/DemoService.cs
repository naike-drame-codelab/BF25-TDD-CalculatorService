using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTesting.BLL.Services
{
    public class DemoService
    {
        public string GetTodayDate()
        {
            DateTime today = DateTime.Today;
            return today.ToShortDateString();
        }
    }
}
