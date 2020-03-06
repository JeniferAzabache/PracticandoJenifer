using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ClassLibrary.ApplicationBDContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            protected override void Seed(ClassLibrary.ApplicationBDContext context)
        {

        }
        }
    }
}