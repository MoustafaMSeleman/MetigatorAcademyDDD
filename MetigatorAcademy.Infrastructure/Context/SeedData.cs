using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Domain.Enums;
namespace MetigatorAcademy.Infrastructure.Context;

public static class SeedData
{

    // Method to load data for Offices
    public static List<Office> LoadOffices() => new()
    {
        new Office ("Off_05","Building A"){ },
        new Office ("Off_12", "Building B"){ },
        new Office ("Off_32", "Administration"){ },
        new Office ("Off_44", "IT Department" ){},
        new Office ("Off_43","IT Department" ){}
    };

    // Method to load data for Courses
    public static List<Course> LoadCourses() => new()
    {
       new Course ("Mathematics",1000.00m ){ },
       new Course ("Physics" ,2000.00m){ },
       new Course ("Chemistry",1500.00m ){},
       new Course ("Biology", 1200.00m){ },
       new Course ("CS-50", 3000.00m){ }
    };

    // Method to load data for Schedules
    public static List<Schedule> LoadSchedules() => new()
    {
      new Schedule (ScheduleEnum.Daily, true, true, true,  true,  true,  false, false){ },
      new Schedule (ScheduleEnum.DayAfterDay, true, false,  true,  false, true,  false,  false){ },
      new Schedule (ScheduleEnum.TwiceAWeek, false,  true, false,  true, false, false, false ){},
      new Schedule (ScheduleEnum.Weekend, false,false, false, false,  false, true,  true ){},
      new Schedule (ScheduleEnum.Compact, true, true, true, true,  true, true, true){ }
    };

    // Method to load data for Instructors
    public static List<Instructor> LoadInstructors() => new()
    {
        new Instructor ("Ahmed", "Abdullah",  1){ },
        new Instructor ("Yasmeen", "Mohammed", 2){ },
        new Instructor ("Khalid",  "Hassan",  3 ){},
        new Instructor ("Nadia", "Ali", 4 ){},
        new Instructor ("Omar", "Ibrahim",  5){ }
    };

    // Method to load data for Sections
    public static List<Section> LoadSections() => new()
    {
        new Section ("S_MA1",1, 1,  1, new TimeSlot { StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") } ){},
        new Section ("S_MA2",1, 2,  3, new TimeSlot { StartTime = TimeSpan.Parse("14:00:00"), EndTime = TimeSpan.Parse("18:00:00") } ){},
        new Section ("S_PH1",2, 1,  4, new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("15:00:00") }){},
        new Section ("S_PH2",2, 3,  1, new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("12:00:00") }){},
        new Section ("S_CH1",3, 2,  1, new TimeSlot { StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") }){},
        new Section ("S_CH2",3, 3,  2, new TimeSlot { StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") }){},
        new Section ("S_BI1",4, 4,  3, new TimeSlot { StartTime = TimeSpan.Parse("11:00:00"), EndTime = TimeSpan.Parse("14:00:00") }){},
        new Section ("S_BI2",4, 5,  4, new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("14:00:00") }){},
        new Section ("S_CS1",5, 4,  4, new TimeSlot { StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") }){},
        new Section ("S_CS2",5, 5,  3, new TimeSlot { StartTime = TimeSpan.Parse("12:00:00"), EndTime = TimeSpan.Parse("15:00:00") }){},
        new Section ("S_CS3",5, 4,  5, new TimeSlot { StartTime = TimeSpan.Parse("09:00:00"), EndTime = TimeSpan.Parse("11:00:00") }){}
    };


    // Method to load data for Corporates
    public static List<Coporate> LoadCorporates() => new()
    {
        new Coporate (2, "Noor","Saleh","ABC", "Developer" ){},
        new Coporate (4, "Huda", "Ahmed",  "ABC",  "QA"){ },
        new Coporate (7, "Yousef", "Farid", "EFG",  "Developer"){ },
        new Coporate (8, "Layla", "Mustafa",  "EFG",  "QA"){ }
    };

    // Method to load data for Individuals
    public static List<Indiviual> LoadIndividuals() => new()
    {
        new Indiviual ( 10, "Samira", "Nabil", "XYZ",  2024,  false){ },
        new Indiviual ( 1, "Fatima", "Ali", "XYZ",2024,  false ){},
        new Indiviual ( 3, "Omar", "Youssef",  "POQ",  2023,  true ){},
        new Indiviual ( 5, "Amira", "Tariq", "POQ", 2025, false){ },
        new Indiviual ( 6, "Zainab", "Ismail",  "POQ",  2023,  true ){},
        new Indiviual ( 9, "Mohammed", "Adel",  "XYZ",  2024, false){ },
    };


    // Method to load data for Enrollments
    public static List<Enrollment> LoadEnrollments() => new()
    {
        new Enrollment { SectionId = 6, ParticipantId = 1 },
        new Enrollment { SectionId = 6, ParticipantId = 2 },
        new Enrollment { SectionId = 7, ParticipantId = 3 },
        new Enrollment { SectionId = 7, ParticipantId = 4 },
        new Enrollment { SectionId = 8, ParticipantId = 5 },
        new Enrollment { SectionId = 8, ParticipantId = 6 },
        new Enrollment { SectionId = 9, ParticipantId = 7 },
        new Enrollment { SectionId = 9, ParticipantId = 8 },
        new Enrollment { SectionId = 10, ParticipantId = 9 },
        new Enrollment { SectionId = 10, ParticipantId = 10 }
    };
}
