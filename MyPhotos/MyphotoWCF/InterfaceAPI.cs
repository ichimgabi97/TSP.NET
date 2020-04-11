using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPhotos;
using System.ServiceModel;
using System.Threading.Tasks;


namespace MyphotoWCF
{
    [ServiceContract]
    interface InterfaceAPI
    {
        [OperationContract]
        void AddTables(String table, String path, String name, String zone, String person, String eventt, String automobile, String otherTags);

        [OperationContract]
        String SearchElementByName(String table, String name);

        [OperationContract]
        String SearchElementByZone(String table, String zone);

        [OperationContract]
        String SearchElementByPerson(String table, String person);

        [OperationContract]
        String SearchElementByEvent(String table, String eventt);

        [OperationContract]
        String SearchElementByAutomobile(String table, String automobile);

        [OperationContract]
        String SearchElementByOtherTags(String table, String other_tags);

        [OperationContract]
        void ModifyElementName(String table, String name, String newName);

        [OperationContract]
        String ReadTable(String table);

        [OperationContract]
        int ReturnIdOfElement(String path);

       /* [OperationContract]
        void DeleteElement(int Id, String table);
*/
    }
    [ServiceContract]
    interface IAPI : InterfaceAPI { 
    }
}
