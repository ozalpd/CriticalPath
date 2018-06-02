//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CriticalPath.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Process : ICreatorId, ICreatorIp, ICreateDate, IModifyNr, IModifierId, IModifierIp, IModifyDate, IIsApproved, IApproval, ICancelled, ICancellation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Process()
        {
            this.ProcessSteps = new HashSet<ProcessStep>();
        }
    
        public int Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Description { get; set; }
        public int ProcessTemplateId { get; set; }
        public int PurchaseOrderId { get; set; }
        public Nullable<int> CurrentStepId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime TargetDate { get; set; }
        public Nullable<System.DateTime> ForecastDate { get; set; }
        public Nullable<System.DateTime> RealizedDate { get; set; }
        public bool IsApproved { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public string ApprovedUserId { get; set; }
        public string ApprovedUserIp { get; set; }
        public bool Cancelled { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public string CancellationReason { get; set; }
        public string CancelledUserId { get; set; }
        public string CancelledUserIp { get; set; }
        public int ModifyNr { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public string ModifierId { get; set; }
        public string ModifierIp { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatorId { get; set; }
        public string CreatorIp { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessStep> ProcessSteps { get; set; }
        public virtual ProcessTemplate ProcessTemplate { get; set; }
        public virtual AspNetUser ApprovedUser { get; set; }
        public virtual AspNetUser CancelledUser { get; set; }
        public virtual AspNetUser CreatedUser { get; set; }
        public virtual AspNetUser ModifiedUser { get; set; }
        public virtual ProcessStep CurrentStep { get; set; }
    	/// <summary>
    	/// Clones all properties in a new Process instance,
    	/// except PrimaryKey(s)
    	/// </summary>
    	/// <returns>New Process instance</returns>
        public Process Clone()
        {
            var clone = new Process();
            clone.IsCompleted = IsCompleted;
            clone.Description = Description;
            clone.ProcessTemplateId = ProcessTemplateId;
            clone.PurchaseOrderId = PurchaseOrderId;
            clone.CurrentStepId = CurrentStepId;
            clone.StartDate = StartDate;
            clone.TargetDate = TargetDate;
            clone.ForecastDate = ForecastDate;
            clone.RealizedDate = RealizedDate;
            clone.IsApproved = IsApproved;
            clone.ApproveDate = ApproveDate;
            clone.ApprovedUserId = ApprovedUserId;
            clone.ApprovedUserIp = ApprovedUserIp;
            clone.Cancelled = Cancelled;
            clone.CancelDate = CancelDate;
            clone.CancellationReason = CancellationReason;
            clone.CancelledUserId = CancelledUserId;
            clone.CancelledUserIp = CancelledUserIp;
            clone.ModifyNr = ModifyNr;
            clone.ModifyDate = ModifyDate;
            clone.ModifierId = ModifierId;
            clone.ModifierIp = ModifierIp;
            clone.CreateDate = CreateDate;
            clone.CreatorId = CreatorId;
            clone.CreatorIp = CreatorIp;
    
            Cloning(clone);
    
            return clone;
        }
    
    	// Use below function in a partial class file (eg. Process.part.cs)
    	// to add more complexity to clone
        partial void Cloning(Process clone);
    }
    
    //Data Transfer Object type for Process
    public partial class ProcessDTO
    {
        public ProcessDTO() { }
    
        public ProcessDTO(Process entity)
        {
            Id = entity.Id;
            IsCompleted = entity.IsCompleted;
            Description = entity.Description;
            ProcessTemplateId = entity.ProcessTemplateId;
            PurchaseOrderId = entity.PurchaseOrderId;
            CurrentStepId = entity.CurrentStepId;
            StartDate = entity.StartDate;
            TargetDate = entity.TargetDate;
            ForecastDate = entity.ForecastDate;
            RealizedDate = entity.RealizedDate;
            IsApproved = entity.IsApproved;
            ApproveDate = entity.ApproveDate;
            Cancelled = entity.Cancelled;
            CancelDate = entity.CancelDate;
            CancellationReason = entity.CancellationReason;
        
            Initiliazing(entity);
        }
    
        partial void Initiliazing(Process entity);
        
        public virtual Process ToProcess()
        {
            var entity = new Process();
            entity.Id = Id;
            entity.IsCompleted = IsCompleted;
            entity.Description = Description;
            entity.ProcessTemplateId = ProcessTemplateId;
            entity.PurchaseOrderId = PurchaseOrderId;
            entity.CurrentStepId = CurrentStepId;
            entity.StartDate = StartDate;
            entity.TargetDate = TargetDate;
            entity.ForecastDate = ForecastDate;
            entity.RealizedDate = RealizedDate;
            entity.IsApproved = IsApproved;
            entity.ApproveDate = ApproveDate;
            entity.Cancelled = Cancelled;
            entity.CancelDate = CancelDate;
            entity.CancellationReason = CancellationReason;
    
            Converting(entity);
    
            return entity;
        }
    
        partial void Converting(Process entity);
      
        public int Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Description { get; set; }
        public int ProcessTemplateId { get; set; }
        public int PurchaseOrderId { get; set; }
        public Nullable<int> CurrentStepId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime TargetDate { get; set; }
        public Nullable<System.DateTime> ForecastDate { get; set; }
        public Nullable<System.DateTime> RealizedDate { get; set; }
        public bool IsApproved { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public bool Cancelled { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public string CancellationReason { get; set; }
    }
}
