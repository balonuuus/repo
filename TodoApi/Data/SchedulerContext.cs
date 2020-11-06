using TodoApi.Models;
using Microsoft.EntityFrameworkCore;


namespace TodoApi.Data
{
    public class SchedulerContext : DbContext
    {
        public SchedulerContext(DbContextOptions<SchedulerContext> opt) : base(opt)
        {

        }

        public DbSet<Schedule> Schedules { get; set; }
    }
}