using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MusicHub
{
    using System;

    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            //Test your solutions here

            Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albumsInfo = context
                .Producers.First(p => p.Id == producerId)
                .Albums.Select(a => new
                    {
                        AlbumName = a.Name,
                        ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
                        ProducerName = a.Producer.Name,
                        Songs = a.Songs.Select(s => new
                        {
                            SongName = s.Name,
                            SongPrice = s.Price,
                            SongWriterName = s.Writer.Name
                        })
                            .OrderByDescending(s=>s.SongName)
                            .ThenBy(s=>s.SongWriterName),
                        AlbumPrice = a.Price
                    })
                .OrderByDescending(a=>a.AlbumPrice).ToArray();


            StringBuilder sb = new StringBuilder();
            foreach (var album in albumsInfo)
            {
                sb.AppendLine($"-AlbumName: {album.AlbumName}");
                sb.AppendLine($"-ReleaseDate: {album.ReleaseDate}");
                sb.AppendLine($"-ProducerName: {album.ProducerName}");
                sb.AppendLine($"-Songs:");
                
                int counter = 1;

                if (album.Songs.Any())
                {
                    foreach (var song in album.Songs)
                    {
                        sb.AppendLine($"---#{counter}");
                        sb.AppendLine($"---SongName: {song.SongName}");
                        sb.AppendLine($"---Price: {song.SongPrice:f2}");
                        sb.AppendLine($"---Writer: {song.SongWriterName}");
                        counter++;
                    }
                }

                sb.AppendLine($"-AlbumPrice: {album.AlbumPrice:f2}");
            }

            return sb.ToString().TrimEnd() ;
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songs = context.Songs
                .AsEnumerable()
                .Where(s => s.Duration.TotalSeconds > duration)
                .Select(s => new
                {
                    SongName = s.Name,
                    PeformersNames = s.SongPerformers
                        .Select(sp => $"{sp.Performer.FirstName} {sp.Performer.LastName}")
                        .OrderBy(n=>n).ToList(),
                    WriterName = s.Writer.Name,
                    AlbumProducerName = s.Album.Producer.Name,
                    Duration = s.Duration.ToString("c")
                })
                .OrderBy(s => s.SongName)
                .ThenBy(s => s.WriterName)
                .ToList();

            StringBuilder sb = new StringBuilder();
            int counter = 1;

            foreach (var song in songs)
            {
                sb.AppendLine($"-Song #{counter++}");
                sb.AppendLine($"---SongName: {song.SongName}");
                sb.AppendLine($"---Writer: {song.WriterName}");

                if (song.PeformersNames.Any())
                {
                    foreach (var performer in song.PeformersNames)
                    {
                        sb.AppendLine($"---Performer: {performer}");
                    }
                }
                sb.AppendLine($"---AlbumProducer: {song.AlbumProducerName}");
                sb.AppendLine($"---Duration: {song.Duration}");
            }
            return sb.ToString().TrimEnd() ;
        }
    }
}
