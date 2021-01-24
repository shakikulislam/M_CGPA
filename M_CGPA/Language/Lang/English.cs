namespace M_CGPA.Language.Lang
{
    class English
    {
        public LanguagePro Pro = new LanguagePro();
        public void Lang()
        {
            Pro.Language = "English";
            Pro.Font = "Segoe UI";

            #region Menubar Items Name

            Pro.MenuFile = "File";
            Pro.MenuFileExit = "Exit";
            Pro.MenuInsert = "Insert";
            Pro.MenuInsertStudent = "Student";
            Pro.MenuInsertClass = "Class";
            Pro.MenuInsertMark = "Mark";
            Pro.MenuReport = "Report";
            Pro.MenuReportStudent = "Student";
            Pro.MenuReportResult = "Result";
            Pro.MenuSetting = "Setting";
            Pro.MenuHelp = "Help";

            #endregion

            #region All Field Name

            Pro.Student = "Student";
            Pro.TitleAddStudent = "Add Student";
            Pro.AcademicInformation = "Academic Information";
            Pro.StudentInformation = "Student Information";
            Pro.Roll = "Roll";
            Pro.Reg = "Registration No";
            Pro.Session = "Session";
            Pro.Class = "Class";
            Pro.AdmissionDate = "Admition Date";
            Pro.StudentName = "Student Name";
            Pro.FatherName = "Father Name";
            Pro.MotherName = "Mother Name";
            Pro.DOB = "Date of Birth";
            Pro.NID = "NID";
            Pro.BRN = "Birth Registration No";
            Pro.PresentAddress = "Present Address";
            Pro.PermanenetAddress = "Permanent Address";
            Pro.BtnClear = "Clear";
            Pro.BtnAdd = "Add";
            Pro.Setting = "Setting";
            Pro.TitleClass = "Add Class";
            Pro.ClassName = "Class Name";

            #endregion

            #region Message

            Pro.SaveSuccessMessage = "Successfully saved...";
            Pro.SaveErrorMessage = "Failed, please try again...";

            #endregion

        }

    }
}
