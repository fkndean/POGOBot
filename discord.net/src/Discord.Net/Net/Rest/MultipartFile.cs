﻿using System.IO;

namespace Discord.Net.Rest
{
    struct MultipartFile
    {
        public Stream Stream { get; }
        public string Filename { get; }

        public MultipartFile(Stream stream, string filename)
        {
            Stream = stream;
            Filename = filename;
        }
    }
}
