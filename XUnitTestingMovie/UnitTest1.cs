using Moq;
using MvcMovie.Controllers;
using MvcMovie.Models;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestingMovie
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mokService = new Mock<MvcMovieContext>();
            MoviesController movieC = new MoviesController();
            Movie movie = movieC.GetMovie(1);
            mokService.Setup(cr => cr.Add(movie));
            
            string result = movieC.GetMovieName(1);
            Assert.Equal("Ghost", result);
        }
    }
}
