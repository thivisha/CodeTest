using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MailContainerTest.Data;

namespace MailContainerTest.Tests.FactoryContainer
{
    public class FactoryContainerTest
    {

        [Fact]
        public void CreateObject_When_DataStoreType_As_MailContainer()
        {
            MakeMailContainerBase makeMailContainerBase= 
                Factory.FactoryContainer.MailConatiner("MailContainer");
           
            Assert.NotNull(makeMailContainerBase);
            
        }
        [Fact]
        public void CreateObject_When_DataStoreType_AS_BackupMailContainer()
        {
            MakeMailContainerBase makeMailContainerBase=
                Factory.FactoryContainer.MailConatiner("BackupMailContainer");

            Assert.NotNull(makeMailContainerBase);
        }

    }
}
