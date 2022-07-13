using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailContainerTest.Data;
using Xunit;
namespace MailContainerTest.Tests.Data
{
    public class BackupMailContainerDataStoreTest
    {
        BackupMailContainerDataStore mailDataStore = new BackupMailContainerDataStore();
        
        [Fact]
        public void WhenCalled_GetMailContainer()
        {
            var mailContainerName = "ContainerName";
            var mailContainer = mailDataStore.GetMailContainer(mailContainerName);
            Assert.NotNull(mailContainer);
        }
        [Fact]
        public void WhenCalled_UpdateMailContainer()
        {

        }
    }
}
