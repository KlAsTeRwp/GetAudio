using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstract;
using Domain.Concrete;
using Domain.Entities;

namespace Domain.Concrete
{
    public class EFMusicRepository : IMusicRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Music> Musics { get => context.Musics; }

        public Music Get(int id)
        {
            return context.Musics.FirstOrDefault(x => x.MusicID == id);
        }

        public void Save(Music file)
        {
            if (file != null)
            {
                if (file.MusicID == 0)
                {
                    context.Musics.Add(file);
                    context.SaveChanges();
                }
                else
                {
                    Music dbEntry = context.Musics.FirstOrDefault(x => x.MusicID == file.MusicID);
                    if (dbEntry != null)
                    {
                        dbEntry = file;
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
