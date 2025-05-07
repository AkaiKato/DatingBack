using Domain.DTO;
using Domain.Models;

namespace DatingBack
{
    public class Mappings
    {
        public ReturnUser MapToReturnUser(User user)
        {
            List<ReturnTagWithOrder> personalTags = [];
            foreach (var item in user.Profile!.PersonalTags)
            {
                personalTags.Add(new ReturnTagWithOrder
                {
                    Id = item.PersonalTagId,
                    Title = item.PersonalTag?.Title ?? "",
                    Order = item.Order,
                });
            }

            List<ReturnTagWithOrder> interestTags = [];
            foreach (var item in user.Profile.Interests)
            {
                interestTags.Add(new ReturnTagWithOrder
                {
                    Id = item.InterestId,
                    Title = item.Interest?.Title ?? "",
                    Order = item.Order,
                });
            }

            List<ReturnTagWithOrder> musicanTags = [];
            foreach (var item in user.Profile.Musicans)
            {
                musicanTags.Add(new ReturnTagWithOrder
                {
                    Id = item.MusicanId,
                    Title = item.Musican?.Title ?? "",
                    Order = item.Order,
                });
            }

            List<ReturnTagWithOrder> tvMediaTags = [];
            foreach (var item in user.Profile.TVMedias)
            {
                tvMediaTags.Add(new ReturnTagWithOrder
                {
                    Id = item.TVMediasId,
                    Title = item.TVMedia?.Title ?? "",
                    Order = item.Order,
                });
            }

            List<ReturnTagWithOrder> bookTags = [];
            foreach (var item in user.Profile.Books)
            {
                bookTags.Add(new ReturnTagWithOrder
                {
                    Id = item.BookId,
                    Title = item.Book?.Title ?? "",
                    Order = item.Order,
                });
            }

            List<ReturnProfilePictures> returnProfilePictures = [];
            foreach (var item in user.Profile.ProfileMedias.OrderBy(x => x.Order))
            {
                returnProfilePictures.Add(new ReturnProfilePictures
                {
                    Id = item.Id,
                    Url = item.StrorageUrl,
                    Order = item.Order,
                });
            }

            ReturnUser returnUser = new()
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                ProfileId = user.ProfileId,
                IsConfirmed = user.Profile.IsConfirmed,
                AboutMe = user.Profile.AboutMe,
                Education = user.Profile.Education,
                Work = user.Profile.Work,
                ReturnProfilePictures = returnProfilePictures,
                ReturnDatingPurpose = new ReturnDatingPurpose
                {
                    Id = user.Profile?.DatingPurpose?.Id,
                    Title = user.Profile?.DatingPurpose?.Title,
                    Description = user.Profile?.DatingPurpose?.Description,
                },
                PersonalTag = personalTags,
                InterestTag = interestTags,
                MusicanTag = musicanTags,
                TVMediaTag = tvMediaTags,
                BookTag = bookTags,
            };

            return returnUser;
        }

        public List<ReturnUser> MapToListReturnUser(List<User> users)
        {
            List<ReturnUser> returnUsers = [];

            foreach (var user in users)
            {
                List<ReturnTagWithOrder> personalTags = [];
                foreach (var item in user.Profile!.PersonalTags)
                {
                    personalTags.Add(new ReturnTagWithOrder
                    {
                        Id = item.PersonalTagId,
                        Title = item.PersonalTag?.Title ?? "",
                        Order = item.Order,
                    });
                }

                List<ReturnTagWithOrder> interestTags = [];
                foreach (var item in user.Profile.Interests)
                {
                    interestTags.Add(new ReturnTagWithOrder
                    {
                        Id = item.InterestId,
                        Title = item.Interest?.Title ?? "",
                        Order = item.Order,
                    });
                }

                List<ReturnTagWithOrder> musicanTags = [];
                foreach (var item in user.Profile.Musicans)
                {
                    musicanTags.Add(new ReturnTagWithOrder
                    {
                        Id = item.MusicanId,
                        Title = item.Musican?.Title ?? "",
                        Order = item.Order,
                    });
                }

                List<ReturnTagWithOrder> tvMediaTags = [];
                foreach (var item in user.Profile.TVMedias)
                {
                    tvMediaTags.Add(new ReturnTagWithOrder
                    {
                        Id = item.TVMediasId,
                        Title = item.TVMedia?.Title ?? "",
                        Order = item.Order,
                    });
                }

                List<ReturnTagWithOrder> bookTags = [];
                foreach (var item in user.Profile.Books)
                {
                    bookTags.Add(new ReturnTagWithOrder
                    {
                        Id = item.BookId,
                        Title = item.Book?.Title ?? "",
                        Order = item.Order,
                    });
                }

                List<ReturnProfilePictures> returnProfilePictures = [];
                foreach (var item in user.Profile.ProfileMedias.OrderBy(x => x.Order))
                {
                    returnProfilePictures.Add(new ReturnProfilePictures
                    {
                        Id = item.Id,
                        Url = item.StrorageUrl,
                        Order = item.Order,
                    });
                }

                ReturnUser returnUser = new()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    ProfileId = user.ProfileId,
                    IsConfirmed = user.Profile.IsConfirmed,
                    AboutMe = user.Profile.AboutMe,
                    Education = user.Profile.Education,
                    Work = user.Profile.Work,
                    ReturnProfilePictures = returnProfilePictures,
                    ReturnDatingPurpose = new ReturnDatingPurpose
                    {
                        Id = user.Profile?.DatingPurpose?.Id,
                        Title = user.Profile?.DatingPurpose?.Title,
                        Description = user.Profile?.DatingPurpose?.Description,
                    },
                    PersonalTag = personalTags,
                    InterestTag = interestTags,
                    MusicanTag = musicanTags,
                    TVMediaTag = tvMediaTags,
                    BookTag = bookTags,
                };

                returnUsers.Add(returnUser);
            }

            return returnUsers;
        }
    }
}
