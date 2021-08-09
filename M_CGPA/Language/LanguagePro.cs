
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace M_CGPA.Language
{
    public class LanguagePro
    {
        public string Language { get; set; }
        public string Font { get; set; }

        #region Button
        public string BtnClear { get; set; }
        public string BtnAdd { get; set; }
        public string BtnUpdate { get; set; }
        public string BtnDelete { get; set; }
        public string BtnCancel { get; set; }
        public string BtnSearch { get; set; }
        #endregion

        #region All Field Name

        public string ClassNumber { get; set; }
        public string Mark { get; set; }
        public string SearchForAnything { get; set; }
        public string HelAreadyHasTheBook { get; set; }
        public string Phone { get; set; }
        public string TitleInformation { get; set; }
        public string Student { get; set; }
        public string TitleAddStudent { get; set; }
        public string StudentInformation { get; set; }
        public string AcademicInformation { get; set; }
        public string Roll { get; set; }
        public string Reg { get; set; }
        public string Session { get; set; }
        public string Class { get; set; }
        public string AdmissionDate { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DOB { get; set; }
        public string NID { get; set; }
        public string BRN { get; set; }
        public string PresentAddress { get; set; }
        public string PermanenetAddress { get; set; }
        public string Setting { get; set; }
        public string TitleClass { get; set; }
        public string ClassName { get; set; }
        public string TitleBook { get; set; }
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string Year { get; set; }
        public string TitleSyllabus { get; set; }
        public string Search { get; set; }
        #endregion

        #region Message

        public string GradePointAlreadyExist { get; set; }
        public string MessageTitle { get; set; }
        public string SaveSuccessMessage { get; set; }
        public string UpdateSuccessMessage { get; set; }
        public string DeleteSuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public string ClassAlreadyExist { get; set; }
        public string BlankFiled { get; set; }
        public string DeleteConfirmation { get; set; }
        public string BookAlreadyExist { get; set; }
        public string StudentAlreadyExist { get; set; }
        #endregion
    }
}
