using System;
using System.ComponentModel.DataAnnotations;

namespace Championship.ViewModels
{
    public class TeamViewModel
    {   
        [Required(ErrorMessage = "Please, fill the field Name")]
        [MaxLength(100, ErrorMessage = "Name can't be greater than  {0} characters ")]
        [MinLength(3, ErrorMessage = "Name can't be less  than  {0} characters ")]
        public string Name { get; set; }

    }
}