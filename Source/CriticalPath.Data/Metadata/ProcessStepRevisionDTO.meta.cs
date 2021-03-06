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
    [MetadataTypeAttribute(typeof(ProcessStepRevisionDTO.ProcessStepRevisionMetadata))]
    public partial class ProcessStepRevisionDTO
	{
        internal sealed partial class ProcessStepRevisionMetadata
		{
            // This metadata class is not intended to be instantiated.
            private ProcessStepRevisionMetadata() { }

            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [Display(ResourceType = typeof(EntityStrings), Name = "ProcessStepId")]
            public int ProcessStepId { get; set; }

            [Display(ResourceType = typeof(EntityStrings), Name = "IsCompleted")]
            public bool IsCompleted { get; set; }

            [DataType(DataType.Date)]
            [Display(ResourceType = typeof(EntityStrings), Name = "TargetDate")]
            public DateTime TargetDate { get; set; }

            [DataType(DataType.Date)]
            [Display(ResourceType = typeof(EntityStrings), Name = "ForecastDate")]
            public DateTime ForecastDate { get; set; }

            [DataType(DataType.Date)]
            [Display(ResourceType = typeof(EntityStrings), Name = "RealizedDate")]
            public DateTime RealizedDate { get; set; }

		}
	}
}