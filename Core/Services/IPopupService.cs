using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IPopupService
    {
        void Show(string title, string message, string firstButtonText, Action firstButtonAction, string secondButtonText, Action secondButtonAction);
    }
}
