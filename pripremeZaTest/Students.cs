namespace testRep
{
    internal class Students
    {
        public string _name, _surname, _date, _direction, _index, _study;
        private string name { get => _name; set => _name = value; }
        private string surname { get => _surname; set => _surname = value; }
        private string date { get => _date; set => _date = value; }

        private string direction { get => _direction; set => _direction = value; }
        private string index { get => _index; set => _index = value; }
        private string study { get => _study; set => _study = value; }

        public Students(string name, string surname, string date, string direction, string index, string study)
        {
            _name = name;
            _surname = surname;
            _date = date;
            _direction = direction;
            _index = index;
            _study = study;
        }

        public override string ToString()
        {
            return $"{study}{name} {surname} | {date} | {direction} | {index}";
        }
    }
}