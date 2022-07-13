using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailContainerTest.Services;
using MailContainerTest.Types;
using Xunit;
using NSubstitute;
namespace MailContainerTest.Tests.Services
{
    public class MailTransferServiceTest
    {
        MailTransferService mailTransferService = new MailTransferService();

        [Fact]
        public void WhenCalled_MakeMailTransferRequest_ReturnsAsSuccess()
        {
            //Arrange
            MakeMailTransferRequest request = new MakeMailTransferRequest
            {
                SourceMailContainerNumber = "SourceContainerName",
                DestinationMailContainerNumber = "DestinationContainerName",
                NumberOfMailItems = 1,
                TransferDate = DateTime.Now,
                MailType = MailType.LargeLetter
            };

            //Act
            var result = mailTransferService.MakeMailTransfer(request);

            //Assert
            Assert.True(result.Status, $"Mail transfer request is successful for the conatiner : " +
                $"{request.SourceMailContainerNumber}");

        }
        [Fact]
        public void WhenCalled_MakeMailTransferRequest_ReturnAsFailed()
        {
            // Arrange
            MakeMailTransferRequest request = new MakeMailTransferRequest
            {
                SourceMailContainerNumber = "",
                DestinationMailContainerNumber = "",
                NumberOfMailItems = 1,
                TransferDate = DateTime.Now,
                MailType = MailType.SmallParcel
            };

            //Act
            var result = mailTransferService.MakeMailTransfer(request);

            //Assert
            Assert.False(result.Status, $"Mail transfer request is failed for the conatiner : {request.SourceMailContainerNumber}");

        }
    }
}
