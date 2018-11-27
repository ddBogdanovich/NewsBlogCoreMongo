using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NewsBlogCoreMongo.Models;

namespace MongoBlog.Automapper
{
    public class AutomapperProfile : Profile
    {
        
        public AutomapperProfile(IConfiguration configuration, IHostingEnvironment env)
        {

            
            //var _blankImage = configuration.GetSection("BlankImageName").Value;
           // var _uploadsFolder = configuration.GetSection("UploadsFolder").Value;

/*            CreateMap<NewsItem, NewsItemViewModel>()
                .ForMember(
                  dest => dest.newsItem,
                  opt => opt.MapFrom(src => src)
                ).ForMember(
                    dest => dest.uploadsFolder
                    );*/


        }
    }
}