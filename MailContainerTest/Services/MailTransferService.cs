using MailContainerTest.Data;
using MailContainerTest.Types;
using System.Configuration;
using MailContainerTest.Factory;
namespace MailContainerTest.Services
{
    public class MailTransferService : IMailTransferService
    {
               
        private MakeMailContainerBase makeMailContainerBase=null;

        public MakeMailTransferResult MakeMailTransfer(MakeMailTransferRequest request)
        {
            var dataStoreType = ConfigurationManager.AppSettings["DataStoreType"];
            MailContainer mailContainer = null;

            makeMailContainerBase = FactoryContainer.MailConatiner(dataStoreType);
            mailContainer = makeMailContainerBase.GetMailContainer(request.SourceMailContainerNumber);

            var result = new MakeMailTransferResult();

            switch (request.MailType)
            {
                case MailType.StandardLetter:
                    if (mailContainer == null 
                        || (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.StandardLetter))
                    {
                        result.Status = false;
                    }                   
                    break;
                case MailType.LargeLetter:
                    if (mailContainer == null 
                            || (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.LargeLetter)
                            || mailContainer.Capacity < request.NumberOfMailItems)
                    {
                        result.Status = false;
                    }                    
                    break;
                case MailType.SmallParcel:
                    if (mailContainer == null 
                            ||  (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.SmallParcel)
                            ||  (mailContainer.Status != MailContainerStatus.Operational))
                    {
                        result.Status = false;
                    }                    
                    break;
            }


            if (result.Status)
            {
                mailContainer.Capacity -= request.NumberOfMailItems;
                makeMailContainerBase.UpdateMailContainer(mailContainer);
            }

            return result;
        }
    }
}
