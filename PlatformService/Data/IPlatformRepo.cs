using PlatformService.Models;
using System;
using System.Collections.Generic;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(Guid id);
        void CreatePlatform(Platform plat);
    }
}
