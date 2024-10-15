using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Threading.Tasks;
using ScreenSound.Banco;

namespace ScreenSound.Shared.Dados.Banco
{
    internal class ScreenSoundContextFactory : IDesignTimeDbContextFactory<ScreenSoundContext>
    {
        public ScreenSoundContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ScreenSoundContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KNM3SP8;Initial Catalog=ScreenBlazor;User ID=sa;Password=123456;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            return new ScreenSoundContext(optionsBuilder.Options);
        }
    }
}
