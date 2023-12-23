using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrm
{
    internal class DateFuncs
    {
        public static int CalculerJoursConges(DateTime startDate, DateTime endDate)
        {
            // Valider le plage des dates
            ValiderPlageDeDates(startDate, endDate);
            // Valider les jours de travail (Les dates ne doivent pas pointer vers une date avec un samedi ou un dimanche)
            ValiderJoursTravail(startDate, endDate);
            // Differences entre deux dates en jours
            int totalDays = (int)(endDate - startDate).TotalDays;
            // Initialiser le nombre de jours ouvrables
            int leaveDays = 0;
            // Parcourir les jours entre les deux dates
            for (int i = 0; i <= totalDays; i++)
            {
                // Date courante
                DateTime currentDate = startDate.AddDays(i);
                // Si le jour courant n'est pas un samedi ou un dimanche
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    // Incrementer le nombre de jours ouvrables
                    leaveDays++;
                }
            }
            // Retourner le nombre de jours ouvrables
            return leaveDays;
        }

        public static void ValiderPlageDeDates(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new Exception("La plage de dates sélectionnée n'est pas valide. Veuillez vous assurer que la date de début est antérieure à la date de fin.");
            }
        }

        public static void ValiderJoursTravail(DateTime startDate, DateTime endDate)
        {
            if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday ||
                endDate.DayOfWeek == DayOfWeek.Saturday || endDate.DayOfWeek == DayOfWeek.Sunday)
            {
                throw new Exception("Les dates sélectionnées ne doivent pas être des jours non ouvrables.");
            }
        }
    }
}

