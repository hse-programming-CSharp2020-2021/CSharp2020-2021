using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class VideoFile
    {
        string _name;
        int _duration;
        int _quality;

        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }

        public int Size
        {
            get
            {
                return _duration * _quality;
            }
        }

        public override string ToString()
        {
            return $"Name = {_name}, Duration = {_duration}, Quality = {_quality}, Size = {Size}";
        }

    }
}
