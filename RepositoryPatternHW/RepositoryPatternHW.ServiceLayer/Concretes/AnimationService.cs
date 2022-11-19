using RepositoryPatternHW.DataLayer.Abstracts;

using RepositoryPatternHW.Domain.Entities;
using RepositoryPatternHW.ServiceLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternHW.ServiceLayer.Concretes
{
    public class AnimationService : IAnimationService
    {
        private readonly IRepository<AnimationMovie> _animationRepository;

        public AnimationService(IRepository<AnimationMovie> animationRepository)
        {
            _animationRepository = animationRepository;
        }

        public void Add(AnimationMovie movie)
        {
            _animationRepository.Add(movie);    
        }

        public void Delete(AnimationMovie movie)
        {
            _animationRepository.Delete(movie);
        }



        public AnimationMovie Get(int id)
        {
            return _animationRepository.Get(p => p.Id == id);
        }

        public IEnumerable<AnimationMovie> GetAll()
        {
            return _animationRepository.GetAll();
        }

        public void Update(AnimationMovie movie)
        {
            _animationRepository.Update(movie);
        }
    }
}
