using System.Collections.Generic;
using _26Mar_BookStore.Controllers;
using _26Mar_BookStore.Models;
using _26Mar_BookStore.Services;

namespace _26Mar_BookStore.Services
{
    public class CarouselRepository : IRepository<Carousel>
    {
        List<Carousel> _carousel;
        public CarouselRepository()
        {
            _carousel = new List<Carousel>()
            {
                new Carousel()
                {
                BookID = 1,
                Title = "The Old Man and the Sea",
                Description = "The Old Man and the Sea tells the story of a battle between an aging, experienced fisherman, Santiago, and a large marlin. The story opens with Santiago having gone 84 days without catching a fish, and now being seen as 'salao', the worst form of unluckiness.",
                Image = "theoldman.jpg"
                },
                new Carousel()
                {
                BookID = 2,
                Title = "East of Eden",
                Description = "East of Eden is a novel by Nobel Prize winner John Steinbeck, published in September 1952. Often described as Steinbeck's most ambitious novel, East of Eden brings to life the intricate details of two families, the Trasks and the Hamiltons, and their interwoven stories.",
                Image = "eastofeden.jpg"
                },
                new Carousel()
                {
                BookID = 3,
                Title = "Dune",
                Description = "A 1965 science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966, and it won the inaugural Nebula Award for Best Novel.",
                Image = "dune.jpg"
                },
            };
        }
        public bool Add(Carousel item)
        {
            throw new System.NotImplementedException();
        }

        public bool Edit(Carousel item)
        {
            throw new System.NotImplementedException();
        }

        public Carousel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Carousel> GetAll()
        {
            return _carousel;
        }

        public bool Remove(Carousel item)
        {
            throw new System.NotImplementedException();
        }
    }
}