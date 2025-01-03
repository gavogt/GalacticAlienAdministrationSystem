using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class BookingScheduler
    {
        ICommand command;
        public void SetBookingCommand(ICommand command)
        {
            this.command = command;

        }

        public void BookingCommand()
        {
            command.Execute();
        }

        public void UndoBookingCommand()
        {
            command.Undo();
        }
    }
}
