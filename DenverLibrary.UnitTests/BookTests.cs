namespace DenverLibrary.UnitTests
{
    public class BookTests
    {
        [Fact]
        public void BookConstructorGetAndSet()
        {
            Book dune = new Book("Dune", "Frank Herbert");

            Assert.Equal("Dune", dune.Title);
            Assert.Equal("Frank Herbert", dune.Author);
        }
    }
}