using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models.Repositories
{
    public class ArtistRepository : Repository<Artist>
    {

        public List<Artist> getByName(string name)
        {
            return dbSet.Where(a => a.artistName.Contains(name)).ToList();
        }

    }
}