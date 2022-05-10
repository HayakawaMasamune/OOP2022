using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args)
        {
            var songs = new Song[] {
                new Song("a","aaa",521),
                new Song("b","bbb",355),
                new Song("c","ccc",413),

            };

           PrintSongs(songs);
        }

        private static void PrintSongs(IEnumerable<Song> songs)
        {
             foreach(var song in songs){
                
                Console.WriteLine("[0],[1],[2:m\\:ss]",
                song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            
            }
        }
        private static void PrintSongs(List<Song> songs)
        {

        }
    }
}
