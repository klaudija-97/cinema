//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekat_Bioskop
{
    using System;
    using System.Collections.Generic;
    
    public partial class FILMOVI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FILMOVI()
        {
            this.PRIKAZIVANJAs = new HashSet<PRIKAZIVANJA>();
        }
    
        public int film_id { get; set; }
        public string naslov { get; set; }
        public string zanr { get; set; }
        public short godina_izdanja { get; set; }
        public short trajanje { get; set; }
        public string rezija { get; set; }
        public string scenario { get; set; }
        public string producent { get; set; }
        public string zemlja { get; set; }
        public string jezik { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRIKAZIVANJA> PRIKAZIVANJAs { get; set; }
    }
}
