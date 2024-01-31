using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;

namespace MetigatorAcademy.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    public IRepository<Coporate> coporatesRepository { get; private set; }
    public IRepository<Course> coursesRepository { get; private set; }
    public IRepository<Enrollment> enrollmentsRepository { get; private set; }
    public IRepository<Indiviual> indiviualsRepository { get; private set; }
    public IRepository<Instructor> instructorsRepository { get; private set; }
    public IRepository<Office> officesRepository { get; private set; }
    public IRepository<Participant> participantsRepository { get; private set; }
    public IRepository<Schedule> schedulesRepository { get; private set; }
    public IRepository<Section> sectionsRepository { get; private set; }

    

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        coporatesRepository = new Repository<Coporate>(_context);
        coursesRepository = new Repository<Course>(_context);
        enrollmentsRepository = new Repository<Enrollment>(_context);
        indiviualsRepository = new Repository<Indiviual>(_context);
        instructorsRepository = new Repository<Instructor>(_context);
        officesRepository = new Repository<Office>(_context);
        participantsRepository = new Repository<Participant>(_context);
        schedulesRepository = new Repository<Schedule>(_context);
        sectionsRepository = new Repository<Section>(_context);
    }
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    public void Dispose() 
    {
        _context.Dispose();
    }
}
