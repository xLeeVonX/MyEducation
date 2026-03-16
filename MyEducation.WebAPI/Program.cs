using MyEducation.WebAPI.Application.Services;
using MyEducation.WebAPI.Controllers;
using MyEducation.WebAPI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<HOKcontext>(options => options
    .UseSqlServer(
        builder.Configuration.GetConnectionString("HOK") ??
        throw new InvalidOperationException("Connection string 'HOK' not found.")
    ));

builder.Services.AddDbContext<TECcontext>(options => options
    .UseSqlServer(
        builder.Configuration.GetConnectionString("TEC") ??
        throw new InvalidOperationException("Connection string 'TEC' not found.")
    ));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var HOK = services.GetRequiredService<HOKcontext>();
    var TEC = services.GetRequiredService<TECcontext>();

    HOK.Database.EnsureCreated();
    TEC.Database.EnsureCreated();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
Program.cs
appsettings.json
GlobalUsings.cs
StudentService.cs
SubjectService.cs
TeacherService.cs
HOKStudentsController.cs
HOKSubjectsController.cs
HOKTeachersController.cs
TECStudentsController.cs
TECSubjectsController.cs
TECTeachersController.cs
Student.cs
Subject.cs
Teacher.cs
IStudentRepository.cs
ISubjectRepository.cs
ITeacherRepository.cs
HOKcontext.cs
TECcontext.cs
HOKStudentRepository.cs
HOKSubjectRepository.cs
HOKTeacherRepository.cs
TECStudentRepository.cs
TECSubjectRepository.cs
TECTeacherRepository.cs
*/