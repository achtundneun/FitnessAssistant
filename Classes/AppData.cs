using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes
{
    class AppData
    {
        public static DataBase.FitnesAssistantEntities Context { get; } = new DataBase.FitnesAssistantEntities();
    }
}
