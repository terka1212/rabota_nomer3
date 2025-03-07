//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace курсовая
{
    using System;
    using System.Collections.Generic;
    
    public partial class Source_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Source_()
        {
            this.Review = new HashSet<Review>();
            this.SourceEditHistory = new HashSet<SourceEditHistory>();
            this.Category = new HashSet<Category>();
        }
    
        public int id_source { get; set; }
        public string title { get; set; }
        public Nullable<int> id_author { get; set; }
        public Nullable<int> id_topic { get; set; }
        public string publisher { get; set; }
        public string C_language { get; set; }
        public Nullable<int> publication_year { get; set; }
        public string C_description { get; set; }
        public string isbn { get; set; }
        public string cover_image { get; set; }
    
        public virtual Author Author { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Review { get; set; }
        public virtual Topic Topic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SourceEditHistory> SourceEditHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Category { get; set; }
    }
}
