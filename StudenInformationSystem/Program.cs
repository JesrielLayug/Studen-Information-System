using StudenInformationSystem.Data;
using StudenInformationSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StudenInformationSystem.Repositories.Contracts;
using StudenInformationSystem.Repositories;
using StudenInformationSystem.Services.Contracts;
using StudenInformationSystem.Services;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.Entity.SqlServer;

namespace StudenInformationSystem
{
    public static class ServiceLocator
    {
        private static Dictionary<Type, Func<object>> services = new Dictionary<Type, Func<object>>();

        public static void Register<TService, TImplementation>() where TImplementation : new()
        {
            services[typeof(TService)] = () => new TImplementation();
        }

        public static TService GetService<TService>()
        {
            return (TService)services[typeof(TService)].Invoke();
        }

        public static void Register<TService>(Func<TService> factory)
        {
            services[typeof(TService)] = () => factory.Invoke();
        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var db = new ApplicationDbContext())
            {
                db.Database.CreateIfNotExists();

                // Register all the repositories
                ServiceLocator.Register<IAdminRepository>(() => new AdminRepository(db));
                ServiceLocator.Register<IClassRepository>(() => new ClassRepository(db));
                ServiceLocator.Register<ICourseRepository>(() => new CourseRepository(db));
                ServiceLocator.Register<IEnrollmentRepository>(() => new EnrollmentRepository(db));
                ServiceLocator.Register<IStudentRepository>(() => new StudentRepository(db));
                ServiceLocator.Register<ISubjectRepository>(() => new SubjectRepository(db));

                // Register all the services
                ServiceLocator.Register<IAdminService>(() => new AdminService(ServiceLocator.GetService<IAdminRepository>()));
                ServiceLocator.Register<IClassService>(() => new ClassService(ServiceLocator.GetService<IClassRepository>()));
                ServiceLocator.Register<ICourseService>(() => new CourseService(ServiceLocator.GetService<ICourseRepository>()));
                ServiceLocator.Register<IEnrollmentService>(() => new EnrollmentService(ServiceLocator.GetService<IEnrollmentRepository>()));
                ServiceLocator.Register<IStudentService>(() => new StudentService(ServiceLocator.GetService<IStudentRepository>()));
                ServiceLocator.Register<ISubjectService>(() => new SubjectService(ServiceLocator.GetService<ISubjectRepository>()));

                // Create instances using the service locator
                var adminRepository = ServiceLocator.GetService<IAdminRepository>();
                var classRepository = ServiceLocator.GetService<IClassRepository>();
                var courseRepository = ServiceLocator.GetService<ICourseRepository>();
                var enrollmentRepository = ServiceLocator.GetService<IEnrollmentRepository>();
                var studentRepository = ServiceLocator.GetService<ISubjectRepository>();
                var subjectRepository = ServiceLocator.GetService<ISubjectRepository>();

                // Create services with the registered repositories
                var adminService = ServiceLocator.GetService<IAdminService>();
                var classService = ServiceLocator.GetService<IClassService>();
                var courseService = ServiceLocator.GetService<ICourseService>();
                var enrollmentService = ServiceLocator.GetService<IEnrollmentService>();
                var studentService = ServiceLocator.GetService<IStudentService>();
                var subjectService = ServiceLocator.GetService<ISubjectService>();

                Application.Run(new LoginView(adminService, classService, courseService, enrollmentService, studentService, subjectService));
            }



            //Application.Run(new LoginView(adminService));
            //Application.Run(new MainView());
        }
    }
}
