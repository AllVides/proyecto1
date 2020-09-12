using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using proyecto1.Data;


namespace proyecto1.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OContext>>()))
            {
                // Look for any movies.
                if (context.Usuario.Any())
                {
                    return;   // DB has been seeded
                }

                context.Usuario.AddRange(
                    new Usuario
                    {
                        nombre = "admin",
                        apellido = "istrador",
                        nac = DateTime.Parse("1986-2-23"),
                        email = "ayaya@gmail.com",
                        username = "admin",
                        contraseña = "xx",
                        pais = "guatemala"

                    }

                    
                );
                context.SaveChanges();
            }
        }
    }
}
