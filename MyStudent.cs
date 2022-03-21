namespace StudentActions
{
    internal class MyStudent
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public string? HairColor { get; set; }
        public string? EyeColor { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string? Group { get; set; }
        public string? SpecialtyCode { get; set; }
        public bool LiveOnDormitory { get; set; }

        public static MyStudent Add(MyStudent x, MyStudent y)
        {
            MyStudent addResult = new()
            {
                Name = x.Name + y.Name,
                Surname = x.Surname + y.Surname,
                Gender = x.Gender + y.Gender,
                Age = x.Age + y.Age,
                HairColor = x.HairColor + y.HairColor,
                EyeColor = x.EyeColor + y.EyeColor,
                Height = x.Height + y.Height,
                Weight = x.Weight + y.Weight,
                Group = x.Group + y.Group,
                SpecialtyCode = x.SpecialtyCode + y.SpecialtyCode,
                LiveOnDormitory = x.LiveOnDormitory || y.LiveOnDormitory
            };

            return addResult;
        }

        public static void GetInfoAboutStudent(MyStudent x)
        {
            Console.WriteLine
            (
                $"Student info:\n" +
                $"Name: { x.Name }\n" +
                $"Surname: { x.Surname }\n" +
                $"Gender: { x.Gender }\n" +
                $"Age: { x.Age } years\n" +
                $"Hair color: { x.HairColor }\n" +
                $"Eye color: { x.EyeColor }\n" +
                $"Height: { x.Height } m\n" +
                $"Weight: { x.Weight } kg\n" +
                $"Group: { x.Group }\n" +
                $"Specialty code: { x.SpecialtyCode }\n" +
                $"Live on dormitory: { (x.LiveOnDormitory ? "yes" : "no") }\n"
            );
        }
    }
}
