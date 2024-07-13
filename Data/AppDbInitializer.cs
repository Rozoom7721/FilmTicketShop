using FilmTicketShop.Data.Enums;
using FilmTicketShop.Data.Static;
using FilmTicketShop.Models;
using Microsoft.AspNetCore.Identity;
using System.Xml.Schema;

namespace FilmTicketShop.Data
{
	public class AppDbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

				context.Database.EnsureCreated();

				//Cinema
				if (!context.Cinemas.Any())
				{
					context.Cinemas.AddRange(new List<Cinema>()
					{
						new Cinema()
						{
							Name = "Kino 1",
							LogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Cinema_City.svg/1200px-Cinema_City.svg.png",
							Description = "Opis 1 kina"
						},
						new Cinema()
						{
							Name = "Kino 2",
							LogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Kino_Indonesia_logo.svg/2560px-Kino_Indonesia_logo.svg.png",
							Description = "Opis 2 kina"
                        },
						new Cinema()
						{
							Name = "Kino 3",
							LogoURL = "https://st3.depositphotos.com/1588812/13325/v/450/depositphotos_133255394-stock-illustration-vector-logo-cinema.jpg",
							Description = "Opis 3 kina"
                        },
						new Cinema()
						{
							Name = "Kino 4",
							LogoURL = "https://galeriasanowa.pl/wp-content/uploads/2020/03/51645236-1884902444947672-5702830908176859136-n.png",
							Description = "Opis 4 kina"
                        },
						new Cinema()
						{
							Name = "Kino 5",
							LogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7b/Ale_Kino%21_2006_-_Logo.svg/2560px-Ale_Kino%21_2006_-_Logo.svg.png",
							Description = "Opis 5 kina"
                        },
					});
					context.SaveChanges();
				}
				//Actor
				if (!context.Actors.Any())
				{
					context.Actors.AddRange(new List<Actor>()
					{
						new Actor()
						{
							FullName = "Aktor 1",
							Bio = "To jest biografia 1 aktora",
							ProfilePictureURL = "https://fwcdn.pl/ppo/00/15/15/449990.2.jpg"

                        },
						new Actor()
						{
							FullName = "Aktor 2",
							Bio = "To jest biografia 2 aktora",
							ProfilePictureURL = "https://fwcdn.pl/ppo/28/46/2846/452237.2.jpg"
                        },
						new Actor()
						{
							FullName = "Aktor 3",
							Bio = "To jest biografia 3 aktora",
							ProfilePictureURL = "https://fwcdn.pl/ppo/18/47/2271847/393355.1.jpg"
                        },
						new Actor()
						{
							FullName = "Aktor 4",
							Bio = "To jest biografia 4 aktora",
							ProfilePictureURL = "https://fwcdn.pl/ppo/97/97/99797/449885.2.jpg"
                        },
						new Actor()
						{
							FullName = "Aktor 5",
							Bio = "To jest biografia 5 aktora",
							ProfilePictureURL = "https://fwcdn.pl/ppo/78/41/7841/457270.2.jpg"
                        }
					});
					context.SaveChanges();
				}
				//Producer
				if (!context.Producers.Any())
				{
					context.Producers.AddRange(new List<Producer>()
					{
						new Producer()
						{
							FullName = "Reżyser 1",
							Bio = "Biografia 1 reżysera",
							ProfilePictureURL = "https://fwcdn.pl/ppo/01/11/111/449997.2.jpg"

                        },
						new Producer()
						{
							FullName = "Reżyser 2",
							Bio = "Biografia 2 reżysera",
							ProfilePictureURL = "https://fwcdn.pl/ppo/00/62/62/452006.2.jpg"
                        },
						new Producer()
						{
							FullName = "Reżyser 3",
							Bio = "Biografia 3 reżysera",
							ProfilePictureURL = "https://fwcdn.pl/ppo/03/39/339/450701.2.jpg"
                        },
						new Producer()
						{
							FullName = "Reżyser 4",
							Bio = "Biografia 4 reżysera",
							ProfilePictureURL = "https://fwcdn.pl/ppo/51/64/55164/467574.2.jpg"
                        },
						new Producer()
						{
							FullName = "Reżyser 5",
							Bio = "Biografia 5 reżysera",
							ProfilePictureURL = "https://fwcdn.pl/ppo/00/96/96/450689.2.jpg"
                        }
					});
					context.SaveChanges();
				}
				//Movie
				if (!context.Movies.Any())
				{
					context.Movies.AddRange(new List<Movie>()
					{
						new Movie()
						{
							Title = "MÓW DO MNIE!",
							Description = "To jest opis filmu",
							Price = 39.50,
							ImageURL = "https://fwcdn.pl/fpo/66/57/10026657/8074603.6.jpg",
							StartDate = DateTime.Now.AddDays(-10),
							EndDate = DateTime.Now.AddDays(10),
							CinemaId = 3,
							ProducerId = 3,
							MovieCategory = MovieCategory.Documentary
						},
						new Movie()
						{
							Title = "NIENAWISTNA ÓSEMKA",
							Description = "To jest opis filmu",
							Price = 29.50,
							ImageURL = "https://fwcdn.pl/fpo/41/92/714192/7715662_1.6.jpg",
							StartDate = DateTime.Now,
							EndDate = DateTime.Now.AddDays(3),
							CinemaId = 1,
							ProducerId = 1,
							MovieCategory = MovieCategory.Action
						},
						new Movie()
						{
							Title = "2001: ODYSEJA KOSMICZNA",
							Description = "To jest opis filmu",
							Price = 39.50,
							ImageURL = "https://fwcdn.pl/fpo/14/58/1458/7592150_1.6.jpg",
							StartDate = DateTime.Now,
							EndDate = DateTime.Now.AddDays(7),
							CinemaId = 4,
							ProducerId = 4,
							MovieCategory = MovieCategory.Horror
						},
						new Movie()
						{
							Title = "OPPENHEIMER",
							Description = "To jest opis filmu",
							Price = 39.50,
							ImageURL = "https://fwcdn.pl/fpo/28/17/10002817/8072064_2.6.jpg",
							StartDate = DateTime.Now.AddDays(-10),
							EndDate = DateTime.Now.AddDays(-5),
							CinemaId = 1,
							ProducerId = 2,
							MovieCategory = MovieCategory.Documentary
						},
						new Movie()
						{
							Title = "ANDRIEJ RUBLOW",
							Description = "To jest opis filmu",
							Price = 39.50,
							ImageURL = "https://fwcdn.pl/fpo/21/42/32142/8028569_1.6.jpg",
							StartDate = DateTime.Now.AddDays(-10),
							EndDate = DateTime.Now.AddDays(-2),
							CinemaId = 1,
							ProducerId = 3,
							MovieCategory = MovieCategory.Cartoon
						},
						new Movie()
						{
							Title = "HOUSE OF CARDS",
							Description = "To jest opis filmu(Tak to jest serial)",
							Price = 39.50,
							ImageURL = "https://fwcdn.pl/fpo/00/36/620036/7855884_1.6.jpg",
							StartDate = DateTime.Now.AddDays(3),
							EndDate = DateTime.Now.AddDays(20),
							CinemaId = 1,
							ProducerId = 5,
							MovieCategory = MovieCategory.Drama
						}
					});
					context.SaveChanges();
				}
				//Actor & Movies
				if (!context.Actors_Movies.Any())
				{
					context.Actors_Movies.AddRange(new List<Actor_Movie>()
					{
						new Actor_Movie()
						{
							ActorId = 1,
							MovieId = 1
						},
						new Actor_Movie()
						{
							ActorId = 3,
							MovieId = 1
						},

						 new Actor_Movie()
						{
							ActorId = 1,
							MovieId = 2
						},
						 new Actor_Movie()
						{
							ActorId = 4,
							MovieId = 2
						},

						new Actor_Movie()
						{
							ActorId = 1,
							MovieId = 3
						},
						new Actor_Movie()
						{
							ActorId = 2,
							MovieId = 3
						},
						new Actor_Movie()
						{
							ActorId = 5,
							MovieId = 3
						},


						new Actor_Movie()
						{
							ActorId = 2,
							MovieId = 4
						},
						new Actor_Movie()
						{
							ActorId = 3,
							MovieId = 4
						},
						new Actor_Movie()
						{
							ActorId = 4,
							MovieId = 4
						},


						new Actor_Movie()
						{
							ActorId = 2,
							MovieId = 5
						},
						new Actor_Movie()
						{
							ActorId = 3,
							MovieId = 5
						},
						new Actor_Movie()
						{
							ActorId = 4,
							MovieId = 5
						},
						new Actor_Movie()
						{
							ActorId = 5,
							MovieId = 5
						},


						new Actor_Movie()
						{
							ActorId = 3,
							MovieId = 6
						},
						new Actor_Movie()
						{
							ActorId = 4,
							MovieId = 6
						},
						new Actor_Movie()
						{
							ActorId = 5,
							MovieId = 6
						},
					});
					context.SaveChanges();
				}
			}
		}

		public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var roleMenager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

				if(!await roleMenager.RoleExistsAsync(UserRoles.Admin))
					await roleMenager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleMenager.RoleExistsAsync(UserRoles.User))
                    await roleMenager.CreateAsync(new IdentityRole(UserRoles.User));

                var userMenager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				string adminUserEmail = "admin@admin.pl";

                var adminUser = await userMenager.FindByEmailAsync(adminUserEmail);
				if (adminUser == null)
				{
					var newAdminUser = new ApplicationUser()
					{
						FullName = "Admin Admin",
						UserName = "admin",
						Email = adminUserEmail,  
						EmailConfirmed = true
					};
					await userMenager.CreateAsync(newAdminUser, "@Admin123");
					await userMenager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
				}
                string UserEmail = "user@user.pl";

                var User = await userMenager.FindByEmailAsync(UserEmail);
                if (User == null)
                {
                    var newUser = new ApplicationUser()
                    {
                        FullName = "User User",
                        UserName = "user",
                        Email = UserEmail,
                        EmailConfirmed = true
                    };
                    await userMenager.CreateAsync(newUser, "@User12345");
                    await userMenager.AddToRoleAsync(newUser, UserRoles.User);
                }
            }
		}
	}
}
