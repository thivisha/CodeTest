using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailContainerTest.Types;
namespace MailContainerTest.Data
{
    public class MakeMailContainerBase
    {
        public virtual MailContainer GetMailContainer(string mailContainerNumber)
        {
            throw new NotImplementedException();
        }
        public virtual void UpdateMailContainer(MailContainer mailContainer)
        {
            // Update mail container in the database. Implementation not required for this exercise.
        }
    }
}
