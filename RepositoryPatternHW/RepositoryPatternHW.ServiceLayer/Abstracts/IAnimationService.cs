using RepositoryPatternHW.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternHW.ServiceLayer.Abstracts
{
    public interface IAnimationService
    {
        IEnumerable<AnimationMovie> GetAll();
        void Add(AnimationMovie movie);
        void Delete(AnimationMovie movie);
        void Update(AnimationMovie movie);  
        AnimationMovie Get(int id);
    }
}
