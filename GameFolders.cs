using System;

namespace UnRenCS
{
    internal class GameFolder
    {

        public GameFolder(string Name, DateTime ChangeDate)
        {
            this.Name = Name;
            this.ChangeDate = ChangeDate;
        }

        public string Name { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
