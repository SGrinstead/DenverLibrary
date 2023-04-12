using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenverLibrary.UnitTests
{
    public class BranchTests
    {
        [Fact]
        public void BranchConstructor_Name()
        {
            Branch parkHill = new Branch("Park Hill Library");
            Assert.Equal("Park Hill Library", parkHill.Name);
        }

        [Fact]
        public void AddAndRetrieveBook()
        {
            Branch parkHill = new Branch("Park Hill Library");
            Book dune = new Book("Dune", "Frank Herbert");
            parkHill.AddBook(dune);
            Assert.Equal(dune, parkHill.Books[0]);
        }

        [Fact]
        public void CanRetrieveAuthors()
        {
            Branch parkHill = new Branch("Park Hill Library");
            Book dune = new Book("Dune", "Frank Herbert");
            Book hobbit = new Book("The Hobbit", "JRR Tolkien");

            parkHill.AddBook(dune);
            parkHill.AddBook(hobbit);

            Assert.Equal(new List<string> { "Frank Herbert", "JRR Tolkien" }, parkHill.AllAuthors());
        }
    }
}
