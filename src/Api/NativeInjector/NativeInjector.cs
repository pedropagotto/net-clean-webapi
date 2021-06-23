using Api.Controllers.User;
using Application.Boundaries;
using Application.Repositories;
using Application.UseCases.UserManager.AddUser;
using Application.UseCases.UserManager.AddUser.Handlers;
using Infrastructure.DataBase.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Api.NativeInjector
{
    public static class NativeInjector
    {
        public static void RegisterDI(this IServiceCollection services)
        {
            RegisterPresenters(services);
            RegisterUseCases(services);
            RegisterHandlers(services);
            RegisterDecorators(services);
            RegisterServices(services);
            RegisterRepositories(services);
        }

        private static void RegisterUseCases(IServiceCollection services)
        {
            services.AddScoped<IAddUserUseCase, AddUserUseCase>();
            //services.AddScoped<IGetUsersUseCase, GetUsersUseCase>();
        }

        private static void RegisterHandlers(IServiceCollection services)
        {
            services.AddScoped<CreateUserHandler, CreateUserHandler>();
            services.AddScoped<VerifyProfileHandler, VerifyProfileHandler>();
            services.AddScoped<ValidateNewUserHandler, ValidateNewUserHandler>();

        }

        private static void RegisterDecorators(IServiceCollection services)
        {
        }

        private static void RegisterPresenters(IServiceCollection services)
        {
            services.AddScoped<IOutputPort<AddUserUcResponse>, UserPresenter>();
            services.AddScoped<UserPresenter, UserPresenter>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
