//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]


    public partial class Tags_video
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Zone { get; set; }
        [DataMember]
        public string Person { get; set; }
        [DataMember]
        public string Event { get; set; }
        [DataMember]
        public string Automobile { get; set; }
        [DataMember]
        public string Other_tags { get; set; }
        [DataMember]
        public int Video_Id { get; set; }

        [DataMember]
        public virtual Videos Video { get; set; }
    }
}
