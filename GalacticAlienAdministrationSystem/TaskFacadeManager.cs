using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class TaskFacadeManager
    {
        private ISpeciesCompliance _speciesCompliance;
        private IFacadeScheduling _scheduling;
        private INotifications _notifier;

        public TaskFacadeManager(ISpeciesCompliance speciesCompliance, IFacadeScheduling scheduling, INotifications notifier)
        {
            _speciesCompliance = speciesCompliance;
            _scheduling = scheduling;
            _notifier = notifier;
        }

        public void ExecuteTask(Alien alien)
        {
            _scheduling.CreateBookingSchedule();
            _speciesCompliance.IsSpeciesCompliant(alien);
            _notifier.Notify(alien);
        }
    }
}
