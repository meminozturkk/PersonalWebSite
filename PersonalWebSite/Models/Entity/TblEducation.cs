﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalWebSite.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TblEducation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string Title { get; set; }
        [StringLength(250, ErrorMessage = "250 karekteri geçmeyiniz")]
        public string Subtitle1 { get; set; }
        public string Subtitle2 { get; set; }
        public string GNO { get; set; }
        public string Date { get; set; }
    }
}
