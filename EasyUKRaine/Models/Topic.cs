//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyUKRaine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Topic
    {
        public int TopicID { get; set; }
        public string Header { get; set; }
        public string Image { get; set; }
        public Nullable<int> Capacity { get; set; }
        public Nullable<int> MinScoreForAccess { get; set; }
    }
}
