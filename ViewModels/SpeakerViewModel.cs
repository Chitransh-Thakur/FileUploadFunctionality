using System.ComponentModel.DataAnnotations;

namespace FileUploadFunctionality.ViewModels
{
    public class SpeakerViewModel : EditImageViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string SpeakerName { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        public string Experience { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime SpeakingDate { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Time")]
        public DateTime SpeakingTime { get; set; }

        [Required]
        public string Venue { get; set; }
    }
}
