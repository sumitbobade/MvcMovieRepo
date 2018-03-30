using MvcMovie.Controllers;
using Xunit;

namespace XUnitTestingMovie
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MoviesController movie = new MoviesController();
            string result = movie.GetMovieName(1);
            Assert.Equal("Ghost", result);
        }
    }
}
