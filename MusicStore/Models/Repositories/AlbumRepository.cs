using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models.Repositories
{
    public class AlbumRepository : Repository<Album>
    {

        public List<Album> getByTitle(string title)
        {
            return dbSet.Where(album => album.albumName.Contains(title)).ToList();
        }

    }
}