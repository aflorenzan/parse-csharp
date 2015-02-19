//
// FileUtilities.cs
//
// Author:
//       Alberto Estrella <alberto.estrella@maven.do>
//
// Copyright (c) 2014 2014
using System;

namespace Parse.Api.Utilities
{
    public static class FileUtilities
    {
        public static string GetFileExtension(string filename)
        {
            var parts = filename.Split('.');

            return parts[parts.Length - 1].Trim().ToLower();
        }


        // http://www.iana.org/assignments/media-types
        // http://webdesign.about.com/od/sound/a/sound_mime_type.htm
        public static string GetContentTypeFromFilenameExtension(string filename)
        {
            switch (GetFileExtension(filename))
            {
                case ".txt":
                    return "text/plain";
                case ".csv":
                    return "text/csv";
                case ".pdf":
                    return "application/pdf";
                case ".xml":
                    return "text/xml";

                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";

                case ".mp3":
                    return "audio/mpeg";
                case ".wav":
                    return "audio/wav";

                default:
                    return "application/octet-stream";
            }
        }
    }
}

