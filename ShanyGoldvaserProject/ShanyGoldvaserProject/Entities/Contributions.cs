﻿namespace ShanyGoldvaserProject.Entities
{
    public class Contributions
    {
        public int Id { get; set; }
        public double Sum { get; set; }
        public DateOnly Date { get; set; }
        public string Donor { get; set; }
        public string NameForPraying { get; set; }
    }
}
