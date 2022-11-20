namespace Lab17_3
{
    public struct Timetable
    {
        public string nazv;
        public int numr;
        public string date;
        public string time;
        public int capacity;
        public override string ToString()
        {
            return $"Train: {this.nazv}, {this.numr}, {this.date}, {this.time}, {this.capacity}";
        }
    }
}   