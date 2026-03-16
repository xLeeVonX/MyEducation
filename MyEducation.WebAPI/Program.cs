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

// Register repositories
builder.Services.AddScoped<IHOKStudentRepository, HOKStudentRepository>();
builder.Services.AddScoped<IHOKSubjectRepository, HOKSubjectRepository>();
builder.Services.AddScoped<IHOKTeacherRepository, HOKTeacherRepository>();
builder.Services.AddScoped<ITECStudentRepository, TECStudentRepository>();
builder.Services.AddScoped<ITECSubjectRepository, TECSubjectRepository>();
builder.Services.AddScoped<ITECTeacherRepository, TECTeacherRepository>();

// Register services
builder.Services.AddScoped<HOKStudentService>();
builder.Services.AddScoped<HOKSubjectService>();
builder.Services.AddScoped<HOKTeacherService>();
builder.Services.AddScoped<TECStudentService>();
builder.Services.AddScoped<TECSubjectService>();
builder.Services.AddScoped<TECTeacherService>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//  SWAGGER
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    //  USE SWAGGER
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var HOK = services.GetRequiredService<HOKcontext>();
    var TEC = services.GetRequiredService<TECcontext>();

    HOK.Database.EnsureCreated();
    TEC.Database.EnsureCreated();

    if (!HOK.Students.Any())
    {
        var student1 = new Student { Name = "Bob" };
        var student2 = new Student { Name = "Liz" };
        var student3 = new Student { Name = "Amanda" };
        var student4 = new Student { Name = "Caroline" };

        HOK.Students.AddRange(student1, student2, student3, student4);
        HOK.SaveChanges();
    }

    if (!HOK.Subjects.Any())
    {
        var subject1 = new Subject { Name = "Mathematics" };
        var subject2 = new Subject { Name = "Chemistry" };

        HOK.Subjects.AddRange(subject1, subject2);
        HOK.SaveChanges();
    }

    if (!HOK.Teachers.Any())
    {
        var teacher1 = new Teacher { Name = "Lola" };
        var teacher2 = new Teacher { Name = "George" };

        HOK.Teachers.AddRange(teacher1, teacher2);
        HOK.SaveChanges();
    }

    
    
    if (!TEC.Students.Any())
    {
        var student1 = new Student { Name = "Jacob" };
        var student2 = new Student { Name = "Kyle" };
        var student3 = new Student { Name = "Rolf" };
        var student4 = new Student { Name = "Bella" };

        TEC.Students.AddRange(student1, student2, student3, student4);
        TEC.SaveChanges();
    }

    if (!TEC.Subjects.Any())
    {
        var subject1 = new Subject { Name = "Geography" };
        var subject2 = new Subject { Name = "English" };

        TEC.Subjects.AddRange(subject1, subject2);
        TEC.SaveChanges();
    }

    if (!TEC.Teachers.Any())
    {
        var teacher1 = new Teacher { Name = "Sam" };
        var teacher2 = new Teacher { Name = "Kelly" };

        TEC.Teachers.AddRange(teacher1, teacher2);
        TEC.SaveChanges();
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
