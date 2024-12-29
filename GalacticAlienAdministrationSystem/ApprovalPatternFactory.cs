using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class ApprovalPatternFactory
    {
        public static IApprovalBookingStrategyPattern ApprovalStrategy()
        {
            int choice;
            Console.Write("Enter 1 for Manual Approval and 2 for Auto Approval: ");
            int.TryParse(Console.ReadLine(), out choice);

            return choice switch
            {
                1 => new ManualApprovalStrategy(),
                2 => new AutoApprovalStrategy(),
                _ => throw new InvalidOperationException("Invalid choice")

            };
        }
    }
}
