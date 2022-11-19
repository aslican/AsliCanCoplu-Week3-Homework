using Microsoft.AspNetCore.Mvc;
using RepositoryPatternHW.Domain.Entities;
using RepositoryPatternHW.ServiceLayer.Abstracts;
using RepositoryPatternHW.ServiceLayer.DTOs;

namespace RepositoryPatternHW.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimationMovieController : ControllerBase
    {
        private readonly IAnimationService animationService;

        public AnimationMovieController(IAnimationService animationService)
        {
            this.animationService = animationService;
        }
        [HttpPost] 
        
        public IActionResult Post(AnimationDto animationmovies) {
            var animationDto = new AnimationMovie
            {
                Name = "Toy story",
                Director="Dou",
                IsCanceled=false,
                ReleaseDate=DateTime.Now,
                Studios = animationmovies.Studios,
                Writer = animationmovies.Writer,
                BoxOffice = animationmovies.BoxOffice,
                Stars = animationmovies.Stars,

            };
            animationService.Add(animationDto);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var film=animationService.Get(id);
            return Ok(film);
        }
        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var film = animationService.GetAll();
            return Ok(film);
        }
        [HttpDelete]

        public IActionResult DeleteMovies([FromBody]AnimationMovie movie)
        {

            animationService.Delete(movie);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMovies([FromBody]AnimationMovie movie)
        {
            animationService.Update(movie);
            return Ok();
        }
    }
}
