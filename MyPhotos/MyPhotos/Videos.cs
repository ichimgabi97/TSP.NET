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


    public partial class Videos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Videos()
        {
            this.Tags_video = new HashSet<Tags_video>();
        }
        [DataMember]

        public int Id { get; set; }
        [DataMember]

        public string Name { get; set; }
        [DataMember]

        public Nullable<System.DateTime> Last_updated { get; set; }
        [DataMember]

        public int Media_Id { get; set; }
        [DataMember]


        public virtual Medias Media { get; set; }
        [DataMember]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tags_video> Tags_video { get; set; }
    }
}
