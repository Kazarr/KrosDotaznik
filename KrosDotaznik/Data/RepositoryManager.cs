using Data.Repository.Registers;

namespace Data
{
    public static class RepositoryManager
    {
        #region Properties
        public static StateRepository StateRepository = new StateRepository();
        public static HealthInsuranceRepository HealthRepository = new HealthInsuranceRepository();
        public static RetirementRepository RetirementRepository = new RetirementRepository();
        public static EducationLevelRepository EducationLevelRepository = new EducationLevelRepository();
        public static WageCategoryRepository WageCategoryRepository = new WageCategoryRepository();
        public static WorkExpirationRepository WorkExpirationRepository = new WorkExpirationRepository();
        public static WorkHoursRepository WorkHoursRepository = new WorkHoursRepository();
        public static WorkPositionRepository WorkPositionRepository = new WorkPositionRepository();
        public static WorkTypeRepository WorkTypeRepository = new WorkTypeRepository();
        public static DepartmentRepository DepartmentRepository = new DepartmentRepository();
        public static DivisionRepository DivisionRepository = new DivisionRepository();
        public static CountryRepository CountryRepository = new CountryRepository();
        #endregion
    }
}
