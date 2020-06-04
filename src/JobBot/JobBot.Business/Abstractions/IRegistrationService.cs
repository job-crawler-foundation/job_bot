using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobBot.Business.Abstractions
{
    public interface IRegistrationService
    {
        Task EnsureRegistered();
    }
}
