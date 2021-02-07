namespace M_CGPA.Language.Lang
{
    class Bengali
    {
        public LanguagePro Pro = new LanguagePro();
        public void Lang()
        {
            Pro.Language = "Bengali";
            Pro.Font = "SutonnyMJ";

            #region Button

            Pro.BtnClear = "পরিষ্কার করুন";
            Pro.BtnAdd = "যুক্ত করুন";
            Pro.BtnUpdate = "হালনাগাদ";
            Pro.BtnDelete = "এটি মুছুন";

            #endregion

            #region All Field Name

            Pro.Student = "ছাত্র";
            Pro.TitleAddStudent = "ছাত্র যুক্ত করুন";
            Pro.AcademicInformation = "একাডেমিক তথ্য";
            Pro.StudentInformation = "শিক্ষার্থীদের তথ্য";
            Pro.Roll = "রোল";
            Pro.Reg = "নিবন্ধন নম্বর";
            Pro.Session = "সেশন";
            Pro.Class = "শ্রেণী";
            Pro.AdmissionDate = "ভর্তির তারিখ";
            Pro.StudentName = "শিক্ষার্থীর নাম";
            Pro.FatherName = "বাবার নাম";
            Pro.MotherName = "মায়ের নাম";
            Pro.DOB = "জন্ম তারিখ";
            Pro.NID = "এনআইডি";
            Pro.BRN = "জন্ম নিবন্ধন নং";
            Pro.PresentAddress = "বর্তমান ঠিকানা";
            Pro.PermanenetAddress = "স্থায়ী ঠিকানা";
            Pro.Setting = "সেটিংস";
            Pro.TitleClass = "ক্লাস যুক্ত করুন";
            Pro.ClassName = "শ্রেণির নাম";

            #endregion

            #region Message

            Pro.MessageTitle = "বার্তা";
            Pro.SaveSuccessMessage = "সফলভাবে সংরক্ষণ করা হয়েছে...";
            Pro.ErrorMessage = "ব্যর্থ হয়েছে, দয়া করে আবার চেষ্টা করুন...";
            Pro.UpdateSuccessMessage = "সফলভাবে হালনাগাদ হয়েছে...";
            Pro.DeleteSuccessMessage = "সফলভাবে মোছা হয়েছে।";
            Pro.ClassAlreadyExist = "এই শ্রেণিটি ইতিমধ্যে বিদ্যমান...";
            Pro.BlankFiled = "দয়া করে এই ফর্মটি পূরণ করুন এবং আবার চেষ্টা করুন।";
            Pro.DeleteConfirmation = "আপনি কি নিশ্চিত, এটি মুছতে চান?";
            Pro.BookAlreadyExist = "এই বইটি ইতিমধ্যে বিদ্যমান...";

            #endregion
        }
        
    }
}
