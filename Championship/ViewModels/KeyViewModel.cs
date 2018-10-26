using Championship.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Championship.ViewModels
{
    public class KeyViewModel
    {[Key]
        public int KeyId { get; set; }

        [Required(ErrorMessage = "Please, fill the field Name")]
        [MaxLength(100, ErrorMessage = "Name can't be greater than  {0} characters ")]
        [MinLength(5, ErrorMessage = "Name can't be less  than  {0} characters ")]
        public string Name { get; set; }

        public List<TeamViewModel> Teams { get; set; }
}

}