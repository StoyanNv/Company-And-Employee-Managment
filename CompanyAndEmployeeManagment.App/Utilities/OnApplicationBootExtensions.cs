namespace CompanyAndEmployeeManagment.App.Utilities
{
    using CompanyAndEmployeeManagment.Models;
    using Data;
    using Microsoft.AspNetCore.Builder;
    using System.Linq;

    public static class OnApplicationBootExtensions
    {
        public static async void Seed(this IApplicationBuilder app)
        {
            //using (var context = new CompanyAndEmployeeManagmentContext())
            //{
            //    if (!context.Levels.Any())
            //    {
            //        context.Levels.Add(new Level() { ExperienceLevel = 'A' });
            //        context.Levels.Add(new Level() { ExperienceLevel = 'B' });
            //        context.Levels.Add(new Level() { ExperienceLevel = 'C' });
            //        context.Levels.Add(new Level() { ExperienceLevel = 'D' });
            //        await context.SaveChangesAsync();
            //    }
            //}
        }
    }
}