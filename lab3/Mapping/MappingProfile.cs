using AutoMapper;
using Lab3.Models;
using Lab3.ViewModels;
namespace Lab3.Mapping
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Movie, MovieViewModel>().ReverseMap();
      CreateMap<Comment, CommentViewModel>().ReverseMap();
      CreateMap<Movie, MovieWithCommentsViewModel>();
    }
  }
}
