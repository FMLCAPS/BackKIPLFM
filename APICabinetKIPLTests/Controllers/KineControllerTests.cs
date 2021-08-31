using Microsoft.VisualStudio.TestTools.UnitTesting;
using APICabinetKIPL.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KIPLModel;
using Microsoft.Extensions.Logging;
using Moq;

namespace APICabinetKIPL.Controllers.Tests
{
    [TestClass()]
    public class KineControllerTests
    {
        private Bdd _bdd;
        private KineController _controller;
        private readonly ILogger<KineController> _logger;
        private readonly ILogger<KineControllerTests> _loggerTest;
        public KineControllerTests()
        {
            
            _bdd = new Bdd();
            _logger = Mock.Of<ILogger<KineController>>();
            _controller = new KineController(_bdd, _logger);
        }

        [TestMethod()]
        public void GetTest()
        {
            // Appel de l'api
            IEnumerable<object> result = _controller.Get();
            int countFromApi = result.Count();

            // Appel de la bdd
            int countFromBdd = _bdd.Kines.Count();

            Assert.AreEqual(countFromApi, countFromBdd);
        }

        [TestMethod()]
        public void GetTestID()
        {
            _logger.LogInformation("Get Test KineID Called");
            Kine kinesFromBdd = _bdd.Kines.FirstOrDefault();
            Assert.IsNotNull(kinesFromBdd);

            Kine kineFromApi = _controller.Get(kinesFromBdd.Id);
            Assert.IsNotNull(kinesFromBdd);

            Assert.AreEqual(kineFromApi.Id, kinesFromBdd.Id);

        }


        [TestMethod()]
        public void AddTest()
        {
            // Possibilité de tester l'ajout ou la suppression mais cela ne répondrait pas réellement au besoin de ce cas de figure. 
        }




    }
}