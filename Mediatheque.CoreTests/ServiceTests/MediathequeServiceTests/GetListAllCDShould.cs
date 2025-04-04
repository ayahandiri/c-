using Mediatheque.Core.Model;
using Mediatheque.Core.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.CoreTests.ServiceTests.MediathequeServiceTests;

[TestClass]
    public class  GetListAllCDShould
    {
        [TestMethod]
        public void PasDeCD()
        {
            //Arrange
            
            var mediathequeService = new MediathequeService(null);



            //Act
            string actual = mediathequeService.GetListAllCD();

            //Assert
            Assert.AreEqual("il n y a pas de CD", "il n y a pas de CD");
        }

        [TestMethod]
        public void QueDesJeux()
        {
            //Arrange
            
            var mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new JeuxDeSociete("jeuxdefille.fr" , 1 , 198 , "Mode",TypeJeuxDeSociete.Plateau));
            mediathequeService.AddObjet(new JeuxDeSociete("Barbie" , 2 , 199 , "Mode",TypeJeuxDeSociete.Plateau));



            //Act
            string actual = mediathequeService.GetListAllCD();

            //Assert
            Assert.AreEqual("il ya 2 jeux", "il ya 2 jeux");
        }

        [TestMethod]
        public void ContientQueCD()
        {
            //Arrange
            
            var mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new CD("princesse et la grenouille","Disney"));
            mediathequeService.AddObjet(new CD("10 bonnes raisons pour te larguer","Diseny"));



            //Act
            string actual = mediathequeService.GetListAllCD();

            //Assert
            Assert.AreEqual("il y a 2 CD ", "il y a 2 CD ");
        }


        [TestMethod]
        public void ContientTout()
        {
            //Arrange
            
            var mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new CD("princesse et la grenouille","Disney"));
            mediathequeService.AddObjet(new CD("10 bonnes raisons pour te larguer","Diseny"));
            mediathequeService.AddObjet(new JeuxDeSociete("jeuxdefille.fr" , 1 , 198 , "Mode",TypeJeuxDeSociete.Plateau));
            mediathequeService.AddObjet(new JeuxDeSociete("Barbie" , 2 , 199 , "Mode",TypeJeuxDeSociete.Plateau));



            //Act
            string actual = mediathequeService.GetListAllCD();

            //Assert
            Assert.AreEqual("il y a 2 CD", "il y a 2 CD");
        }

        
    }