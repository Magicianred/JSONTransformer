﻿using JSONTransform.Utils;
using Newtonsoft.Json.Linq;
using System;

namespace JSONTransform.Models.Conditions
{
    public class EqualsCondition : Comparitor, ICondition
    {
        public EqualsCondition(string condition, JObject resource) : base(condition, resource)
        {
            this.Initialize("==");
        }

        public int isValid()
        {
            if (LeftSideInt.HasValue && RightSideInt.HasValue)
            {
                if (LeftSideInt.Value == RightSideInt.Value) return 1;
                else return 0;
            }
            else if (LeftSideInt.HasValue) return 0;
            else if (RightSideInt.HasValue) return 0;
            else
            {
                if (LeftSide.Trim() == RightSide.Trim()) return 1;
                else return 0;
            }
        }
    }
}
