using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class BookingCommandScheduler
    {
        ICommand command;
        public void SetBookingCommand(ICommand command)
        {
            this.command = command;

        }

        public void ExecuteBookingCommand()
        {
            command.Execute();
        }

        public void UndoBookingCommand()
        {
            command.Undo();
        }
    }
}
