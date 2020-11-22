using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        private StreamingContent _content;
        private StreamingContentRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert", "R", 5.8, false, GenreType.Horror);
            _repo.AddContentToList(_content);
        }
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";
            StreamingContentRepository repo = new StreamingContentRepository();
            //Act
            repo.AddContentToList(content);
            StreamingContent contentFromDirectory = repo.GetContentByTitle("Toy Story");
            //Assert
            Assert.IsNotNull(contentFromDirectory);
        }

        [TestMethod]
        public void UpdateExistingContent()
        {
            //Arange
            StreamingContent newContent = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert", "R", 10, true, GenreType.RomCom);

            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow("Rubber", true)]
        [DataRow("Toy Story", false)]
        public void UpdateExistingContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate)
        {
            //Arange
            StreamingContent newContent = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert", "R", 10, true, GenreType.RomCom);

            //Act
            bool updateResult = _repo.UpdateExistingContent(originalTitle, newContent);

            //Assert
            Assert.AreEqual(shouldUpdate, updateResult );
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            //Arrange
            //this is in the test initialize

            //Act
            bool deleteResult = _repo.RemoveContentFromList("Rubber");

            //Assert
            Assert.IsTrue(deleteResult);
        }
    }
}
