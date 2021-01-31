
using System.Security.AccessControl;

namespace M_CGPA.Language
{
    public class LanguagePro
    {
        public string Language { get; set; }
        public string Font { get; set; }

        #region Menubar Items Name
        public string MenuFile { get; set; }
        public string MenuFileExit { get; set; }
        public string MenuInsert { get; set; }
        public string MenuInsertStudent { get; set; }
        public string MenuInsertClass { get; set; }
        public string MenuInsertMark { get; set; }
        public string MenuReport { get; set; }
        public string MenuReportStudent { get; set; }
        public string MenuReportResult { get; set; }
        public string MenuSetting { get; set; }
        public string MenuHelp { get; set; }
        #endregion

        #region All Field Name

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
        public string BtnClear { get; set; }
        public string BtnAdd { get; set; }
        public string Setting { get; set; }
        public string TitleClass { get; set; }
        public string ClassName { get; set; }

        #endregion

        #region Message

        public string SaveSuccessMessage { get; set; }
        public string SaveErrorMessage { get; set; }
        public string ClassAlreadyExist { get; set; }

        #endregion
    }
}
