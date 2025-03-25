using Mediatheque.Core.Model;
using Mediatheque.Core.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.CoreTests.ServiceTests.MediathequeServiceTests
{
    [TestClass]
    public class GetNombreObjetShould
    {
        [TestMethod]
        public void Return0_WhenNoObject()
        {
            //Arrange
            var notationServiceMock = new Mock<INotationService>().Object;
            var mediathequeService = new MediathequeService(notationServiceMock);



            //Act
            int actual = mediathequeService.GetNombreObjet();

            //Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Return03_When3Object()
        {
            //Arrange
            var notationServiceMock = new Mock<INotationService>().Object;
            var mediathequeService = new MediathequeService(notationServiceMock);
            mediathequeService.AddObjet(new CD("Spice world", "Spice girl"));
            mediathequeService.AddObjet(new CD("Smash", "Offspring"));
            mediathequeService.AddObjet(new JeuxDeSociete("Jeux de 54 cartes", 3,99,"carrefour", TypeJeuxDeSociete.Carte));

            //Act
            int actual = mediathequeService.GetNombreObjet();

            //Assert
            Assert.AreEqual(3, actual);
        }
    }
}
