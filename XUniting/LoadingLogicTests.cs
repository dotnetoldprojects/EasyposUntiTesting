using Domain.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUniting
{
    public class LoadingLogicTests
    {
        [Fact]
        public void GetItems_ShouldReturnList()
        {
            // Arrange
            var logic = new LoadingLogic();

            // Act
            var result = logic.GetItems();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<item>>(result);
        }

        //[Fact]
        //public void CreateItemRowsList_ShouldReturnBindingList()
        //{
        //    var logic = new LoadingLogic();
        //    var result = logic.CreateItemRowsList();

        //    Assert.NotNull(result);
        //    Assert.IsType<BindingList<ItemRow>>(result);
        //}
    }

}
