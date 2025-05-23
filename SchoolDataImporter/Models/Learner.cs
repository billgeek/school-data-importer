﻿using SchoolDataImporter.Constants;
using SchoolDataImporter.Helpers;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataImporter.Models
{
    public class Learner : BaseModel
    {
        public string LearnerCode { get; set; }
        public string NickName { get; set; }
        public string DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public string DateLeft { get; set; }
        public string HostelName { get; set; }
        public bool IsHostel { get; set; }
        public string Status { get; set; }
        public string Grade { get; set; }
        public string Class { get; set; }
        public string House { get; set; }
        public string BusRouteName { get; set; }
        public Parent Parent { get; set; }

        public override IDictionary<string, string> GetDataRowMap()
        {
            return new Dictionary<string, string>
            {
                { "lKode", "LearnerCode" },
                { "lVan", "LastName" },
                { "lName" ,"FirstName" },
                { "lNName", "NickName" },
                { "lGDatum", "DateOfBirth" },
                { "lIDno", "IdNumber" },
                { "lGender", "Gender" },
                { "lSellK", "MobilePhoneCode" },
                { "lSell", "MobilePhoneNumber" },
                { "dWeg", "DateLeft" },
                { "kNaam", "HostelName" },
                { "isHostel", "IsHostel" },
                { "lStatus", "Status" },
                { "Graad", "Grade" },
                { "Klas", "Class" },
                { "House", "House" },
                { "BusRouteName", "BusRouteName" }
            };
        }

        public override string GetItemIdentifier()
        {
            return $"Learner/{LearnerCode}";
        }

        public override IDictionary<string, string> GetModelMap()
        {
            return new Dictionary<string, string>
            {
                { AppConstants.TypeCellName, "Learner" },
                { AppConstants.FirstNameCellName, FirstName },
                { AppConstants.LastNameCellName, LastName },
                { AppConstants.MobileNumberCellName, MobilePhoneNumber },
                { AppConstants.GenderCellName, Gender },
                { AppConstants.StatusCellName, string.IsNullOrWhiteSpace(Status) ? "Unassigned" : AppConstants.LearnerStatuses[Status] },
                { AppConstants.GradeClassCellName, MappingHelper.GetGradeClassCombination(Grade,Class) },
                { AppConstants.BusRouteCellName, BusRouteName },
                { AppConstants.HouseCellName, House },
                { AppConstants.HostelCellName, HostelName },
                { AppConstants.NickNameCellName, NickName }
            };
        }
    }
}