using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyPhotos
{
    public class API
    {
        public void AddTables(String table, String path, String name, String zone, String person, String eventt, String automobile, String otherTags)
        {
            using (Model1Container dbcontext = new Model1Container())
            {
                if (table == "Photo")
                {
                    Medias medias = new Medias();
                    
                    medias.Path = path;
                    medias.Add_date = DateTime.UtcNow;
                    dbcontext.Medias.Add(medias);

                    Photos photo = new Photos();

                    photo.Name = name;
                    photo.Last_updated = DateTime.UtcNow;
                    photo.Media_Id = medias.Id;
                    dbcontext.Photos.Add(photo);

                    Tags_photo tags = new Tags_photo();

                    tags.Zone = zone;
                    tags.Person = person;
                    tags.Event = eventt;
                    tags.Automobile = automobile;
                    tags.Other_tags = otherTags;
                    tags.Photo_Id = photo.Id;
                    dbcontext.Tags_photo.Add(tags);

                    dbcontext.SaveChanges(); 
                }
                else
                {
                    Medias medias = new Medias();

                    medias.Path = path;
                    medias.Add_date = DateTime.UtcNow;
                    dbcontext.Medias.Add(medias);

                    Videos video = new Videos();

                    video.Name = name;
                    video.Last_updated = DateTime.UtcNow;
                    video.Media_Id = medias.Id;
                    dbcontext.Videos.Add(video);

                    Tags_video tags = new Tags_video();

                    tags.Zone = zone;
                    tags.Person = person;
                    tags.Event = eventt;
                    tags.Automobile = automobile;
                    tags.Other_tags = otherTags;
                    tags.Video_Id = video.Id;
                    dbcontext.Tags_video.Add(tags);

                    dbcontext.SaveChanges();
                }
            }

        }
    
        public String SearchElementByName(String table, String name)
        {
            using (Model1Container dbcontext = new Model1Container())
            {

                if (table == "Photo")
                {
                    var obj = from photo in dbcontext.Photos where photo.Name == name select photo;
                    foreach (var item1 in obj)
                    {
                        var obj1 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                        foreach (var item in obj1)
                        {
                            return item.Path;
                        }
                    }
                    
                }
                else if (table == "Video")
                {
                    var obj = from video in dbcontext.Videos where video.Name == name select video;
                    foreach (var item1 in obj)
                    {
                        var obj1 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                        foreach (var item in obj1)
                        {
                            return item.Path;
                        }
                    }
                }

                return "Error";
            }
        }

        public String SearchElementByZone(String table, String zone)
        {
            using (Model1Container dbcontext = new Model1Container())
            {

                if (table == "Photo")
                {
                    var obj = from photo in dbcontext.Tags_photo where photo.Zone == zone select photo;
                    foreach(var item2 in obj)
                    {
                        var obj1 = from photo in dbcontext.Photos where photo.Id == item2.Photo_Id select photo;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    }                 
                }
                else if (table == "Video")
                {
                    var obj = from video in dbcontext.Tags_video where video.Zone == zone select video;
                    foreach (var item2 in obj)
                    {
                        var obj1 = from video in dbcontext.Videos where video.Id == item2.Video_Id select video;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    } 
                }

                return "Error";
            }
        }

        public String SearchElementByPerson(String table, String person)
        {
            using (Model1Container dbcontext = new Model1Container())
            {

                if (table == "Photo")
                {
                    var obj = from photo in dbcontext.Tags_photo where photo.Person == person select photo;
                    foreach (var item2 in obj)
                    {
                        var obj1 = from photo in dbcontext.Photos where photo.Id == item2.Photo_Id select photo;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    }
                }
                else if (table == "Video")
                {
                    var obj = from video in dbcontext.Tags_video where video.Person == person select video;
                    foreach (var item2 in obj)
                    {
                        var obj1 = from video in dbcontext.Videos where video.Id == item2.Video_Id select video;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    }
                }

                return "Error";
            }
        }

        public String SearchElementByEvent(String table, String eventt)
        {
            using (Model1Container dbcontext = new Model1Container())
            {

                if (table == "Photo")
                {
                    var obj = from photo in dbcontext.Tags_photo where photo.Event == eventt select photo;
                    foreach (var item2 in obj)
                    {
                        var obj1 = from photo in dbcontext.Photos where photo.Id == item2.Photo_Id select photo;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    }
                }
                else if (table == "Video")
                {
                    var obj = from video in dbcontext.Tags_video where video.Event == eventt select video;
                    foreach (var item2 in obj)
                    {
                        var obj1 = from video in dbcontext.Videos where video.Id == item2.Video_Id select video;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    }
                }

                return "Error";
            }
        }

        public String SearchElementByAutomobile(String table, String automobile)
        {
            using (Model1Container dbcontext = new Model1Container())
            {

                if (table == "Photo")
                {
                    var obj = from photo in dbcontext.Tags_photo where photo.Automobile == automobile select photo;
                    foreach (var item2 in obj)
                    {
                        var obj1 = from photo in dbcontext.Photos where photo.Id == item2.Photo_Id select photo;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    }
                }
                else if (table == "Video")
                {
                    var obj = from video in dbcontext.Tags_video where video.Automobile == automobile select video;
                    foreach (var item2 in obj)
                    {
                        var obj1 = from video in dbcontext.Videos where video.Id == item2.Video_Id select video;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    }
                }

                return "Error";
            }
        }

        public String SearchElementByOtherTags(String table, String other_tags)
        {
            using (Model1Container dbcontext = new Model1Container())
            {

                if (table == "Photo")
                {
                    var obj = from photo in dbcontext.Tags_photo where photo.Other_tags == other_tags select photo;
                    foreach (var item2 in obj)
                    {
                        var obj1 = from photo in dbcontext.Photos where photo.Id == item2.Photo_Id select photo;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    }
                }
                else if (table == "Video")
                {
                    var obj = from video in dbcontext.Tags_video where video.Other_tags == other_tags select video;
                    foreach (var item2 in obj)
                    {
                        var obj1 = from video in dbcontext.Videos where video.Id == item2.Video_Id select video;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from media in dbcontext.Medias where media.Id == item1.Media_Id select media;
                            foreach (var item in obj2)
                            {
                                return item.Path;
                            }
                        }
                    }
                }

                return "Error";
            }
        }

        public void ModifyElementName(String table, String name, String newName)
        {
            using (Model1Container dbcontext = new Model1Container())
            {

                if (table == "Photo")
                {
                    var obj = from photo in dbcontext.Photos where photo.Name == name select photo;
                    foreach (var item1 in obj)
                    {
                        item1.Name = newName;
                    }

                }
                else if (table == "Video")
                {
                    var obj = from video in dbcontext.Videos where video.Name == name select video;
                    foreach (var item1 in obj)
                    {
                        item1.Name = newName;
                    }
                }
                dbcontext.SaveChanges();
            }
        }

        public String ReadTable(String table)
        {
            using (Model1Container dbcontext = new Model1Container())
            {
                if (table == "Photo")
                {
                    var query = from photos in dbcontext.Photos select photos;
                    foreach (var item in query)
                    {
                        var obj1 = from media in dbcontext.Medias where media.Id == item.Media_Id select media;
                        foreach (var item1 in obj1)
                        {
                            return item1.Path;
                        }
                    }
                }
                else
                {
                    var query = from videos in dbcontext.Videos select videos;
                    foreach (var item in query)
                    {
                        var obj1 = from media in dbcontext.Medias where media.Id == item.Media_Id select media;
                        foreach (var item1 in obj1)
                        {
                            return item1.Path;
                        }
                    }
                }
                return "Error";
            }
        }

        public int ReturnIdOfElement(String path)
        {
            using (Model1Container dbcontext = new Model1Container())
            {
                var obj = from media in dbcontext.Medias where media.Path == path select media;
                foreach (var item in obj)
                {
                    return item.Id;
                }
            }
            return 0;
        }

        public void DeleteElement(int Id, String table)
        {
            using (Model1Container dbcontext = new Model1Container())
            {
                if(table == "Photo")
                {
                    var obj = from media in dbcontext.Medias where media.Id == Id select media;
                    foreach (var item in obj)
                    {
                        var obj1 = from photo in dbcontext.Photos where photo.Media_Id == item.Id select photo;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from photo in dbcontext.Tags_photo where photo.Photo_Id == item1.Id select photo;
                            foreach (var item2 in obj2)
                            {
                                dbcontext.Tags_photo.Remove(item2);
                                dbcontext.SaveChanges();
                            }
                            dbcontext.Photos.Remove(item1);
                            dbcontext.SaveChanges();
                        }
                        dbcontext.Medias.Remove(item);
                        dbcontext.SaveChanges();
                    }
                }
                else
                {
                    var obj = from media in dbcontext.Medias where media.Id == Id select media;
                    foreach (var item in obj)
                    {
                        var obj1 = from video in dbcontext.Videos where video.Media_Id == item.Id select video;
                        foreach (var item1 in obj1)
                        {
                            var obj2 = from video in dbcontext.Tags_video where video.Video_Id == item1.Id select video;
                            foreach (var item2 in obj2)
                            {
                                dbcontext.Tags_video.Remove(item2);
                                dbcontext.SaveChanges();
                            }
                            dbcontext.Videos.Remove(item1);
                            dbcontext.SaveChanges();
                        }
                        dbcontext.Medias.Remove(item);
                        dbcontext.SaveChanges();
                    }
                }
            }
        }

    }
 
}
