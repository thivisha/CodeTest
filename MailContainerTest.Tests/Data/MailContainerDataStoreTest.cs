using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MailContainerTest.Data;

namespace MailContainerTest.Tests.Data
{

    public class MailContainerDataStoreTest
    {
        MailContainerDataStore mailDataStore = new MailContainerDataStore();
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
