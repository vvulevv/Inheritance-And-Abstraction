using System;
using System.Collections.Generic;

class School
{
    static void Main()
    {
        //Students:
        Student johnny = new Student("Johnny", 13, "много голем пич");
        Student dido = new Student("Dido", 29, "Come on Arsenal!");
        Student kiko = new Student("Konstantin", 16, null);

        //Disciplines:
        Discipline boxing = new Discipline("Boxing", 66, "ще пада мааане", johnny, dido, kiko);
        Discipline football = new Discipline("Football", 1000, "the king of the sports", johnny, kiko);
        Discipline flying = new Discipline("Flying", 162, null, dido);

        //Teachers:
        Teacher georgiIvanov = new Teacher("Gonzo", "най-големия!", football);
        Teacher kubratPuev = new Teacher("Kobrata", null, boxing);
        Teacher vvulevv = new Teacher("Вълев", null, flying);
        List<Teacher> teachers = new List<Teacher>();
        teachers.Add(georgiIvanov);
        teachers.Add(kubratPuev);
        teachers.Add(vvulevv);

        //Class:
        Class firstGrade = new Class("The start of your career!", teachers);
    }
}