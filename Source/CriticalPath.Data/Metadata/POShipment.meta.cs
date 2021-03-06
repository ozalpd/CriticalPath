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
    [MetadataTypeAttribute(typeof(POShipment.POShipmentMetadata))]
    public partial class POShipment
	{
        internal sealed partial class POShipmentMetadata
		{
            // This metadata class is not intended to be instantiated.
            private POShipmentMetadata() { }

            [StringLength(32, ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "MaxLeght")]
            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [Display(ResourceType = typeof(EntityStrings), Name = "ShippingNr")]
            public string ShippingNr { get; set; }

            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [DataType(DataType.Date)]
            [Display(ResourceType = typeof(EntityStrings), Name = "ShippingDate")]
            public DateTime ShippingDate { get; set; }

            [StringLength(32, ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "MaxLeght")]
            [Display(ResourceType = typeof(EntityStrings), Name = "DeliveryNr")]
            public string DeliveryNr { get; set; }

            [DataType(DataType.Date)]
            [Display(ResourceType = typeof(EntityStrings), Name = "DeliveryDate")]
            public DateTime DeliveryDate { get; set; }

            [StringLength(32, ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "MaxLeght")]
            [Display(ResourceType = typeof(EntityStrings), Name = "DestinationNr")]
            public string DestinationNr { get; set; }

            [StringLength(32, ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "MaxLeght")]
            [Display(ResourceType = typeof(EntityStrings), Name = "RefCode")]
            public string RefCode { get; set; }

            [StringLength(32, ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "MaxLeght")]
            [Display(ResourceType = typeof(EntityStrings), Name = "CustomerRefNr")]
            public string CustomerRefNr { get; set; }

            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [Display(ResourceType = typeof(EntityStrings), Name = "Quantity")]
            public int Quantity { get; set; }

            [Display(ResourceType = typeof(EntityStrings), Name = "IsShipped")]
            public bool IsShipped { get; set; }

            [Display(ResourceType = typeof(EntityStrings), Name = "IsDelivered")]
            public bool IsDelivered { get; set; }

            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [Display(ResourceType = typeof(EntityStrings), Name = "PurchaseOrderId")]
            public int PurchaseOrderId { get; set; }

            [Display(ResourceType = typeof(EntityStrings), Name = "PurchaseOrder")]
            public PurchaseOrder PurchaseOrder { get; set; }

            [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "Required")]
            [Display(ResourceType = typeof(EntityStrings), Name = "FreightTermId")]
            public int FreightTermId { get; set; }

            [Display(ResourceType = typeof(EntityStrings), Name = "FreightTerm")]
            public FreightTerm FreightTerm { get; set; }

            [Display(ResourceType = typeof(EntityStrings), Name = "ModifiedUser")]
            public AspNetUser ModifiedUser { get; set; }

            [Display(ResourceType = typeof(EntityStrings), Name = "CreatedUser")]
            public AspNetUser CreatedUser { get; set; }

		}
	}
}