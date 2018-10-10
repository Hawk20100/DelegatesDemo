﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class PhotoProcessor
    {

        
        public void Process(string path, Action<Photo> filterHandler)
        {
            //System.Action<>
            //System.Func<>


            var photo = Photo.Load(path);

            var filters = new PhotoFilters();

            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            filterHandler(photo);

            photo.Save();
        }
    }
}
