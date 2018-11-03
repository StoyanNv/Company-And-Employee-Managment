namespace CompanyAndEmployeeManagment.Services
{
    using AutoMapper;
    using Data;

    public abstract class BaseEFService
    {
        protected BaseEFService(
            CompanyAndEmployeeManagmentContext dbContext,
            IMapper mapper)
        {
            this.DbContext = dbContext;
            this.Mapper = mapper;
        }

        protected CompanyAndEmployeeManagmentContext DbContext { get; private set; }

        protected IMapper Mapper { get; private set; }
    }
}