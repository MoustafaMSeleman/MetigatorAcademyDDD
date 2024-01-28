using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Domain.Enums;
namespace MetigatorAcademy.Infrastructure.Context;

public static class SeedData
{

    // Method to load data for Offices
    public static IEnumerable<Office> LoadOffices() 
    {
        return new List<Office>() 
        {
            new Office (1,"Off_05","Building A"){ },
            new Office (2,"Off_12", "Building B"){ },
            new Office (3,"Off_32", "Administration"){ },
            new Office (4,"Off_44", "IT Department" ){},
            new Office (5,"Off_43","IT Department" ){}
        };
    }

    // Method to load data for Courses
    public static IEnumerable<Course> LoadCourses()
    {
        return new List<Course>()
       {
            new Course (1,"Mathematics",1000.00m ){ },
            new Course (2,"Physics" ,2000.00m){ },
            new Course (3,"Chemistry",1500.00m ){},
            new Course (4,"Biology", 1200.00m){ },
            new Course (5,"CS-50", 3000.00m){ }
        };
    }

    // Method to load data for Schedules
    public static IEnumerable<Schedule> LoadSchedules() 
    {
        IEnumerable<Schedule> schedules = new List<Schedule>() { 
           new Schedule (1,ScheduleEnum.Daily, true, true, true,  true,  true,  false, false){ },
           new Schedule (2,ScheduleEnum.DayAfterDay, true, false,  true,  false, true,  false,  false){ },
           new Schedule (3,ScheduleEnum.TwiceAWeek, false,  true, false,  true, false, false, false ){},
           new Schedule (4,ScheduleEnum.Weekend, false,false, false, false,  false, true,  true ){},
           new Schedule (5,ScheduleEnum.Compact, true, true, true, true,  true, true, true){ }
     };
        return schedules;
    }

    // Method to load data for Instructors
    public static IEnumerable<Instructor> LoadInstructors()
    {
        return new List<Instructor>() 
        {
            new Instructor (1, "Ahmed", "Abdullah", 1){ },
            new Instructor (2,"Yasmeen", "Mohammed", 2){ },
            new Instructor (3,"Khalid",  "Hassan",  3 ){},
            new Instructor (4,"Nadia", "Ali", 4 ){},
            new Instructor (5,"Omar", "Ibrahim",  5){ }
        };
    }

    // Method to load data for Sections
    public static IEnumerable<Section> LoadSections() 
    {
        return new List<Section>()
        {
            new Section (1,"S_MA1",1, 1,  1, new TimeSlot { StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") } ){},
            new Section (2,"S_MA2",1, 2,  3, new TimeSlot { StartTime = TimeSpan.Parse("14:00:00"), EndTime = TimeSpan.Parse("18:00:00") } ){},
            new Section (3,"S_PH1",2, 1,  4, new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("15:00:00") }){},
            new Section (4,"S_PH2",2, 3,  1, new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("12:00:00") }){},
            new Section (5,"S_CH1",3, 2,  1, new TimeSlot { StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") }){},
            new Section (6,"S_CH2",3, 3,  2, new TimeSlot { StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") }){},
            new Section (7,"S_BI1",4, 4,  3, new TimeSlot { StartTime = TimeSpan.Parse("11:00:00"), EndTime = TimeSpan.Parse("14:00:00") }){},
            new Section (8,"S_BI2",4, 5,  4, new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("14:00:00") }){},
            new Section (9,"S_CS1",5, 4,  4, new TimeSlot { StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") }){},
            new Section (10,"S_CS2",5, 5,  3, new TimeSlot { StartTime = TimeSpan.Parse("12:00:00"), EndTime = TimeSpan.Parse("15:00:00") }){},
            new Section (11,"S_CS3",5, 4,  5, new TimeSlot { StartTime = TimeSpan.Parse("09:00:00"), EndTime = TimeSpan.Parse("11:00:00") }){}
        };
        
    }


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
    public static IEnumerable<Enrollment> LoadEnrollments() 
    {
        return new List<Enrollment>()
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
}
