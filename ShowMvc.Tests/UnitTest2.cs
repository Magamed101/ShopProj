using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using ShopMvc.Controllers;
using ShopMvc.Data.Interfaces;
using ShopMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class UnitTest2

    {
        [Test]

        public void GetAllLiquids_Returns_RightCountOfLiquids()
        {
            var mock = new Mock<ILiquidRepository>();
            mock.Setup(a => a.GetAll()).Returns(GetAll());

            var controller = new LiquidsController(mock.Object);

            // Act
            var result = controller.Index() as ViewResult;

            var model = result.Model as List<Liquid>;
            // Assert
            Assert.AreEqual(2, model.Count());

        }
        private List<Liquid> GetAll()
        {
            var liquids = new List<Liquid>
            {
                new Liquid()
                {
                    Name = "Liquid1",

                },
                new Liquid()
                {
                    Name = "Liquid2",
                }
            };
            return liquids;
        }
    }
}
