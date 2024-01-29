using MetigatorAcademy.Domain.Entities;

namespace MetigatorAcademy.Domain.Common.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRepository<Coporate> coporatesRepository { get; }
    IRepository<Course> coursesRepository { get; }
    IRepository<Enrollment> enrollmentsRepository { get; }
    IRepository<Indiviual> indiviualsRepository { get; }
    IRepository<Instructor> instructorsRepository { get; }
    IRepository<Office> officesRepository { get; }
    IRepository<Participant> participantsRepository { get; }
    IRepository<Schedule> schedulesRepository { get; }
    IRepository<Section> sectionsRepository { get; }

    int SaveChanges();
}
