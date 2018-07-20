﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactDotNetDemo.Models.PASS
{
    public class IndicatorGroup
    {
        public int IndicatorGroupId { get; set; }
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual ICollection<IndicatorGroupNameTranslation> IndicatorGroupNameTranslations { get; set; }
        public virtual ICollection<LifeCourse> LifeCourses { get; set; }

        public string GetIndicatorGroupName(string lc)
        {
            return IndicatorGroupNameTranslations.Where(t => t.Translation.LanguageCode == lc).Select(t => t.Translation.Text).FirstOrDefault();
        }
    }

    public class IndicatorGroupNameTranslation
    {
        public int IndicatorGroupId { get; set; }
        public virtual IndicatorGroup IndicatorGroup { get; set; }
        public int TranslationId { get; set; }
        public virtual Translation Translation { get; set; }
    }
}
