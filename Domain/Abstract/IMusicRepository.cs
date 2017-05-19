using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Domain.Entities;

namespace Domain.Abstract
{
    public interface IMusicRepository
    {
        IEnumerable<Music> Musics { get; }
        void Save(Music file);
        Music Get(int id);
    }
}