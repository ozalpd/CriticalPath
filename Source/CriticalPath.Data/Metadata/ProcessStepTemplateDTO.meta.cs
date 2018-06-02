using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CP.i8n;
//------------------------------------------------------------------------------
//
//     This code was generated by OzzCodeGen.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//------------------------------------------------------------------------------

namespace CriticalPath.Data
{
    [MetadataTypeAttribute(typeof(ProcessStepTemplateDTO.ProcessStepTemplateMetadata))]
    public partial class ProcessStepTemplateDTO
	{
        internal sealed partial class ProcessStepTemplateMetadata
		{
            // This metadata class is not intended to be instantiated.
            private ProcessStepTemplateMetadata() { }

            [StringLength(128, ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "MaxLeght")]
            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [Display(ResourceType = typeof(EntityStrings), Name = "Title")]
            public string Title { get; set; }

            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [Display(ResourceType = typeof(EntityStrings), Name = "DisplayOrder")]
            public int DisplayOrder { get; set; }

            [Display(ResourceType = typeof(EntityStrings), Name = "IgnoreInRepeat")]
            public bool IgnoreInRepeat { get; set; }

            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [Range(0,100)]
            [Display(ResourceType = typeof(EntityStrings), Name = "RequiredWorkDays")]
            public int RequiredWorkDays { get; set; }

            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [DataType(DataType.Date)]
            [Range(0,100)]
            [Display(ResourceType = typeof(EntityStrings), Name = "ReqDaysBeforeDueDate")]
            public int ReqDaysBeforeDueDate { get; set; }

            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [Display(ResourceType = typeof(EntityStrings), Name = "ProcessTemplateId")]
            public int ProcessTemplateId { get; set; }

            [Display(ResourceType = typeof(EntityStrings), Name = "DependedStepId")]
            public int DependedStepId { get; set; }

		}
	}
}