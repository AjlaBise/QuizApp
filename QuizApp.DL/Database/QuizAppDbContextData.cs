using Microsoft.EntityFrameworkCore;
using QuizApp.DL.Domain;
using System;

namespace QuizApp.DL.Database
{
    public partial class QuizAppDbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            #region Add User

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = new Guid("664D038A-90B0-4C88-BAAF-8DA05B9AB304"),
                    Nickname = "AjlaBise",
                    TotalPoints = 150
                },
                new User
                {
                    Id = new Guid("548FC16C-36F3-472B-997A-6C4A75F9C9F3"),
                    Nickname = "GargEvil",
                    TotalPoints = 150
                }
                );
            #endregion

            #region Add Category

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = new Guid("0022EDE5-F8F5-4DE3-9DB0-7742F9C9B933"),
                    Name = "Animal"
                },
                new Category
                {
                    Id = new Guid("E7776350-4164-4176-9A87-15A32990EF66"),
                    Name = "Geography"
                },
                new Category
                {
                    Id = new Guid("A8499F2F-A23D-428D-9369-8F8B7E2B4085"),
                    Name = "Sport"
                },
                new Category
                {
                    Id = new Guid("271DF7C1-6B22-416E-95B1-8DEE7E27486D"),
                    Name = "Music"
                }
                );
            #endregion

            #region Add Questions

            modelBuilder.Entity<Questions>().HasData(
              new Questions
              {
                  Id = new Guid("6CF76C06-901D-40B2-8BA7-7D12506A4FAA"),
                  Text = "How long is an elephant pregnant before it gives birth?",
                  CategoryId = new Guid("0022EDE5-F8F5-4DE3-9DB0-7742F9C9B933")
              },
              new Questions
              {
                  Id = new Guid("E42B3DD0-336F-45CC-AC48-78C6A4775717"),
                  Text = "How far away can a wolf smell its prey?",
                  CategoryId = new Guid("0022EDE5-F8F5-4DE3-9DB0-7742F9C9B933")
              },
              new Questions
              {
                  Id = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                  Text = "Which animal is known to spend 90% of its day, sleeping?",
                  CategoryId = new Guid("0022EDE5-F8F5-4DE3-9DB0-7742F9C9B933")
              },
              new Questions
              {
                  Id = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                  Text = "What color is the tongue of a giraffe?",
                  CategoryId = new Guid("0022EDE5-F8F5-4DE3-9DB0-7742F9C9B933")
              },
              new Questions
              {
                  Id = new Guid("E2781583-3F26-4B18-8AAF-D05712F1908B"),
                  Text = "Which animal’s stripes are on their skin as well as their fur?",
                  CategoryId = new Guid("0022EDE5-F8F5-4DE3-9DB0-7742F9C9B933")
              },
              new Questions
              {
                  Id = new Guid("DAF9B9B0-3C6B-4D56-BC33-C20942CB4A6C"),
                  Text = "Under their white fur, what color is a polar bear’s skin?",
                  CategoryId = new Guid("0022EDE5-F8F5-4DE3-9DB0-7742F9C9B933")
              },
              new Questions
              {
                  Id = new Guid("F9D06EAF-7B41-4311-9379-93BEA7182020"),
                  Text = "What country has the longest coastline in the world?",
                  CategoryId = new Guid("E7776350-4164-4176-9A87-15A32990EF66")
              },
              new Questions
              {
                  Id = new Guid("59D2ECB5-C6C5-4C3E-B61E-D678B539A8CF"),
                  Text = "What is the capital of Malta?",
                  CategoryId = new Guid("E7776350-4164-4176-9A87-15A32990EF66")
              },
              new Questions
              {
                  Id = new Guid("DAA576A4-92EB-4CE4-BDFD-504F5BFE7380"),
                  Text = "What is the oldest recorded town in the UK?",
                  CategoryId = new Guid("E7776350-4164-4176-9A87-15A32990EF66")
              },
              new Questions
              {
                  Id = new Guid("B52861A8-E60D-49A2-9418-CECEC0E3A970"),
                  Text = "What is the capital of Peru?",
                  CategoryId = new Guid("E7776350-4164-4176-9A87-15A32990EF66")
              },
              new Questions
              {
                  Id = new Guid("5E924EA5-B8EC-4535-9ED3-5B406858D38E"),
                  Text = "What’s the diameter of a basketball hoop in inches ?",
                  CategoryId = new Guid("A8499F2F-A23D-428D-9369-8F8B7E2B4085")
              },
              new Questions
              {
                  Id = new Guid("DE3604BD-1772-42D4-9402-916DE833A2E8"),
                  Text = "The Olympics are held every how many years?",
                  CategoryId = new Guid("A8499F2F-A23D-428D-9369-8F8B7E2B4085")
              },
              new Questions
              {
                  Id = new Guid("CD326D42-4103-47A7-961E-CAF053C557D9"),
                  Text = "What sport is best known as the ‘king of sports’?",
                  CategoryId = new Guid("A8499F2F-A23D-428D-9369-8F8B7E2B4085")
              },
              new Questions
              {
                  Id = new Guid("8D656CE5-3778-47F1-91F6-FF725A0FBDF5"),
                  Text = "What’s the national sport of Canada?",
                  CategoryId = new Guid("A8499F2F-A23D-428D-9369-8F8B7E2B4085")
              },
              new Questions
              {
                  Id = new Guid("D91D40E7-F2A1-48DD-9311-A99BA45DA8FA"),
                  Text = "How long is a marathon?",
                  CategoryId = new Guid("A8499F2F-A23D-428D-9369-8F8B7E2B4085")
              }
              );

            #endregion

            #region Add Answers
            modelBuilder.Entity<Answers>().HasData(
                new Answers
                {
                    Id = new Guid("6E6E2EF9-22D6-4E0D-BBE7-8F430B700307"),
                    Text = "22 Months",
                    QuestionId = new Guid("6CF76C06-901D-40B2-8BA7-7D12506A4FAA"),
                    Correct = true
                },
                new Answers
                {
                    Id = new Guid("E4570234-10EA-4698-85D8-9A58923A42A8"),
                    Text = "28 Months",
                    QuestionId = new Guid("6CF76C06-901D-40B2-8BA7-7D12506A4FAA"),
                    Correct = false
                },
                new Answers
                {
                    Id = new Guid("5C7D1550-90DF-467D-BC83-26435548EEF5"),
                    Text = "18 Months",
                    QuestionId = new Guid("6CF76C06-901D-40B2-8BA7-7D12506A4FAA"),
                    Correct = false
                },
                new Answers
                {
                    Id = new Guid("28121A80-349A-45E7-B0EF-2141E3C6F0FC"),
                    Text = "20 Months",
                    QuestionId = new Guid("6CF76C06-901D-40B2-8BA7-7D12506A4FAA"),
                    Correct = false
                }, 
                new Answers
                {
                    Id = new Guid("B7544BCF-0B2C-4749-9E20-F91753CB5A7E"),
                    Text = "Almost 4 miles",
                    QuestionId = new Guid("E42B3DD0-336F-45CC-AC48-78C6A4775717"),
                    Correct = false
                },
                new Answers
                {
                    Id = new Guid("95CFDF14-0F5C-465B-ACFE-07C266CB3555"),
                    Text = "Almost 2 miles",
                    QuestionId = new Guid("E42B3DD0-336F-45CC-AC48-78C6A4775717"),
                    Correct = true
                },
                new Answers
                {
                    Id = new Guid("B8895830-C06F-4DEC-A9C2-6239B458FAD3"),
                    Text = "Almost 2.5 miles",
                    QuestionId = new Guid("E42B3DD0-336F-45CC-AC48-78C6A4775717"),
                    Correct = false
                },
                new Answers
                {
                    Id = new Guid("BB3E56C7-606F-4493-A9F5-ABE28158C57F"),
                    Text = "Almost 1.5 miles",
                    QuestionId = new Guid("E42B3DD0-336F-45CC-AC48-78C6A4775717"),
                    Correct = false
                },
                new Answers
                {
                    Id = new Guid("9EB6FCA1-25C6-4DB3-A115-495958DB7606"),
                    Text = "Koalas",
                    QuestionId = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                    Correct = true
                },
                new Answers
                {
                    Id = new Guid("E39F0E8A-0EA1-4233-B53F-3C35FF38147A"),
                    Text = "Monkey",
                    QuestionId = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("F2A4DF00-2312-4176-BEAD-2ADCA65AC1D7"),
                    Text = "Rabbit",
                    QuestionId = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("6E16D659-EF90-465B-A00E-2DFE77B21BE2"),
                    Text = "Polar bear",
                    QuestionId = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                    Text = "Purple",
                    QuestionId = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("54BF88D6-E4D6-4C4E-AB1B-5DD556E2106C"),
                    Text = "Red",
                    QuestionId = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("F2B9C2AE-F050-464F-8C44-5F7C9C099BAB"),
                    Text = "Pink",
                    QuestionId = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("CBC1B861-B393-4D5E-BEE4-E33573980F31"),
                    Text = "Gray",
                    QuestionId = new Guid("034A693C-DC37-464C-B61D-5B1A8A12AEAF"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("E2781583-3F26-4B18-8AAF-D05712F1908B"),
                    Text = "Zebra",
                    QuestionId = new Guid("E2781583-3F26-4B18-8AAF-D05712F1908B"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("326AF96B-F351-4391-9ADF-133DCB7CA6F7"),
                    Text = "Leopard",
                    QuestionId = new Guid("E2781583-3F26-4B18-8AAF-D05712F1908B"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("9F3D9790-696B-48DB-A9D6-059317B7B1EB"),
                    Text = "Ris",
                    QuestionId = new Guid("E2781583-3F26-4B18-8AAF-D05712F1908B"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("EA110683-CE09-49BB-99EE-8E5B8F902C7E"),
                    Text = "Tiger",
                    QuestionId = new Guid("E2781583-3F26-4B18-8AAF-D05712F1908B"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("D828DE8E-8A94-43F5-8E3A-E11D4211DEAE"),
                    Text = "Pink",
                    QuestionId = new Guid("DAF9B9B0-3C6B-4D56-BC33-C20942CB4A6C"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("B347D3E6-77E6-4119-A6D1-69AB7D6EE7EF"),
                    Text = "Red",
                    QuestionId = new Guid("DAF9B9B0-3C6B-4D56-BC33-C20942CB4A6C"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("5DB67F56-39C9-4F8C-8586-8DF2120CFD90"),
                    Text = "White",
                    QuestionId = new Guid("DAF9B9B0-3C6B-4D56-BC33-C20942CB4A6C"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("90590475-4043-4FCE-BA70-AC1F407641CB"),
                    Text = "Black",
                    QuestionId = new Guid("DAF9B9B0-3C6B-4D56-BC33-C20942CB4A6C"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("1FD2C378-2E77-4131-8A3B-3295D0FA774D"),
                    Text = "Canada",
                    QuestionId = new Guid("F9D06EAF-7B41-4311-9379-93BEA7182020"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("94EFF38D-BD2C-451F-86AA-B2AC271E77D2"),
                    Text = "Indonesia",
                    QuestionId = new Guid("F9D06EAF-7B41-4311-9379-93BEA7182020"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("83625F44-7F40-42D8-8505-6265C29924F9"),
                    Text = "Russia",
                    QuestionId = new Guid("F9D06EAF-7B41-4311-9379-93BEA7182020"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("4FD300CD-7570-4D29-89D5-7A4AFF69396D"),
                    Text = "Philippines",
                    QuestionId = new Guid("F9D06EAF-7B41-4311-9379-93BEA7182020"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("888FB414-3A97-4610-89AE-60E0C8C6F233"),
                    Text = "Valletta",
                    QuestionId = new Guid("59D2ECB5-C6C5-4C3E-B61E-D678B539A8CF"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("55256068-E5B0-4AC0-8A56-6C8A1A438836"),
                    Text = "Żabbar",
                    QuestionId = new Guid("59D2ECB5-C6C5-4C3E-B61E-D678B539A8CF"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("860DA71B-0441-4C48-8D4A-BA2CC98DFC18"),
                    Text = "Żebbuġ",
                    QuestionId = new Guid("59D2ECB5-C6C5-4C3E-B61E-D678B539A8CF"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("CC6D0B32-8DE9-46F5-913F-041A024A68DE"),
                    Text = "Żejtun",
                    QuestionId = new Guid("59D2ECB5-C6C5-4C3E-B61E-D678B539A8CF"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("CC28D70E-37FA-4A2B-AAF3-B38719FE7BC7"),
                    Text = "Ipswich",
                    QuestionId = new Guid("DAA576A4-92EB-4CE4-BDFD-504F5BFE7380"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("8FAF203A-DE45-4193-9376-3432E4194332"),
                    Text = "Carmarthen",
                    QuestionId = new Guid("DAA576A4-92EB-4CE4-BDFD-504F5BFE7380"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("965B9CBE-414A-4B4A-928F-95C967342259"),
                    Text = "Colchester",
                    QuestionId = new Guid("DAA576A4-92EB-4CE4-BDFD-504F5BFE7380"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("747920F3-E70C-476F-8B6A-723AA9AF367C"),
                    Text = "Abingdon",
                    QuestionId = new Guid("DAA576A4-92EB-4CE4-BDFD-504F5BFE7380"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("3ECAA561-90F0-4AB9-B0EC-ABB373DD8372"),
                    Text = "Lima",
                    QuestionId = new Guid("B52861A8-E60D-49A2-9418-CECEC0E3A970"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("1E2F4319-9CA8-4C3B-B39C-4279A1622365"),
                    Text = "Arequipa",
                    QuestionId = new Guid("B52861A8-E60D-49A2-9418-CECEC0E3A970"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("DEFD7DB4-A00E-4AD4-91BC-651918A15E98"),
                    Text = "Trujillo",
                    QuestionId = new Guid("B52861A8-E60D-49A2-9418-CECEC0E3A970"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("AB380001-4EF3-4860-AE3B-891A249FB379"),
                    Text = "Chiclayo",
                    QuestionId = new Guid("B52861A8-E60D-49A2-9418-CECEC0E3A970"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("194CF231-29DB-446C-990B-690C9186D513"),
                    Text = "15 inches",
                    QuestionId = new Guid("5E924EA5-B8EC-4535-9ED3-5B406858D38E"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("E7B1F3B5-FBB9-43D0-AC19-BF6C50076132"),
                    Text = "18 inches",
                    QuestionId = new Guid("5E924EA5-B8EC-4535-9ED3-5B406858D38E"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("68054AC0-8EC7-4CC9-BD55-DD5ED826CDF3"),
                    Text = "17 inches",
                    QuestionId = new Guid("5E924EA5-B8EC-4535-9ED3-5B406858D38E"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("797991FA-E359-4E2C-87E2-B6EC2E0658E6"),
                    Text = "20 inches",
                    QuestionId = new Guid("5E924EA5-B8EC-4535-9ED3-5B406858D38E"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("22EF9569-B453-4117-91DB-12CC814D897D"),
                    Text = "4 years",
                    QuestionId = new Guid("DE3604BD-1772-42D4-9402-916DE833A2E8"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("EDEBE235-AF2B-47E7-B456-6103B4883A45"),
                    Text = "6 years",
                    QuestionId = new Guid("DE3604BD-1772-42D4-9402-916DE833A2E8"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("9C0EA4FD-8794-41EF-A23A-B2DBCA5AC612"),
                    Text = "3 years",
                    QuestionId = new Guid("DE3604BD-1772-42D4-9402-916DE833A2E8"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("635E0143-F470-4B33-AF7C-BD9B98E1C266"),
                    Text = "5 years",
                    QuestionId = new Guid("DE3604BD-1772-42D4-9402-916DE833A2E8"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("64A8636B-25E3-4227-B89E-9D1970CAD9B0"),
                    Text = "Soccer",
                    QuestionId = new Guid("CD326D42-4103-47A7-961E-CAF053C557D9"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("7C1193C9-FF17-404D-B039-9A887DC56720"),
                    Text = "Tennis",
                    QuestionId = new Guid("CD326D42-4103-47A7-961E-CAF053C557D9"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("6376ECC7-161B-43A0-9837-9EA33E32BE6B"),
                    Text = "Basketball",
                    QuestionId = new Guid("CD326D42-4103-47A7-961E-CAF053C557D9"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("AACBE5D7-A004-4B0B-B175-95C71CDDCB00"),
                    Text = "Hockey",
                    QuestionId = new Guid("CD326D42-4103-47A7-961E-CAF053C557D9"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("60AB1E74-0B26-4AB8-B588-83EC671D9717"),
                    Text = "Hockey",
                    QuestionId = new Guid("8D656CE5-3778-47F1-91F6-FF725A0FBDF5"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("AFEB1977-9758-4DF9-B604-94C32D058171"),
                    Text = "Soccer",
                    QuestionId = new Guid("8D656CE5-3778-47F1-91F6-FF725A0FBDF5"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("77F50A9E-40CA-49AD-B4B6-FFEDE307F443"),
                    Text = "Basketball",
                    QuestionId = new Guid("8D656CE5-3778-47F1-91F6-FF725A0FBDF5"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("0E54D288-756C-48DD-8563-C70969A30CFE"),
                    Text = "26.2 miles",
                    QuestionId = new Guid("D91D40E7-F2A1-48DD-9311-A99BA45DA8FA"),
                    Correct = true,
                },
                new Answers
                {
                    Id = new Guid("8C3E8B59-07DB-4CCB-B41F-8A59A6736080"),
                    Text = "24.2 miles",
                    QuestionId = new Guid("D91D40E7-F2A1-48DD-9311-A99BA45DA8FA"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("BE753E69-871E-41B4-8979-ACC55475D4BE"),
                    Text = "28.2 miles",
                    QuestionId = new Guid("D91D40E7-F2A1-48DD-9311-A99BA45DA8FA"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("25CB676E-B89D-474C-B122-5930D9C40643"),
                    Text = "25.2 miles",
                    QuestionId = new Guid("D91D40E7-F2A1-48DD-9311-A99BA45DA8FA"),
                    Correct = false,
                },
                new Answers
                {
                    Id = new Guid("25CB676E-B89D-474C-B122-5930D9C40643"),
                    Text = "25.2 miles",
                    QuestionId = new Guid("D91D40E7-F2A1-48DD-9311-A99BA45DA8FA"),
                    Correct = false,
                }
                );

            #endregion
        }
    }
}
