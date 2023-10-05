using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BirdCalls.MVVM.Models
{

 
    public class BirdSong
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Sound { get; set; }
    }

    [JsonSerializable(typeof(List<BirdSong>))]
    internal sealed partial class BirdSongContext : JsonSerializerContext
    {

    }

}
