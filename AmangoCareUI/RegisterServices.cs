using BlazorStrap;

namespace AmangoCareUI
{
    public static class RegisterServices
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddMemoryCache();
            builder.Services.AddBlazorStrap();

            builder.Services.AddSingleton<IDbConnection, DbConnection>();
            builder.Services.AddTransient<IAccountData, MongoAccountData>();
            builder.Services.AddTransient<IBankData, MongoBankData>();
            builder.Services.AddTransient<IBenefitData, MongoBenefitData>();
            builder.Services.AddTransient<IBenefitStateData, MongoBenefitStateData>();
            builder.Services.AddTransient<IHospitalData, MongoHospitalData>();
            builder.Services.AddTransient<IHealthWorkerData, MongoHealthWorkerData>();
            builder.Services.AddTransient<IIDTypeData, MongoIDTypeData>();
            builder.Services.AddTransient<IMedicalRecordData, MongoMedicalRecordData>();
            builder.Services.AddTransient<IMobileMoneyInfoData, MongoMobileMoneyInfoData>();
            builder.Services.AddTransient<IMobileMoneyTypeData, MongoMobileMoneyTypeData>();
            builder.Services.AddTransient<ISubscriberData, MongoSubscriberData>();
            builder.Services.AddTransient<IUserData, MongoUserData>();
            builder.Services.AddTransient<IVisaCardData, MongoVisaCardData>();
        }
    }
}
