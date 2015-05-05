using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer : DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.AddOrUpdate(new Artist { Name = "Jimi Hendrix" });
            context.Genres.AddOrUpdate(new Genre { Name = "Jazz" });
            context.Albums.AddOrUpdate(new Album
                {
                    Artist = new Artist {  Name = "Rush"},
                    Genre = new Genre { Name = "Jazz"},
                    Price = 9.99m,
                    Title = "Caravan"
                });
            base.Seed(context);
        }
    }
}