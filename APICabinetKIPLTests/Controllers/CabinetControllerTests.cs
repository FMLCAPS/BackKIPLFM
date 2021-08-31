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
    public class CabinetControllerTests
    {
        private Bdd _bdd;
        private CabinetController _controller;
        private readonly ILogger<CabinetController> _logger;

        public CabinetControllerTests()
        {

            _bdd = new Bdd();
            _logger = Mock.Of<ILogger<CabinetController>>();
            _controller = new CabinetController(_bdd, _logger);
        }

        [TestMethod()]
        public void GetTest()
        {
            //_logger.LogInformation("Get Test Cabinet Called");
            // Appel de l'api
            IEnumerable<object> result = _controller.Get();
            int countFromApi = result.Count();

            // Appel de la bdd
            int countFromBdd = _bdd.Cabinets.Count();

            Assert.AreEqual(countFromApi, countFromBdd);
        }

        [TestMethod()]
        public void GetTestID()
        {
            //_logger.LogInformation("Get TestID Cabinet Called");
            Cabinet cabinetFromBdd = _bdd.Cabinets.FirstOrDefault();
            Assert.IsNotNull(cabinetFromBdd);

            Cabinet cabinetFromApi = _controller.Get(cabinetFromBdd.Id);
            Assert.IsNotNull(cabinetFromBdd);

            Assert.AreEqual(cabinetFromApi.Id, cabinetFromBdd.Id);
            Assert.AreEqual(cabinetFromApi.Libelle, cabinetFromBdd.Libelle);


        }


        [TestMethod()]
        public void AddTest()
        {
            // Possibilité de tester l'ajout ou la suppression mais cela ne répondrait pas réellement au besoin de ce cas de figure. 
        }


        

    }
}