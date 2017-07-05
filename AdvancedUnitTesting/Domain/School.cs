namespace AdvancedUnitTesting.Domain
{
    public class School
    {
        public School(string name, IDiplomaPrinter diplomaPrinter = null)
        {
            Name = name;
            _DiplomaPrinter = diplomaPrinter;
        }

        public string Name { get; set; }

        IDiplomaPrinter _DiplomaPrinter { get; set; }

        public string GraduateStudent(Student p)
        {
            // Do lots of stuff regarding the graduation.
            // Then do even more stuff...
            // ... and finally print the diploma!

            return _DiplomaPrinter.PrintDiploma(p);
        }
    }
}