﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobResume.Models
{
    public class ExtraInfo
    {
        public void addExtraInfo(string extraactivities, string otherinterests, string namep1, string affp1, string php1, string emailp1, string namep2, string affp2, string php2, string emailp2, int userId)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            JobResumeExtra obj = new JobResumeExtra();
            obj.extraactivities = extraactivities;
            obj.otherinterests = otherinterests;
            obj.namep1 = namep1;
            obj.namep2 = namep2;
            obj.affp1 = affp1;
            obj.affp2 = affp2;
            obj.php1 = php1;
            obj.php2 = php2;
            obj.emailp1 = emailp1;
            obj.emailp2 = emailp2;
            obj.userId = userId;
            db.JobResumeExtras.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
    }
}