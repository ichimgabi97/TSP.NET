using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotos;

namespace MyphotoWCF
{
    public class API : IAPI
    {
        MyPhotos.API myPhotos = new MyPhotos.API();

        public void AddTables(String table, String path, String name, String zone, String person, String eventt, String automobile, String otherTags)
        {
            myPhotos.AddTables(table, path, name, zone, person, eventt, automobile, otherTags);
        }

        public String SearchElementByName(String table, String name)
        {
            return myPhotos.SearchElementByName(table, name);
        }

        public String SearchElementByZone(String table, String zone)
        {
            return myPhotos.SearchElementByZone(table, zone);
        }

        public String SearchElementByPerson(String table, String person)
        {
            return myPhotos.SearchElementByZone(table, person);
        }

        public String SearchElementByEvent(String table, String eventt)
        {
            return myPhotos.SearchElementByEvent(table, eventt);
        }

        public String SearchElementByAutomobile(String table, String automobile)
        {
            return myPhotos.SearchElementByAutomobile(table, automobile);
        }

        public String SearchElementByOtherTags(String table, String other_tags)
        {
            return myPhotos.SearchElementByOtherTags(table, other_tags);
        }

        public void ModifyElementName(String table, String name, String newName)
        {
            myPhotos.ModifyElementName(table, name, newName);
        }

        public String ReadTable(String table)
        {
            return myPhotos.ReadTable(table);
        }

        public int ReturnIdOfElement(String path)
        {
            return myPhotos.ReturnIdOfElement(path);
        }

       /* public void DeleteElement(int Id, String table)
        {
            myPhotos.DeleteElement(Id, table);
        }*/
    }
}
