using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Iris.Messaging.Cache
{
    public class ImageHandle : IResourceHandle
    {
        protected string Path { get; set; }

        public ImageHandle(string path)
        {
            Path = path;
        }
    }
}
