using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doingSTUFF
{
    public class Magazine : IPossession
    {
        public DateTime DateLastRead { get; }

        public DateTime DateLastConsumed()
        {
            return DateLastRead;
        }

        public void SortPossessions()
        {
            throw new NotImplementedException();
        }
    }

    public class CD : IPossession
    {
        public DateTime DateLastListened { get; }

        public DateTime DateLastConsumed()
        {
            return DateLastListened;
        }

        public void SortPossessions()
        {
            throw new NotImplementedException();
        }
    }

    public class _3A
    {
        private List<IPossession> possessions = new();        

        public void Trash(IPossession possession)
        {
            this.possessions.Remove(possession);
        }

        public void SortPossessions()
        {
            foreach (IPossession p in this.possessions)
            {
                DateTime dateLastComsumed = p.DateLastConsumed();

                if (dateLastComsumed < DateTime.Today)
                {
                    this.Trash(p);
                }
            }
        }
    }
}
