using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailContainerTest.Services;
using MailContainerTest.Data;
namespace MailContainerTest.Factory
{
    public static class FactoryContainer
    {
        

        private static Dictionary<string, MakeMailContainerBase> dataStore =
           new Dictionary<string, MakeMailContainerBase>();          

        public static MakeMailContainerBase MailConatiner(string dataStoreType)
        {
            // Design Pattern : Lazy loading => load when colllection is empty
            if (dataStore.Count == 0)
            {
                dataStore.Add("MailContainer", new MailContainerDataStore());
                dataStore.Add("BackupMailContainer", new BackupMailContainerDataStore());
            }

            //Design Pattern : RIP - Replace IF with polymorphism
            return dataStore[dataStoreType];
        }
    }
}
