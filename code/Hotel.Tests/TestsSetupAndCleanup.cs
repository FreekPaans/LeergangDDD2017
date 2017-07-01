using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel.DAL;
using Hotel.DAL.Migrations;

namespace Hotel.Tests {
    [TestClass]
    public class TestsSetupAndCleanup {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext) {
            Database.SetInitializer(new DropCreateDatabaseAlways<HotelDbContext>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<HotelDbContext, Configuration>());
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup() {
        }
    }
}