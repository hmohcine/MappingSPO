﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Framework.BL.VModels.Project
{
    public class ProjectVM
    {
        public long ProjectId { get; set; }
        public string ProjectType { get; set; }
        public int ProjectYear { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public System.DateTime ProjectDate { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? DueDate { get; set; }
        public System.DateTime? DoneDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public string NotesIntern { get; set; }
        public string NotesExtern { get; set; }
        public int? DefaultCompanyId { get; set; }
        public int? OfferCode1 { get; set; }
        public int? OfferCode2 { get; set; }
        public int? OfferCode3 { get; set; }
        public int? OfferCode4 { get; set; }
        public int? OfferCode5 { get; set; }
        public int? OfferCode6 { get; set; }
        public int? OfferCode7 { get; set; }
        public int? OfferCode8 { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public int? WerfCode1 { get; set; }
        public int? WerfCode2 { get; set; }
        public int? WerfCode3 { get; set; }
        public int? WerfCode4 { get; set; }
        public int? WerfCode5 { get; set; }
        public int? WerfCode6 { get; set; }
        public int? WerfCode7 { get; set; }
        public int? WerfCode8 { get; set; }
        public int? DefaultCodeRange { get; set; }
        public int? ProjectVerantWoordelijke1 { get; set; }
        public int? ProjectVerantWoordelijke2 { get; set; }
        public int? ProjectVerantWoordelijke3 { get; set; }
        public int ProjectState { get; set; }
        public int ProjectResult { get; set; }
        public int Owner { get; set; }
        public bool HasExtendedSecurity { get; set; }
        public int? Code1 { get; set; }
        public int? Code2 { get; set; }
        public int? Code3 { get; set; }
        public int? Code4 { get; set; }
        public int? Code5 { get; set; }
        public int? Code6 { get; set; }
        public int? Code7 { get; set; }
        public int? Code8 { get; set; }
        public int? RelationTypeId { get; set; }
        public long? RelationId { get; set; }
        public int? ProjectResultReason { get; set; }
        public int TotalsColumn { get; set; }
        public int? ContactId { get; set; }
        public bool ProjectDone { get; set; }
        public System.DateTime? ExtraDate1 { get; set; }
        public System.DateTime? ExtraDate2 { get; set; }
        public System.DateTime? ExtraDate3 { get; set; }
        public System.DateTime? ExtraDate4 { get; set; }
        public System.DateTime? ExtraDate5 { get; set; }
        public System.DateTime? ExtraDate6 { get; set; }
        public System.DateTime? ExtraDate7 { get; set; }
        public decimal? ExtraNum1 { get; set; }
        public decimal? ExtraNum2 { get; set; }
        public decimal? ExtraNum3 { get; set; }
        public decimal? ExtraNum4 { get; set; }
        public decimal? ExtraNum5 { get; set; }
        public decimal? ExtraNum6 { get; set; }
        public decimal? ExtraNum7 { get; set; }
        public decimal? ExtraNum8 { get; set; }
        public long GlobalId { get; set; }
        public string ExtNumber { get; set; }
        public string CExtNumber { get; set; }
        public bool? CheckInAtWorkYn { get; set; }
        public bool IntegrationYn { get; set; }
        public int? SubCategoryId { get; set; }
    }
}