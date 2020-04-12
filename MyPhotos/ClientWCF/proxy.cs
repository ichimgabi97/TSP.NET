﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAPI")]
public interface IAPI
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/AddTables", ReplyAction="http://tempuri.org/InterfaceAPI/AddTablesResponse")]
    void AddTables(string table, string path, string name, string zone, string person, string eventt, string automobile, string otherTags);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/AddTables", ReplyAction="http://tempuri.org/InterfaceAPI/AddTablesResponse")]
    System.Threading.Tasks.Task AddTablesAsync(string table, string path, string name, string zone, string person, string eventt, string automobile, string otherTags);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByName", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByNameResponse")]
    string SearchElementByName(string table, string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByName", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByNameResponse")]
    System.Threading.Tasks.Task<string> SearchElementByNameAsync(string table, string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByZone", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByZoneResponse")]
    string SearchElementByZone(string table, string zone);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByZone", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByZoneResponse")]
    System.Threading.Tasks.Task<string> SearchElementByZoneAsync(string table, string zone);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByPerson", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByPersonResponse")]
    string SearchElementByPerson(string table, string person);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByPerson", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByPersonResponse")]
    System.Threading.Tasks.Task<string> SearchElementByPersonAsync(string table, string person);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByEvent", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByEventResponse")]
    string SearchElementByEvent(string table, string eventt);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByEvent", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByEventResponse")]
    System.Threading.Tasks.Task<string> SearchElementByEventAsync(string table, string eventt);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByAutomobile", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByAutomobileResponse")]
    string SearchElementByAutomobile(string table, string automobile);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByAutomobile", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByAutomobileResponse")]
    System.Threading.Tasks.Task<string> SearchElementByAutomobileAsync(string table, string automobile);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByOtherTags", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByOtherTagsResponse")]
    string SearchElementByOtherTags(string table, string other_tags);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/SearchElementByOtherTags", ReplyAction="http://tempuri.org/InterfaceAPI/SearchElementByOtherTagsResponse")]
    System.Threading.Tasks.Task<string> SearchElementByOtherTagsAsync(string table, string other_tags);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/ModifyElementName", ReplyAction="http://tempuri.org/InterfaceAPI/ModifyElementNameResponse")]
    void ModifyElementName(string table, string name, string newName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/ModifyElementName", ReplyAction="http://tempuri.org/InterfaceAPI/ModifyElementNameResponse")]
    System.Threading.Tasks.Task ModifyElementNameAsync(string table, string name, string newName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/ReadTable", ReplyAction="http://tempuri.org/InterfaceAPI/ReadTableResponse")]
    string ReadTable(string table);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/ReadTable", ReplyAction="http://tempuri.org/InterfaceAPI/ReadTableResponse")]
    System.Threading.Tasks.Task<string> ReadTableAsync(string table);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/ReturnIdOfElement", ReplyAction="http://tempuri.org/InterfaceAPI/ReturnIdOfElementResponse")]
    int ReturnIdOfElement(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/ReturnIdOfElement", ReplyAction="http://tempuri.org/InterfaceAPI/ReturnIdOfElementResponse")]
    System.Threading.Tasks.Task<int> ReturnIdOfElementAsync(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/DeleteElement", ReplyAction="http://tempuri.org/InterfaceAPI/DeleteElementResponse")]
    void DeleteElement(int Id, string table);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceAPI/DeleteElement", ReplyAction="http://tempuri.org/InterfaceAPI/DeleteElementResponse")]
    System.Threading.Tasks.Task DeleteElementAsync(int Id, string table);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IAPIChannel : IAPI, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class APIClient : System.ServiceModel.ClientBase<IAPI>, IAPI
{
    
    public APIClient()
    {
    }
    
    public APIClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public APIClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public APIClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public APIClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void AddTables(string table, string path, string name, string zone, string person, string eventt, string automobile, string otherTags)
    {
        base.Channel.AddTables(table, path, name, zone, person, eventt, automobile, otherTags);
    }
    
    public System.Threading.Tasks.Task AddTablesAsync(string table, string path, string name, string zone, string person, string eventt, string automobile, string otherTags)
    {
        return base.Channel.AddTablesAsync(table, path, name, zone, person, eventt, automobile, otherTags);
    }
    
    public string SearchElementByName(string table, string name)
    {
        return base.Channel.SearchElementByName(table, name);
    }
    
    public System.Threading.Tasks.Task<string> SearchElementByNameAsync(string table, string name)
    {
        return base.Channel.SearchElementByNameAsync(table, name);
    }
    
    public string SearchElementByZone(string table, string zone)
    {
        return base.Channel.SearchElementByZone(table, zone);
    }
    
    public System.Threading.Tasks.Task<string> SearchElementByZoneAsync(string table, string zone)
    {
        return base.Channel.SearchElementByZoneAsync(table, zone);
    }
    
    public string SearchElementByPerson(string table, string person)
    {
        return base.Channel.SearchElementByPerson(table, person);
    }
    
    public System.Threading.Tasks.Task<string> SearchElementByPersonAsync(string table, string person)
    {
        return base.Channel.SearchElementByPersonAsync(table, person);
    }
    
    public string SearchElementByEvent(string table, string eventt)
    {
        return base.Channel.SearchElementByEvent(table, eventt);
    }
    
    public System.Threading.Tasks.Task<string> SearchElementByEventAsync(string table, string eventt)
    {
        return base.Channel.SearchElementByEventAsync(table, eventt);
    }
    
    public string SearchElementByAutomobile(string table, string automobile)
    {
        return base.Channel.SearchElementByAutomobile(table, automobile);
    }
    
    public System.Threading.Tasks.Task<string> SearchElementByAutomobileAsync(string table, string automobile)
    {
        return base.Channel.SearchElementByAutomobileAsync(table, automobile);
    }
    
    public string SearchElementByOtherTags(string table, string other_tags)
    {
        return base.Channel.SearchElementByOtherTags(table, other_tags);
    }
    
    public System.Threading.Tasks.Task<string> SearchElementByOtherTagsAsync(string table, string other_tags)
    {
        return base.Channel.SearchElementByOtherTagsAsync(table, other_tags);
    }
    
    public void ModifyElementName(string table, string name, string newName)
    {
        base.Channel.ModifyElementName(table, name, newName);
    }
    
    public System.Threading.Tasks.Task ModifyElementNameAsync(string table, string name, string newName)
    {
        return base.Channel.ModifyElementNameAsync(table, name, newName);
    }
    
    public string ReadTable(string table)
    {
        return base.Channel.ReadTable(table);
    }
    
    public System.Threading.Tasks.Task<string> ReadTableAsync(string table)
    {
        return base.Channel.ReadTableAsync(table);
    }
    
    public int ReturnIdOfElement(string path)
    {
        return base.Channel.ReturnIdOfElement(path);
    }
    
    public System.Threading.Tasks.Task<int> ReturnIdOfElementAsync(string path)
    {
        return base.Channel.ReturnIdOfElementAsync(path);
    }
    
    public void DeleteElement(int Id, string table)
    {
        base.Channel.DeleteElement(Id, table);
    }
    
    public System.Threading.Tasks.Task DeleteElementAsync(int Id, string table)
    {
        return base.Channel.DeleteElementAsync(Id, table);
    }
}