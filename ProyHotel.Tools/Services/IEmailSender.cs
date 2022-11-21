using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Tools.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsnyc(string email, string subject, string message);
    }
}
