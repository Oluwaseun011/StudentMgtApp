namespace StudentMgtApp.Models.Entities
{
    public class Student
    {
        public int Id {get;set;}
        public int GuardianId {get;set;}
        public string Name {get;set;} = null!;
        public int Age {get;set;}
        public int Class {get;set;}
        public Student(int id,int guardianid,string name,int age,int _class)
        {
            Id = id;
            GuardianId = guardianid;
            Name = name;
            Age = age;
            Class = _class;
        }

    }
}