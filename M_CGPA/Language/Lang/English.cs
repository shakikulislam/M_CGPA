namespace M_CGPA.Language.Lang
{
    class English
    {
        public LanguagePro Pro = new LanguagePro();
        public void Lang()
        {
            Pro.Language = "English";
            Pro.Font = "Segoe UI";

            #region Button

            Pro.BtnClear = "Clear";
            Pro.BtnAdd = "Add";
            Pro.BtnUpdate = "Update";
            Pro.BtnDelete = "Delete";
            Pro.BtnCancel = "Cancel";
            Pro.BtnSearch = "Search";

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
            Pro.Setting = "Setting";
            Pro.TitleClass = "Add Class";
            Pro.ClassName = "Class Name";
            Pro.TitleBook = "Add Book";
            Pro.BookCode = "Book Code";
            Pro.BookName = "Book Name";
            Pro.Year = "Year";
            Pro.TitleSyllabus = "Add Syllabus";

            #endregion

            #region Message

            Pro.MessageTitle = "Message";
            Pro.SaveSuccessMessage = "Successfully saved...";
            Pro.UpdateSuccessMessage = "Updated successfully...";
            Pro.DeleteSuccessMessage = "Deleted successfully.";
            Pro.ErrorMessage = "Failed, please try again...";
            Pro.ClassAlreadyExist = "This class already exists...";
            Pro.BlankFiled = "Please fill out this form and try again.";
            Pro.DeleteConfirmation = "Are you sure, want to delete it?";
            Pro.BookAlreadyExist = "This book already exists...";
            Pro.StudentAlreadyExist = "This student or roll already exists...";

            #endregion

        }

    }
}
