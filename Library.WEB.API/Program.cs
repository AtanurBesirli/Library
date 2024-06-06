/* -------------------------------  ALT-1  -----------------------------------------------*/
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Session;
using System.Security.Principal;
using Library.WEB.API.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        // add services to DI container
        {
            var services = builder.Services;
            services.AddCors();
            //services.AddControllers().AddNewtonsoftJson(options =>
            //{
            //    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //});
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddHttpContextAccessor();
            // configure strongly typed settings object
            //services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
            //Configure DI for application services
            services.AddScoped<ILibraryService, LibraryService>();

            //services.AddDbContextFactory<EamContext>();
            //services.AddScoped<IJwtUtils, JwtUtils>();
            
            //services.AddScoped<IAccountService, AccountService>();
            //services.AddScoped<IParameterService, ParameterService>();
            //services.AddScoped<IProcessService, ProcessService>();
            //services.AddScoped<TransactionActionFilterAttribute>();
            //services.AddScoped<IMaterialService, MaterialService>();
            //services.AddScoped<IStationService, StationService>();
            //services.AddScoped<IEquipmentService, EquipmentService>();
            //services.AddScoped<IOperationService, OperationService>();
            //services.AddScoped<IStickerService, StickerService>();

            ////EAM SERVICES
            //services.AddScoped<INoteService, NoteService>();
            //services.AddScoped<IAttachmentService, AttachmentService>();
            //services.AddScoped<IAssetTemplateService, AssetTemplateService>();
            //services.AddScoped<ITransactionHistoryService, TransactionHistoryService>();
            //services.AddScoped<IAssetParameterService, AssetParameterService>();
            //services.AddScoped<IAssetService, AssetService>();
            //services.AddScoped<ICalendarService, CalendarService>();
            //services.AddScoped<IClassificationService, ClassificationService>();
            //services.AddScoped<IInventoryParameterService, InventoryParameterService>();
            //services.AddScoped<IInventoryService, InventoryService>();
            //services.AddScoped<IItemService, ItemService>();
            //services.AddScoped<IItemParameterService, ItemParameterService>();
            //services.AddScoped<ILocationService, LocationService>();
            //services.AddScoped<IWorkOrderService, WorkOrderService>();
            //services.AddScoped<IMaintenanceService, MaintenanceService>();
            //services.AddScoped<IManufacturerService, ManufacturerService>();
            //services.AddScoped<IVendorService, VendorService>();
            //services.AddScoped<ISessionService, SessionService>();
            //services.AddScoped<IFailureClassService, FailureClassService>();
            //services.AddScoped<IMaintenanceParameterService, MaintenanceParameterService>();
            //services.AddScoped<IHistoryService, HistoryService>();
            //services.AddScoped<ISessionService, SessionService>();


            services.AddMvc().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                opt.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            });
            services.AddDistributedMemoryCache();
            services.AddSession();
            //services.addmv().AddJsonOptions(opt =>
            //{
            //    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;

            //});
        }
        var app = builder.Build();

        // configure HTTP request pipeline
        {
            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseDeveloperExceptionPage();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwagger();
            app.UseSwaggerUI();
            //}

            // custom jwt auth middleware
            //app.UseMiddleware<JwtMiddleware>();
            app.MapControllers();

            ////SET APPLICATION CONSTANTS
            //string environmentName = builder.Configuration.GetSection("AppSettings").GetValue<string>("EnvironmentName");
            //string connectionString = builder.Configuration.GetSection("AppSettings").GetValue<string>("ConnectionString");
            string erpConnectionString = builder.Configuration.GetSection("AppSettings").GetValue<string>("ERPConnectionString");

            //EnvironmentType environmentType = EnvironmentType.Undefined;
            //if (environmentName.Equals("Development"))
            //{
            //    environmentType = EnvironmentType.Development;
            //}
            //else if (environmentName.Equals("Test"))
            //{
            //    environmentType = EnvironmentType.Test;
            //}
            //else if (environmentName.Equals("PreProd"))
            //{
            //    environmentType = EnvironmentType.PreProd;
            //}
            //else if (environmentName.Equals("Production"))
            //{
            //    environmentType = EnvironmentType.Production;
            //}

            //ConstantParameters.ApiSettings = new APISettings
            //{
            //    //EnvironmentType = environmentType,
            //    //ConnectionString = connectionString,
            //    ErpConnectionString = erpConnectionString,
            //    SessionAccount = new Account()
            //};

            //ParameterService.LoadParameters();
        }
        app.Run();
    }
}





























//using Library.WEB.API.Service;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<ILibraryService, LibraryService>();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
