using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenverLibrary.UnitTests
{
    public class LibraryTests
    {
        [Fact]
        public void LibraryConstructorName()
        {
            Library dpl = new Library("Denver Public Library");
            Assert.Equal("Denver Public Library", dpl.Name);
        }

        [Fact]
        public void AddAndRetrieveBranch()
        {
            Library dpl = new Library("Denver Public Library");
            Branch parkHill = new Branch("Park Hill Library");

            dpl.AddBranch(parkHill);
            Assert.Equal(parkHill, dpl.Branches[0]);
        }

        [Fact]
        public void BranchNamesMethod()
        {
            Library dpl = new Library("Denver Public Library");
            Branch parkHill = new Branch("Park Hill Library");
            Branch branch2 = new Branch("Another Branch");

            dpl.AddBranch(parkHill);
            dpl.AddBranch(branch2);

            Assert.Equal(new List<string> { "Park Hill Library", "Another Branch" }, dpl.BranchNames());
        }

        [Fact]
        public void AllBooksMethod()
        {
            Library dpl = new Library("Denver Public Library");
            Branch parkHill = new Branch("Park Hill Library");
            Branch branch2 = new Branch("Another Branch");
            Book dune = new Book("Dune", "Frank Herbert");
            Book hobbit = new Book("The Hobbit", "JRR Tolkien");

            parkHill.AddBook(dune);
            branch2.AddBook(hobbit);
            dpl.AddBranch(parkHill);
            dpl.AddBranch(branch2);

            Assert.Equal(new List<string> { "Dune", "The Hobbit" }, dpl.AllBooks());
        }
    }
}
