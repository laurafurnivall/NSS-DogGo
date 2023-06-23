using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkRepository
    {
        List<Walks> GetAllWalks(); 
        List<Walks> GetWalksByWalkerId(int walkerId);
    }
}
