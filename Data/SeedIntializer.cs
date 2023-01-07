using DecaPlayStore.Core.Domains;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace DecaPlayStore.Data
{
    public class SeedIntializer
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //AppDBfile is the file that we use to send or get data from the database
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                //to check if the database exist
                context.Database.EnsureCreated();

                //Artist
                //seeding the artist table with data
                //First we check if there are artist data available in the database before we start adding
                if (!context.Artist.Any())
                {
                    var artists = new List<Artist>
                    //context.Artist.AddRange(
                    //   artist
                    {
                        new Artist()
                        {
                            Name = "BurnaBoy",
                            Country = "Nigeria"
                        },
                          new Artist()
                        {
                            Name = "Majek Fashek",
                            Country = "Nigeria"
                        },
                           new Artist()
                        {
                            Name = "King Saheed Osupa",
                            Country = "Nigeria"
                        },
                        new Artist()
                        {
                            Name = "Kizz Daniel",
                            Country = "Nigeria"
                        },
                         new Artist()
                        {
                            Name = "Asake",
                            Country = "Nigeria"
                        },
                          
                           new Artist()
                        {
                            Name = "CaveMen",
                            Country = "Nigeria"
                        },
                            new Artist()
                        {
                            Name = "Davido",
                            Country = "Nigeria"
                        },
                             new Artist()
                        {
                            Name = "Olamide",
                            Country = "Nigeria"
                        },
                              new Artist()
                        {
                            Name = "WizKid",
                            Country = "Nigeria"
                        },
                               new Artist()
                        {
                            Name = "Apocalyptica",
                            Country = "Nigeria"
                        },
                                new Artist()
                        {
                            Name = "Ebenezer Obey",
                            Country = "Nigeria"
                        },
                                 new Artist()
                        {
                            Name = "Phyno",
                            Country = "Nigeria"
                        },
                               new Artist()
                        {
                            Name = "Femi Kuti",
                            Country = "Nigeria"
                        },
                                 new Artist()
                        {
                            Name = "Dunsin Oyekan",
                            Country = "Nigeria"
                        },
                            new Artist()
                        {
                            Name = "Darey Art Alade",
                            Country = "Nigeria"
                        },
                             new Artist()
                        {
                            Name = "Rex Lawson",
                            Country = "Nigeria"
                        },

                                  new Artist()
                        {
                            Name = "Chief Osita Osadebe",
                            Country = "Nigeria"
                        }
                    };
                    //context.SaveChanges();
                    //Genre
                    if (!context.Genres.Any())
                    {
                        var genres = new List<Genre>
                    //context.AddRange(new List<Genre>
                    {
                        new Genre()
                        {
                            Name = "AfroBeat",
                            Description = "A style of popular music incorporating elements of " +
                            "African music and jazz, soul, and funk",

                        },
                         new Genre()
                        {
                            Name = "Jazz",
                            Description = "A type of modern music originally developed by African-Americans, with a rhythm in which the strong notes often come before the beat." +
                            " Jazz is usually improvised (= invented as it is played).",

                        },
                          new Genre()
                        {
                            Name = "Gospel",
                            Description = "A style religious songs sung by " +
                            "the Caucasian and the African-American Christians",

                        },
                            new Genre()
                        {
                            Name = "Juju",
                            Description = "A style of Nigerian popular music," +
                            " derived from traditional Yoruba percussion",

                        },
                             new Genre()
                        {
                            Name = "HipHop",
                            Description = "A music genre developed in the United States by " +
                            "inner-city African Americans in the 1970s ",

                        },
                              new Genre()
                        {
                            Name = "Blues",
                            Description = "The genre Blues is a combination of African and American styles of music that has traversed a very wide range of" +
                            " human emotions and popular musical styles",

                        },
                               new Genre()
                        {
                            Name = "Fuji",
                            Description = "A genre of music performed to wake Muslims before dawn during " +
                            "the Ramadan fasting season",

                        },
                                new Genre()
                        {
                            Name = "Reggae",
                            Description = "Reggae is a musical genre developed by " +
                            "Jamaicans of African ancestry in the late 1960s",

                        },
                                  new Genre()
                        {
                            Name = "Classical",
                            Description = "The term “classical music” is commonly used when referring to formal Western music, setting it apart" +
                            " from Western popular or folk music",

                        },
                                    new Genre()
                        {
                            Name = "HighLife",
                            Description = "Highlife is a West African music genre played on instruments from Europe and the United States. It borrows from the Akan and Kpanlogo" +
                            " musical traditions of Ghana and Nigeria",

                        },

                    };
                        //context.SaveChanges();
                        //Album
                        if (!context.Albums.Any())
                        {
                            new List<Album>
                        {
                new Album() { Title = "Love Damini", Genre = genres.Single(g => g.Name == "AfroBeat"), Price = 12.99M, Artist = artists.Single(a => a.Name == "BurnaBoy"), AlbumArtUrl = "/Content/Images/LoveDamini.gif" },
                new Album() { Title = "Mr. Money with the Vibe", Genre = genres.Single(g => g.Name == "AfroBeat"), Price = 10.99M, Artist = artists.Single(a => a.Name == "Asake"), AlbumArtUrl = "/Content/Images/MoneywiththeVibe.gif" },
                new Album() { Title = "2022 Album EP", Genre = genres.Single(g => g.Name == "AfroBeat"), Price = 11.99M, Artist = artists.Single(a => a.Name == "Kizz Daniel"), AlbumArtUrl = "/Content/Images/Buga.gif" },
                new Album() { Title = "A Good Time", Genre = genres.Single(g => g.Name == "AfroBeat"), Price = 10M, Artist = artists.Single(a => a.Name == "Davido"), AlbumArtUrl = "/Content/Images/GoodTime.gif" },
                new Album() { Title = "African Giant", Genre = genres.Single(g => g.Name == "AfroBeat"), Price = 9.99M, Artist = artists.Single(a => a.Name == "BurnaBoy"), AlbumArtUrl = "/Content/Images/AfricanGiant.gif" },
                new Album() { Title = "More Love, Less Ego", Genre = genres.Single(g => g.Name == "AfroBeat"), Price = 13.99M, Artist = artists.Single(a => a.Name == "WizKid"), AlbumArtUrl = "/Content/Images/LessEgo.gif" },
                new Album() { Title = "Kedu America", Genre = genres.Single(g => g.Name == "HighLife"), Price = 7.99M, Artist = artists.Single(a => a.Name == "Chief Osita Osadebe"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album() { Title = "Love and Highlife", Genre = genres.Single(g => g.Name == "HighLife"), Price = 15.99M, Artist = artists.Single(a => a.Name == "CaveMen"), AlbumArtUrl = "/Content/Images/Love_Highlife.gif" },
                new Album() { Title = "Roots", Genre = genres.Single(g => g.Name == "HighLife"), Price = 12.99M, Artist = artists.Single(a => a.Name == "CaveMen"), AlbumArtUrl = "/Content/Images/Root.gif" },
                new Album() { Title = "UY Scuti", Genre = genres.Single(g => g.Name == "HipHop"), Price = 6.99M, Artist = artists.Single(a => a.Name == "Olamide"), AlbumArtUrl = "/Content/Images/UY_Scuti.gif" },
                new Album() { Title = "Lagos Nawa", Genre = genres.Single(g => g.Name == "HipHop"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Olamide"), AlbumArtUrl = "/Content/Images/Lagos_Nawa.gif" },
                new Album() { Title = "Something To Live For", Genre = genres.Single(g => g.Name == "HipHop"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Phyno"), AlbumArtUrl = "/Content/Images/Something_To_Live_For.gif" },
                new Album() { Title = "Deal With it", Genre = genres.Single(g => g.Name == "HipHop"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Phyno"), AlbumArtUrl = "/Content/Images/Deal_with.gif" },
                new Album() { Title = "No guts No Glory", Genre = genres.Single(g => g.Name == "HipHop"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Phyno"), AlbumArtUrl = "/Content/Images/No_guts_noGlory.gif" },
                new Album() { Title = "Ebenezer Obey in London", Genre = genres.Single(g => g.Name == "Juju"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Ebenezer Obey"), AlbumArtUrl = "/Content/Images/obey_London.gif" },
                new Album() { Title = "Juju Jubilation", Genre = genres.Single(g => g.Name == "Juju"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Apocalyptica"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album() { Title = "Rain Maker", Genre = genres.Single(g => g.Name == "Reggae"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Majek Fashek"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album() { Title = "Non Stop(Hip Fuji)", Genre = genres.Single(g => g.Name == "Fuji"), Price = 8.99M, Artist = artists.Single(a => a.Name == "King Saheed Osupa"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album() { Title = "Sawale", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Rex Lawson"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album() { Title = "Not the Girl", Genre = genres.Single(g => g.Name == "Blues"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Darey Art Alade"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album() { Title = "Always God", Genre = genres.Single(g => g.Name == "Gospel"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Dunsin Oyekan"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album() { Title = "Sorry Sorry", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Femi Kuti"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                        }.ForEach(a => context.Albums.Add(a));
                            context.SaveChanges();

                        }

                    }
                }
            }
        }
    }
}
